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
    public partial class DodavanjeIUklanjanjeAdmina : Form
    {
        Admin admin;
        List<Admin> ispisAdmina;
        AplikacijaZaAdmina aplikacija;
        public DodavanjeIUklanjanjeAdmina(AplikacijaZaAdmina aplikacija, Admin admin)
        {
            this.admin = admin;
            this.aplikacija = aplikacija;
            InitializeComponent();
            if (File.Exists("admini.pol"))
            {
                FileStream fs = File.OpenRead("admini.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisAdmina = bf.Deserialize(fs) as List<Admin>;
                fs.Close();
            }
            else
            {
                ispisAdmina = new List<Admin>();
            }
        }

        private void btnNapraviNalog_Click(object sender, EventArgs e)
        {
            DateTime datumRodjenja;
            bool zauzetUsername = false;
            bool popunjeno = true;
            bool jesteGlavniAdmin;
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
            if (!proveriDalSuSamoBrojevi(txtPlata.Text, 2))
            {
                MessageBox.Show("Greska");
                popunjeno = false;
                lblPlata.ForeColor = Color.Red;
            }
            else
            {
                lblPlata.ForeColor = Color.Black;
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
                if (rbtnJesteGlavniAdmin.Checked)
                {
                    jesteGlavniAdmin = true;
                }
                else
                {
                    jesteGlavniAdmin = false;
                }
                if (ispisAdmina.Count > 0)
                {
                    for (int i = 0; i < ispisAdmina.Count; i++)
                    {
                        if (txtUsername.Text == ispisAdmina[i].Username)
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
                        lblUsername.ForeColor = Color.Black;
                        Admin a = new Admin(ispisAdmina[ispisAdmina.Count - 1].Id + 1, txtIme.Text, txtPrezime.Text,
                                            txtUsername.Text, txtPassword.Text, datumRodjenja, jesteGlavniAdmin,
                                            double.Parse(txtPlata.Text), txtTelefon.Text);
                        ispisAdmina.Add(a);
                        upisAdmina();
                        MessageBox.Show("Nalog uspešno napravljen.");
                        this.Close();
                    }
                }
                else
                {
                    Admin a = new Admin(0, txtIme.Text, txtPrezime.Text,
                                        txtUsername.Text, txtPassword.Text, datumRodjenja, jesteGlavniAdmin,
                                        double.Parse(txtPlata.Text), txtTelefon.Text);
                    ispisAdmina.Add(a);
                    upisAdmina();
                    MessageBox.Show("Nalog uspešno napravljen.");
                    this.Close();
                }
            }
        }

        private void namestiDane()
        {
            if (cbxMesec.SelectedItem.ToString() == "januar" ||
                cbxMesec.SelectedItem.ToString() == "mart" ||
                cbxMesec.SelectedItem.ToString() == "maj" ||
                cbxMesec.SelectedItem.ToString() == "jul" ||
                cbxMesec.SelectedItem.ToString() == "avgust" ||
                cbxMesec.SelectedItem.ToString() == "oktobar" ||
                cbxMesec.SelectedItem.ToString() == "decembar")
            {
                if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "30")
                {
                    cbxDan.Items.Add("31");
                }
                else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "28")
                {
                    cbxDan.Items.Add("29");
                    cbxDan.Items.Add("30");
                    cbxDan.Items.Add("31");
                }
                else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "29")
                {
                    cbxDan.Items.Add("30");
                    cbxDan.Items.Add("31");
                }
            }
            else if (cbxMesec.SelectedItem.ToString() == "april" ||
                    cbxMesec.SelectedItem.ToString() == "jun" ||
                    cbxMesec.SelectedItem.ToString() == "septembar" ||
                    cbxMesec.SelectedItem.ToString() == "novembar")
            {
                if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "31")
                {
                    cbxDan.Items.Remove(cbxDan.Items.Count - 1);
                }
                else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "28")
                {
                    cbxDan.Items.Add("29");
                    cbxDan.Items.Add("30");
                }
            }
            else if (cbxMesec.SelectedItem.ToString() == "februar")
            {
                if (DateTime.IsLeapYear(int.Parse(cbxGodine.SelectedItem.ToString())))
                {
                    if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "31")
                    {
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                    }
                    else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "30")
                    {
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                    }
                    else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "28")
                    {
                        cbxDan.Items.Add("29");
                    }
                }
                else if (!DateTime.IsLeapYear(int.Parse(cbxGodine.SelectedItem.ToString())))
                {
                    if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "31")
                    {
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                    }
                    else if (cbxDan.Items[cbxDan.Items.Count - 1].ToString() == "30")
                    {
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                        cbxDan.Items.Remove(cbxDan.Items[cbxDan.Items.Count - 1]);
                    }
                }
            }
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
                    break;
                    mesec = "09";
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

        private void DodavanjeIUklanjanjeAdmina_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                cbxGodine.Items.Add(i.ToString());
            }
            cbxDan.SelectedItem = cbxDan.Items[0];
            cbxMesec.SelectedItem = cbxMesec.Items[0];
            cbxGodine.SelectedItem = cbxGodine.Items[cbxGodine.Items.Count - 1];
            rbtnJesteGlavniAdmin.Checked = true;
            rbtnNijeGlavniAdmin.Checked = false;
        }

        private void cbxMesec_SelectedValueChanged(object sender, EventArgs e)
        {
            namestiDane();
        }

        private void cbxGodine_SelectedValueChanged(object sender, EventArgs e)
        {
            namestiDane();
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
                /*if (!int.TryParse(tekst, out broj))
                {
                    MessageBox.Show("Nije broj.");
                    jesuBrojevi = false;
                }*/
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

        private void upisAdmina()
        {
            if (File.Exists("admini.pol"))
            {
                FileStream fs = File.OpenWrite("admini.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisAdmina as List<Admin>);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create("admini.pol");
                fs.Close();
                fs = File.OpenWrite("admini.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisAdmina as List<Admin>);
                fs.Close();
            }
        }

        private void btnIzlistajNaloge_Click(object sender, EventArgs e)
        {
            izlistajNaloge();
        }

        public void izlistajNaloge()
        {
            lbxAdmini.Items.Clear();
            if (ispisAdmina.Count > 0)
            {
                for (int i = 0; i < ispisAdmina.Count; i++)
                {
                    if (ispisAdmina[i].ToString() == admin.ToString())
                    {
                        continue;
                    }
                    else
                    {
                        lbxAdmini.Items.Add(ispisAdmina[i].ToString());
                    }
                }
                lbxAdmini.SelectedItem = lbxAdmini.Items[0];
            }
        }
        private void lbxAdmini_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ispisAdmina.Count; i++)
            {
                if (ispisAdmina[i].ToString() == lbxAdmini.SelectedItem.ToString())
                {
                    txtIme.Text = ispisAdmina[i].Ime;
                    txtPrezime.Text = ispisAdmina[i].Prezime;
                    cbxGodine.SelectedItem = ispisAdmina[i].DatumRodjenja.Year.ToString();
                    for (int j = 0; j < cbxGodine.Items.Count; j++)
                    {
                        if (cbxGodine.Items[j].ToString() == ispisAdmina[i].DatumRodjenja.Year.ToString())
                        {
                            cbxGodine.SelectedItem = cbxGodine.Items[j];
                        }
                    }
                    for (int j = 0; j < cbxMesec.Items.Count; j++)
                    {
                        if (cbxMesec.Items[j].ToString() == konvertujBrojUMesec(ispisAdmina[i].DatumRodjenja.Month))
                        {
                            cbxMesec.SelectedItem = cbxMesec.Items[j];
                        }
                    }
                    for (int j = 0; j < cbxDan.Items.Count; j++)
                    {
                        if (cbxDan.Items[j].ToString() == ispisAdmina[i].DatumRodjenja.Day.ToString())
                        {
                            cbxDan.SelectedItem = cbxDan.Items[j];
                        }
                    }
                    cbxMesec.SelectedItem = konvertujBrojUMesec(ispisAdmina[i].DatumRodjenja.Month);
                    cbxDan.SelectedItem = ispisAdmina[i].DatumRodjenja.Day.ToString("dd");
                    txtUsername.Text = ispisAdmina[i].Username;
                    txtPassword.Text = ispisAdmina[i].Password;
                    txtPlata.Text = ispisAdmina[i].Plata.ToString();
                    txtTelefon.Text = ispisAdmina[i].Telefon;
                    if (ispisAdmina[i].GlavniAdmin)
                    {
                        rbtnJesteGlavniAdmin.Checked = true;
                        rbtnNijeGlavniAdmin.Checked = false;
                    }
                    else
                    {
                        rbtnJesteGlavniAdmin.Checked = false;
                        rbtnNijeGlavniAdmin.Checked = true;
                    }
                }
            }
        }

        private void btnObrisiNalog_Click(object sender, EventArgs e)
        {
            if (lbxAdmini.SelectedItem == null)
            {
                MessageBox.Show("Niste označili nijedan nalog za brisanje.");
            }
            else
            {
                for (int i = 0; i < ispisAdmina.Count; i++)
                {
                    if (ispisAdmina[i].ToString() == lbxAdmini.SelectedItem.ToString())
                    {
                        ispisAdmina.Remove(ispisAdmina[i]);
                        upisAdmina();
                        lbxAdmini.DataSource = null;
                        lbxAdmini.DataSource = ispisAdmina;
                        if (ispisAdmina.Count == 0)
                        {
                            txtIme.Text = "";
                            txtPrezime.Text = "";
                            cbxGodine.SelectedItem = "01";
                            cbxMesec.SelectedItem = "01";
                            cbxDan.SelectedItem = "2018";
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtPlata.Text = "";
                            txtTelefon.Text = "";
                        }
                    }
                }
            }
        }

        private void DodavanjeIUklanjanjeAdmina_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        private void btnIzmeniNalog_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (lbxAdmini.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijedan nalog za menjanje.");
            }
            else
            {
                for (int i = 0; i < ispisAdmina.Count; i++)
                {
                    if (ispisAdmina[i].ToString() == lbxAdmini.SelectedItem.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                DateTime datumRodjenja;
                bool zauzetUsername = false;
                bool popunjeno = true;
                bool jesteGlavniAdmin;
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
                if (!proveriDalSuSamoBrojevi(txtPlata.Text, 2))
                {
                    popunjeno = false;
                    lblPlata.ForeColor = Color.Red;
                }
                else
                {
                    lblPlata.ForeColor = Color.Black;
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
                    if (rbtnJesteGlavniAdmin.Checked)
                    {
                        ispisAdmina[index].GlavniAdmin = true;
                    }
                    else
                    {
                        ispisAdmina[index].GlavniAdmin = false;
                    }
                    for (int i = 0; i < ispisAdmina.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        else if (txtUsername.Text == ispisAdmina[i].Username)
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
                        ispisAdmina[index].Ime = txtIme.Text;
                        ispisAdmina[index].Prezime = txtPrezime.Text;
                        ispisAdmina[index].DatumRodjenja = datumRodjenja;
                        ispisAdmina[index].Username = txtUsername.Text;
                        ispisAdmina[index].Password = txtPassword.Text;
                        ispisAdmina[index].Plata = double.Parse(txtPlata.Text);
                        ispisAdmina[index].Telefon = txtTelefon.Text;
                        upisAdmina();
                        MessageBox.Show("Nalog uspešno izmenjen.");
                        izlistajNaloge();
                    }
                }
            }
        }
    }
}
