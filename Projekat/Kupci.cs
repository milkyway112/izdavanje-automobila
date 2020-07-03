using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Projekat
{
    public partial class Kupci : Form
    {
        Admin admin;
        AplikacijaZaAdmina aplikacija;
        List<Kupac> ispisKupaca;
        public Kupci(Admin admin, AplikacijaZaAdmina aplikacija)
        {
            this.admin = admin;
            this.aplikacija = aplikacija;
            InitializeComponent();
            if (File.Exists("kupci.pol"))
            {
                FileStream fs = File.OpenRead("kupci.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisKupaca = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();
            }
            else
            {
                ispisKupaca = new List<Kupac>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datumRodjenja;
            bool zauzetJmbg = false;
            bool zauzetUsername = false;
            bool popunjeno = true;
            if (txtIme.Text.Length == 0)
            {
                popunjeno = false;
                lblIme.ForeColor = Color.Red;
            }
            else
            {
                lblIme.ForeColor = Color.Black;
            }
            if (txtPrezime.Text.Length == 0)
            {
                popunjeno = false;
                lblPrezime.ForeColor = Color.Red;
            }
            else
            {
                lblPrezime.ForeColor = Color.Black;
            }
            if (!proveriDalSuSamoBrojevi(txtJmbg.Text, 1))
            {
                MessageBox.Show("Greska");
                popunjeno = false;
                lblJmbg.ForeColor = Color.Red;
            }
            else
            {
                lblJmbg.ForeColor = Color.Black;
            }
            if (txtTelefon.Text.Length == 0 || !proveriDalSuSamoBrojevi(txtTelefon.Text, 2))
            {
                popunjeno = false;
                lblTelefon.ForeColor = Color.Red;
            }
            else
            {
                lblTelefon.ForeColor = Color.Black;
            }
            if (txtUsername.Text.Length == 0)
            {
                popunjeno = false;
                lblUsername.ForeColor = Color.Red;
            }
            else
            {
                lblUsername.ForeColor = Color.Black;
            }
            if (txtPassword.Text.Length == 0)
            {
                popunjeno = false;
                lblPassword.ForeColor = Color.Red;
            }
            else
            {
                lblPassword.ForeColor = Color.Black;
            }
            if (!popunjeno)
            {
                MessageBox.Show("Niste ispravno uneli podatke!");
            }
            else
            {
                string datumRodjenjaS = cbxDan.SelectedItem.ToString() + "/" + konvertujMesecUBroj()
                                        + "/" + cbxGodine.SelectedItem.ToString();
                datumRodjenja = DateTime.ParseExact(datumRodjenjaS, "dd/MM/yyyy",
                                                    System.Globalization.CultureInfo.InvariantCulture);
                if (ispisKupaca.Count > 0)
                {
                    for (int i = 0; i < ispisKupaca.Count; i++)
                    {
                        if (txtUsername.Text == ispisKupaca[i].Username)
                        {
                            zauzetUsername = true;
                        }
                        if (txtJmbg.Text == ispisKupaca[i].Jmbg)
                        {
                            zauzetJmbg = true;
                        }
                    }
                    if (zauzetUsername)
                    {
                        lblUsername.ForeColor = Color.Red;
                        MessageBox.Show("Ovaj username je zauzet, molimo vas napravite drugaciji.");
                    }
                    else if (zauzetJmbg)
                    {
                        lblJmbg.ForeColor = Color.Red;
                        MessageBox.Show("Ovaj JMBG vec postoji u našoj bazi, molimo vas proverite da li ste ga ispravno uneli.");
                    }
                    else
                    {
                        lblUsername.ForeColor = Color.Black;
                        lblJmbg.ForeColor = Color.Black;
                        Kupac k = new Kupac(ispisKupaca[ispisKupaca.Count - 1].Id + 1, txtIme.Text, txtPrezime.Text,
                                            txtUsername.Text, txtPassword.Text, txtJmbg.Text, datumRodjenja,
                                            txtTelefon.Text);
                        ispisKupaca.Add(k);
                        upisKupaca();
                        MessageBox.Show("Nalog uspešno napravljen.");
                        this.Close();
                    }
                }
                else
                {
                    Kupac k = new Kupac(0, txtIme.Text, txtPrezime.Text,
                    txtUsername.Text, txtPassword.Text, txtJmbg.Text, datumRodjenja,
                    txtTelefon.Text);
                    ispisKupaca.Add(k);
                    upisKupaca();
                    MessageBox.Show("Nalog uspešno napravljen.");
                    this.Close();
                }
            }
        }

        private bool proveriDalSuSamoBrojevi(string tekst, int opcija)
        {
            int broj;
            bool jesuBrojevi = true;
            if (opcija == 1)
            {
                if (tekst.Length != 13)
                {
                    jesuBrojevi = false;
                }
                char[] tekstC = tekst.ToCharArray();
                for (int i = 0; i < tekstC.Length; i++)
                {
                    if (!int.TryParse(tekstC[i].ToString(), out broj))
                    {
                        jesuBrojevi = false;
                        break;
                    }
                }
            }
            else if (opcija == 2)
            {
                if (!int.TryParse(tekst, out broj))
                {
                    jesuBrojevi = false;
                }
            }
            return jesuBrojevi;
        }

        private string konvertujMesecUBroj()
        {
            string mesec = "01";
            switch (cbxMesec.SelectedItem.ToString())
            {
                case "januar":
                    mesec = "01";
                    break;
                case "februar":
                    mesec = "02";
                    break;
                case "mart":
                    mesec = "03";
                    break;
                case "april":
                    mesec = "04";
                    break;
                case "maj":
                    mesec = "05";
                    break;
                case "jun":
                    mesec = "06";
                    break;
                case "jul":
                    mesec = "07";
                    break;
                case "avgust":
                    mesec = "08";
                    break;
                case "septembar":
                    mesec = "09";
                    break;
                case "oktobar":
                    mesec = "10";
                    break;
                case "novembar":
                    mesec = "11";
                    break;
                case "decembar":
                    mesec = "12";
                    break;
                default:
                    mesec = "01";
                    break;
            }
            return mesec;
        }

        private void upisKupaca()
        {
            if (File.Exists("kupci.pol"))
            {
                FileStream fs = File.OpenWrite("kupci.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisKupaca as List<Kupac>);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create("kupci.pol");
                fs.Close();
                fs = File.OpenWrite("kupci.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisKupaca as List<Kupac>);
                fs.Close();
            }
        }

        private void btnIzlistajNaloge_Click(object sender, EventArgs e)
        {
            izlistajNaloge();
        }

        public void izlistajNaloge()
        {
            lbxKupci.Items.Clear();
            if (ispisKupaca.Count > 0)
            {
                for (int i = 0; i < ispisKupaca.Count; i++)
                {
                    lbxKupci.Items.Add(ispisKupaca[i].ToString());
                }
                if (ispisKupaca.Count > 0)
                {
                    lbxKupci.SelectedItem = lbxKupci.Items[0];
                }
            }
        }

        private void lbxKupci_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ispisKupaca.Count > 0)
            {
                for (int i = 0; i < ispisKupaca.Count; i++)
                {
                    if (ispisKupaca[i].ToString() == lbxKupci.SelectedItem.ToString())
                    {
                        txtIme.Text = ispisKupaca[i].Ime;
                        txtPrezime.Text = ispisKupaca[i].Prezime;
                        for (int j = 0; j < cbxGodine.Items.Count; j++)
                        {
                            if (cbxGodine.Items[j].ToString() == ispisKupaca[i].DatumRodjenja.Year.ToString())
                            {
                                cbxGodine.SelectedItem = cbxGodine.Items[j];
                            }
                        }
                        for (int j = 0; j < cbxMesec.Items.Count; j++)
                        {
                            if (cbxMesec.Items[j].ToString() == konvertujBrojUMesec(ispisKupaca[i].DatumRodjenja.Month))
                            {
                                cbxMesec.SelectedItem = cbxMesec.Items[j];
                            }
                        }
                        string dan;
                        if (ispisKupaca[i].DatumRodjenja.Day.ToString().Length == 1)
                        {
                            dan = "0" + ispisKupaca[i].DatumRodjenja.Day.ToString();
                        }
                        else
                        {
                            dan = ispisKupaca[i].DatumRodjenja.Day.ToString();
                        }
                        for (int j = 0; j < cbxDan.Items.Count; j++)
                        {
                            if (cbxDan.Items[j].ToString() == dan)
                            {
                                cbxDan.SelectedItem = cbxDan.Items[j];
                            }
                        }
                        txtUsername.Text = ispisKupaca[i].Username;
                        txtPassword.Text = ispisKupaca[i].Password;
                        txtTelefon.Text = ispisKupaca[i].Telefon;
                        txtJmbg.Text = ispisKupaca[i].Jmbg;
                        break;
                    }
                }
            }
        }

        private string konvertujBrojUMesec(int broj)
        {
            string mesec = "januar";
            switch (broj)
            {
                case 1:
                    mesec = "januar";
                    break;
                case 2:
                    mesec = "februar";
                    break;
                case 3:
                    mesec = "mart";
                    break;
                case 4:
                    mesec = "april";
                    break;
                case 5:
                    mesec = "maj";
                    break;
                case 6:
                    mesec = "jun";
                    break;
                case 7:
                    mesec = "jul";
                    break;
                case 8:
                    mesec = "avgust";
                    break;
                case 9:
                    break;
                    mesec = "septembar";
                case 10:
                    mesec = "oktobar";
                    break;
                case 11:
                    mesec = "novembar";
                    break;
                case 12:
                    mesec = "decembar";
                    break;
                default:
                    mesec = "januar";
                    break;
            }
            return mesec;
        }

        private void Kupci_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                cbxGodine.Items.Add(i.ToString());
            }
            cbxDan.SelectedItem = cbxDan.Items[0];
            cbxMesec.SelectedItem = cbxMesec.Items[0];
            cbxGodine.SelectedItem = cbxGodine.Items[cbxGodine.Items.Count - 1];
        }

        private void Kupci_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        private void btnObrisiNalog_Click(object sender, EventArgs e)
        {
            if (lbxKupci.SelectedItem == null)
            {
                MessageBox.Show("Niste označili nijedan nalog za brisanje.");
            }
            else
            {
                for (int i = 0; i < ispisKupaca.Count; i++)
                {
                    if (ispisKupaca[i].ToString() == lbxKupci.SelectedItem.ToString())
                    {
                        string rezervacije = proveriDaLiNalogImaRezervacije(ispisKupaca[i].Id);
                        if (rezervacije.Length > 0)
                        {
                            if ((MessageBox.Show("Ovaj nalog ima sledece rezervacije:" + rezervacije, 
                                                 "Da li ste sigurni da zelite da obrišete izbrani nalog?", 
                                                     MessageBoxButtons.OKCancel)) == DialogResult.OK)
                            {
                                napraviPonude(procitajRezervacije(), ispisKupaca[i].Id);
                                obrisiRezervacije(ispisKupaca[i].Id);
                                obrisiKupca(i);
                            }
                        }
                        else
                        {
                            obrisiKupca(i);
                        }
                    }
                }
            }
        }

        private void btnIzmeniNalog_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (lbxKupci.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijedan nalog za menjanje.");
            }
            else
            {
                for (int i = 0; i < ispisKupaca.Count; i++)
                {
                    if (ispisKupaca[i].ToString() == lbxKupci.SelectedItem.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                DateTime datumRodjenja;
                bool zauzetUsername = false;
                bool popunjeno = true;
                if (txtIme.Text.Length == 0)
                {
                    popunjeno = false;
                    lblIme.ForeColor = Color.Red;
                }
                else
                {
                    lblIme.ForeColor = Color.Black;
                }
                if (txtPrezime.Text.Length == 0)
                {
                    popunjeno = false;
                    lblPrezime.ForeColor = Color.Red;
                }
                else
                {
                    lblPrezime.ForeColor = Color.Black;
                }
                if (!proveriDalSuSamoBrojevi(txtJmbg.Text, 1))
                {
                    popunjeno = false;
                    lblJmbg.ForeColor = Color.Red;
                }
                else
                {
                    lblJmbg.ForeColor = Color.Black;
                }
                if (txtTelefon.Text.Length == 0 || !proveriDalSuSamoBrojevi(txtTelefon.Text, 2))
                {
                    popunjeno = false;
                    lblTelefon.ForeColor = Color.Red;
                }
                else
                {
                    lblTelefon.ForeColor = Color.Black;
                }
                if (txtUsername.Text.Length == 0)
                {
                    popunjeno = false;
                    lblUsername.ForeColor = Color.Red;
                }
                else
                {
                    lblUsername.ForeColor = Color.Black;
                }
                if (txtPassword.Text.Length == 0)
                {
                    popunjeno = false;
                    lblPassword.ForeColor = Color.Red;
                }
                else
                {
                    lblPassword.ForeColor = Color.Black;
                }
                if (!popunjeno)
                {
                    MessageBox.Show("Niste ispravno uneli podatke!");
                }
                else
                {
                    string datumRodjenjaS = cbxDan.SelectedItem.ToString() + "/" + konvertujMesecUBroj()
                                            + "/" + cbxGodine.SelectedItem.ToString();
                    datumRodjenja = DateTime.ParseExact(datumRodjenjaS, "dd/MM/yyyy",
                                                        System.Globalization.CultureInfo.InvariantCulture);
                    for (int i = 0; i < ispisKupaca.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        else if (txtUsername.Text == ispisKupaca[i].Username)
                        {
                            zauzetUsername = true;
                        }
                    }
                    if (zauzetUsername)
                    {
                        lblUsername.ForeColor = Color.Red;
                        MessageBox.Show("Ovaj username je zauzet, molimo vas napravite drugaciji.");
                    }
                    else
                    {
                        ispisKupaca[index].Ime = txtIme.Text;
                        ispisKupaca[index].Prezime = txtPrezime.Text;
                        ispisKupaca[index].DatumRodjenja = datumRodjenja;
                        ispisKupaca[index].Username = txtUsername.Text;
                        ispisKupaca[index].Password = txtPassword.Text;
                        ispisKupaca[index].Jmbg = txtJmbg.Text;
                        ispisKupaca[index].Telefon = txtTelefon.Text;
                        upisKupaca();
                        MessageBox.Show("Nalog uspešno izmenjen.");
                        izlistajNaloge();
                    }
                }
            }
        }

        public string proveriDaLiNalogImaRezervacije(int idKupca)
        {
            string rezervacije = "";
            List<Rezervacija> ispisRezervacija = procitajRezervacije();
            if (ispisRezervacija == null)
            {
                return rezervacije;
            }
            else
            {
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (idKupca == ispisRezervacija[i].IdKupca)
                    {
                        rezervacije += Environment.NewLine + "ID automobila: " + ispisRezervacija[i].IdAutomobila + ", "
                                       + ispisRezervacija[i].DatumOd.ToString("dd/MM/yyyy") + " - "
                                       + ispisRezervacija[i].DatumDo.ToString("dd/MM/yyyy")
                                       + ", " + ispisRezervacija[i].Cena.ToString("0.00") + " rsd";
                    }
                }
                return rezervacije;
            }
        }

        private List<Rezervacija> procitajRezervacije()
        {
            if (File.Exists("rezervacije.pol"))
            {
                FileStream fs = File.OpenRead("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                List<Rezervacija> ispisRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
                if (ispisRezervacija.Count > 0)
                {
                    return ispisRezervacija;
                }
            }
            return null;
        }

        public void obrisiRezervacije(int idKupca)
        {
            List<Rezervacija> ispisRezervacija;
            if ((ispisRezervacija = procitajRezervacije()) != null)
            {
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (ispisRezervacija[i].IdKupca == idKupca)
                    {
                        ispisRezervacija.Remove(ispisRezervacija[i]);
                    }
                }
                upisRezervacija(ispisRezervacija);
            }
        }

        private void upisRezervacija(List<Rezervacija> ispisRezervacija)
        {
            FileStream fs = File.OpenWrite("rezervacije.pol");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ispisRezervacija as List<Rezervacija>);
            fs.Close();
        }

        private void obrisiKupca(int index)
        {
            ispisKupaca.Remove(ispisKupaca[index]);
            upisKupaca();
            lbxKupci.DataSource = null;
            lbxKupci.DataSource = ispisKupaca;
            if (ispisKupaca.Count == 0)
            {
                txtIme.Text = "";
                txtPrezime.Text = "";
                cbxGodine.SelectedItem = "01";
                cbxMesec.SelectedItem = "01";
                cbxDan.SelectedItem = "2018";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtTelefon.Text = "";
                txtJmbg.Text = "";
            }
        }

        private void napraviPonude(List<Rezervacija> ispisRezervacija, int idKupca)
        {
            List<Ponuda> novePonudeLista = new List<Ponuda>();
            List<Ponuda> ispisPonuda = ispisiPonude();
            string novePonude = "";
            for (int i = 0; i < ispisRezervacija.Count; i++)
            {
                if (ispisRezervacija[i].IdKupca == idKupca)
                {
                    double cenaPoDanu = ispisRezervacija[i].Cena /
                                        ((ispisRezervacija[i].DatumDo - ispisRezervacija[i].DatumOd).Days + 1);
                    Ponuda p = new Ponuda(ispisRezervacija[i].IdAutomobila,
                                          cenaPoDanu, ispisRezervacija[i].DatumOd, ispisRezervacija[i].DatumDo);
                    novePonudeLista.Add(p);
                    novePonude += Environment.NewLine +  "ID automobila: " + p.IdAutomobila 
                                  + ", " + p.DatumOd.ToString("dd/MM/yyy") + " - " + p.DatumDo.ToString("dd/MM/yyy") 
                                  + ", " + cenaPoDanu.ToString("0.00") + " rsd";
                }
            }
            if ((MessageBox.Show(novePonude, "Da li želite da dodate sledece ponude?",
                                 MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                for (int i = 0; i < novePonudeLista.Count; i++)
                {
                    ispisPonuda.Add(novePonudeLista[i]);
                }
                upisPonuda(ispisPonuda);
            }
        }

        private List<Ponuda> ispisiPonude()
        {
            FileStream fs = File.OpenRead("ponude.pol");
            BinaryFormatter bf = new BinaryFormatter();
            List<Ponuda> ispisPonuda = bf.Deserialize(fs) as List<Ponuda>;
            fs.Close();
            return ispisPonuda;
        }

        private void upisPonuda(List<Ponuda> ispisPonuda)
        {
            if (File.Exists("ponude.pol"))
            {
                FileStream fs = File.OpenWrite("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                fs.Close();
            }
        }
    }
}
