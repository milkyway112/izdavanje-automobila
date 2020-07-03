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
    public partial class Rezervacije : Form
    {
        Admin admin;
        AplikacijaZaAdmina aplikacija;
        List<Kupac> ispisKupaca;
        List<Rezervacija> ispisRezervacija;
        List<Ponuda> ispisPonuda;
        List<Automobil> ispisAutmobila;
        public Rezervacije(Admin admin, AplikacijaZaAdmina aplikacija)
        {
            this.admin = admin;
            this.aplikacija = aplikacija;
            InitializeComponent();
            ispisKupaca = ispisiKupce();
            ispisRezervacija = ispisiRezervacije();
            ispisPonuda = ispisiPonude();
            ispisAutmobila = ispisiAutomobile();
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {

        }

        private void btnIzlistajKupce_Click(object sender, EventArgs e)
        {
            lbxKupci.Items.Clear();
            if (ispisKupaca.Count > 0)
            {
                for (int i = 0; i < ispisKupaca.Count; i++)
                {
                    lbxKupci.Items.Add(ispisKupaca[i].ToString());
                }
            }
            if (lbxKupci.Items.Count > 0)
            {
                lbxKupci.SelectedItem = lbxKupci.Items[0];
            }
        }

        private List<Kupac> ispisiKupce()
        {
            if (File.Exists("kupci.pol"))
            {
                FileStream fs = File.OpenRead("kupci.pol");
                BinaryFormatter bf = new BinaryFormatter();
                List<Kupac> ispisKupaca1 = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();
                return ispisKupaca1;
            }
            else
            {
                List<Kupac> ispisKupaca1 = new List<Kupac>();
                return ispisKupaca1;
            }
        }
        private List<Automobil> ispisiAutomobile()
        {
            if (File.Exists("automobili.pol"))
            {
                FileStream fs = File.OpenRead("automobili.pol");
                BinaryFormatter bf = new BinaryFormatter();
                List<Automobil> ispisAutomobila1 = bf.Deserialize(fs) as List<Automobil>;
                fs.Close();
                return ispisAutomobila1;
            }
            else
            {
                List<Automobil> ispisAutomobila1 = new List<Automobil>();
                return ispisAutomobila1;
            }
        }

        private List<Ponuda> ispisiPonude()
        {
            if (File.Exists("ponude.pol"))
            {
                FileStream fs = File.OpenRead("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                List<Ponuda> ispisPonuda1 = bf.Deserialize(fs) as List<Ponuda>;
                fs.Close();
                return ispisPonuda1;
            }
            else
            {
                List<Ponuda> ispisPonuda1 = new List<Ponuda>();
                return ispisPonuda1;
            }
        }
        private List<Rezervacija> ispisiRezervacije()
        {
            if (File.Exists("rezervacije.pol"))
            {
                FileStream fs = File.OpenRead("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                List<Rezervacija> ispisRezervacija1 = bf.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
                return ispisRezervacija1;
            }
            else
            {
                List<Rezervacija> ispisRezervacija1 = new List<Rezervacija>();
                return ispisRezervacija1;
            }
        }

        private void lbxKupci_SelectedValueChanged(object sender, EventArgs e)
        {
            ispisiRezervacijeKupca(nadjiSelektovaniIdKupca());
        }

        private int nadjiSelektovaniIdKupca()
        {
            int selektovaniIdKupca = -1;
            for (int i = 0; i < ispisKupaca.Count; i++)
            {
                if (lbxKupci.SelectedItem.ToString() == ispisKupaca[i].ToString())
                {
                    selektovaniIdKupca = ispisKupaca[i].Id;
                }
            }
            return selektovaniIdKupca;
        } 

        private void ispisiRezervacijeKupca(int selektovaniIdKupca)
        {
            lbxRezervacije.Items.Clear();
            if (ispisRezervacija.Count > 0)
            {
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (ispisRezervacija[i].IdKupca == selektovaniIdKupca)
                    {
                        lbxRezervacije.Items.Add(ispisRezervacija[i].ToStringZaKupca());
                    }
                }
            }
        }

        private void Rezervacije_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        public int nadjiSelektovanuRezervaciju()
        {
            int index = -1;
            if (lbxRezervacije.SelectedItem != null)
            {
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (ispisRezervacija[i].ToStringZaKupca() == lbxRezervacije.SelectedItem.ToString())
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }

        private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
        {
            if (lbxRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijednu rezervaciju za izmenu.");
            }
            else
            {
                int index = nadjiSelektovanuRezervaciju();
                int selektovaniIdAutomobila = ispisRezervacija[index].IdAutomobila;
                double cena;
                if (!proveriDaliSuDatumiZauzetiURezervacijama(index, ispisRezervacija[index].IdAutomobila) &&
                    (cena = procitajCenu()) > -2)
                {
                    ispisRezervacija[index].DatumOd = dtpDatumOd.Value.Date;
                    ispisRezervacija[index].DatumDo = dtpDatumDo.Value.Date;
                    ispisRezervacija[index].Cena = cena;
                    ispisRezervacija[index].IdAutomobila = selektovaniIdAutomobila;
                    upisRezervacija();
                    updateujPonude(ispisRezervacija[index]);
                    ispisiRezervacijeKupca(nadjiSelektovaniIdKupca());
                    MessageBox.Show("Rezervacija uspešno izmenjena.");
                }
            }
        }

        private void lbxRezervacije_SelectedValueChanged(object sender, EventArgs e)
        {
            int index;
            if (lbxRezervacije.SelectedItem != null)
            {
                if (lbxRezervacije.Items.Count > 0)
                {
                    index = nadjiSelektovanuRezervaciju();
                    dtpDatumOd.Value = ispisRezervacija[index].DatumOd;
                    dtpDatumDo.Value = ispisRezervacija[index].DatumDo;
                    txtCena.Text = ispisRezervacija[index].Cena.ToString("0.00");
                }
            }
        }

        private bool proveriDaLiSuDatumiZauzeti(int index, int idAutomobila)
        {
            if (!File.Exists("ponude.pol"))
            {
                return false;
            }
            bool zauzet = false;
            string zauzetiDatumi = "";
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (ispisPonuda[i].IdAutomobila == idAutomobila)
                {
                    if ((dtpDatumOd.Value.Date >= ispisPonuda[i].DatumOd.Date && dtpDatumOd.Value.Date <= ispisPonuda[i].DatumDo.Date)
                        || (dtpDatumDo.Value.Date >= ispisPonuda[i].DatumOd.Date && dtpDatumDo.Value.Date <= ispisPonuda[i].DatumDo.Date)
                        || dtpDatumOd.Value.Date <= ispisPonuda[i].DatumOd.Date && dtpDatumDo.Value.Date >= ispisPonuda[i].DatumDo.Date
                        || dtpDatumOd.Value.Date == ispisPonuda[i].DatumOd.Date
                        || dtpDatumOd.Value.Date == ispisPonuda[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisPonuda[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisPonuda[i].DatumOd.Date)
                    {
                        zauzetiDatumi += Environment.NewLine + ispisPonuda[i].DatumOd.ToString("dd/MM/yyyy") + " - "
                                            + ispisPonuda[i].DatumDo.ToString("dd/MM/yyyy");
                        zauzet = true;
                    }
                }
            }
            if (zauzet == true)
            {
                MessageBox.Show("Za ovaj automobil vec postoji ponuda za periode:" + zauzetiDatumi);
            }
            else
            {
                zauzet = proveriDaliSuDatumiZauzetiURezervacijama(index, idAutomobila);
            }
            return zauzet;
        }

        private bool proveriDaLiSuDatumiZauzeti(Rezervacija rezervacija)
        {
            if (!File.Exists("ponude.pol"))
            {
                return false;
            }
            bool zauzet = false;
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (ispisPonuda[i].IdAutomobila == rezervacija.IdAutomobila)
                {
                    if ((rezervacija.DatumOd.Date >= ispisPonuda[i].DatumOd.Date && rezervacija.DatumOd.Date <= ispisPonuda[i].DatumDo.Date)
                        || (rezervacija.DatumDo.Date >= ispisPonuda[i].DatumOd.Date && rezervacija.DatumDo.Date <= ispisPonuda[i].DatumDo.Date)
                        || rezervacija.DatumOd.Date <= ispisPonuda[i].DatumOd.Date && rezervacija.DatumDo.Date >= ispisPonuda[i].DatumDo.Date
                        || rezervacija.DatumOd.Date == ispisPonuda[i].DatumOd.Date
                        || rezervacija.DatumOd.Date == ispisPonuda[i].DatumDo.Date
                        || rezervacija.DatumDo.Date == ispisPonuda[i].DatumDo.Date
                        || rezervacija.DatumDo.Date == ispisPonuda[i].DatumOd.Date)
                    {
                        zauzet = true;
                        break;
                    }
                }
            }
            return zauzet;
        }
        private bool proveriDaliSuDatumiZauzetiURezervacijama(int index, int idAutomobila)
        {
            bool datumRezervisan = false;
            string rezervisaniDatumi = "";
            for (int i = 0; i < ispisRezervacija.Count; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (idAutomobila == ispisRezervacija[i].IdAutomobila)
                {
                    if ((dtpDatumOd.Value.Date >= ispisRezervacija[i].DatumOd.Date && dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumDo.Date)
                        || (dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date <= ispisRezervacija[i].DatumDo.Date)
                        || (dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumDo.Date)
                        || dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumDo.Date
                        || dtpDatumOd.Value.Date == ispisRezervacija[i].DatumOd.Date
                        || dtpDatumOd.Value.Date == ispisRezervacija[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisRezervacija[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisRezervacija[i].DatumOd.Date)
                    {
                        rezervisaniDatumi += Environment.NewLine + ispisRezervacija[i].DatumOd.ToString("dd/MM/yyyy") + " - "
                                             + ispisRezervacija[i].DatumDo.ToString("dd/MM/yyyy");
                        datumRezervisan = true;
                    }
                }
            }
            if (datumRezervisan == true)
            {
                MessageBox.Show("Ne možete napraviti ponudu za ovaj automobil u izabranom periodu," +
                                Environment.NewLine + "rezervisani su sledeci periodi:" + rezervisaniDatumi);
            }
            return datumRezervisan;
        }

        private bool proveriDaliSuDatumiZauzetiURezervacijama(int idAutomobila)
        {
            bool datumRezervisan = false;
            string rezervisaniDatumi = "";
            for (int i = 0; i < ispisRezervacija.Count; i++)
            {
                if (idAutomobila == ispisRezervacija[i].IdAutomobila)
                {
                    if ((dtpDatumOd.Value.Date >= ispisRezervacija[i].DatumOd.Date && dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumDo.Date)
                        || (dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date <= ispisRezervacija[i].DatumDo.Date)
                        || (dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumDo.Date)
                        || dtpDatumOd.Value.Date <= ispisRezervacija[i].DatumOd.Date && dtpDatumDo.Value.Date >= ispisRezervacija[i].DatumDo.Date
                        || dtpDatumOd.Value.Date == ispisRezervacija[i].DatumOd.Date
                        || dtpDatumOd.Value.Date == ispisRezervacija[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisRezervacija[i].DatumDo.Date
                        || dtpDatumDo.Value.Date == ispisRezervacija[i].DatumOd.Date)
                    {
                        rezervisaniDatumi += Environment.NewLine + ispisRezervacija[i].DatumOd.ToString("dd/MM/yyyy") + " - "
                                             + ispisRezervacija[i].DatumDo.ToString("dd/MM/yyyy");
                        datumRezervisan = true;
                    }
                }
            }
            if (datumRezervisan == true)
            {
                MessageBox.Show("Ne možete napraviti ponudu za ovaj automobil u izabranom periodu," +
                                Environment.NewLine + "rezervisani su sledeci periodi:" + rezervisaniDatumi);
            }
            return datumRezervisan;
        }

        private double procitajCenu()
        {
            double cenaPoDanu;
            if (txtCena.Text.Length > 0)
            {
                if (!double.TryParse(txtCena.Text, out cenaPoDanu))
                {
                    MessageBox.Show("Cena po danu nije upisana u ispravnom formatu!");
                    lblCena.ForeColor = Color.Red;
                    return -2;
                }
                else
                {
                    lblCena.ForeColor = Color.Black;
                    return cenaPoDanu;
                }
            }
            else
            {
                MessageBox.Show("Niste upisali cenu rezervacije!");
                lblCena.ForeColor = Color.Black;
                return -1;
            }
        }
        private void upisRezervacija()
        {
            if (File.Exists("rezervacije.pol"))
            {
                FileStream fs = File.OpenWrite("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisRezervacija as List<Rezervacija>);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create("rezervacije.pol");
                fs.Close();
                fs = File.OpenWrite("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisRezervacija as List<Rezervacija>);
                fs.Close();
            }
        }

        private void btnIzlistajAutomobile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ispisAutmobila.Count; i++)
            {
                lbxAutomobili.Items.Add(ispisAutmobila[i].ToStringZaKupca());
            }
        }

        private int nadjiSelektovaniIdAutomobila()
        {
            char[] selektovaniIdC;
            string selektovaniIdS = "";
            int selektovaniId;
            selektovaniIdC = lbxAutomobili.SelectedItem.ToString().ToCharArray();
            for (int i = 4; selektovaniIdC[i] != ','; i++)
            {
                selektovaniIdS += selektovaniIdC[i];
            }
            selektovaniId = int.Parse(selektovaniIdS);
            return selektovaniId;
        }

        private void napraviPonudu(Rezervacija rezervacija)
        {
            string novePonuda = "";
            if (!proveriDaLiSuDatumiZauzeti(rezervacija))
            {
                double cenaPoDanu = rezervacija.Cena /
                    ((rezervacija.DatumDo - rezervacija.DatumOd).Days + 1);
                Ponuda p = new Ponuda(rezervacija.IdAutomobila,
                                        cenaPoDanu, rezervacija.DatumOd, rezervacija.DatumDo);
                novePonuda += Environment.NewLine + "ID automobila: " + p.IdAutomobila
                                + ", " + p.DatumOd.ToString("dd/MM/yyy") + " - " + p.DatumDo.ToString("dd/MM/yyy")
                                + ", " + cenaPoDanu.ToString("0.00") + " rsd";
                if ((MessageBox.Show(novePonuda, "Da li želite da dodate sledecu ponudu?",
                                     MessageBoxButtons.OKCancel)) == DialogResult.OK)
                {
                    ispisPonuda.Add(p);
                    upisPonuda();
                }
            }
        }
        private void upisPonuda()
        {
            if (File.Exists("ponude.pol"))
            {
                FileStream fs = File.OpenWrite("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create("ponude.pol");
                fs.Close();
                fs = File.OpenWrite("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                fs.Close();
            }
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumOd.Value.Date > dtpDatumDo.Value.Date)
            {
                dtpDatumDo.Value = dtpDatumOd.Value;
            }
            if (lbxRezervacije.SelectedItem != null)
            {
                int index = nadjiSelektovanuRezervaciju();
                double cenaPoDanu;
                cenaPoDanu = ispisRezervacija[index].Cena /
                             ((ispisRezervacija[index].DatumDo.Date - ispisRezervacija[index].DatumOd.Date).Days + 1);
                txtCena.Text = (cenaPoDanu * ((dtpDatumDo.Value.Date - dtpDatumOd.Value.Date).Days + 1)).ToString("0.00");
            }
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumDo.Value.Date < dtpDatumOd.Value.Date)
            {
                dtpDatumOd.Value = dtpDatumDo.Value;
            }
            if (lbxRezervacije.SelectedItem != null)
            {
                int index = nadjiSelektovanuRezervaciju();
                double cenaPoDanu;
                cenaPoDanu = ispisRezervacija[index].Cena /
                                ((ispisRezervacija[index].DatumDo.Date - ispisRezervacija[index].DatumOd.Date).Days + 1);
                txtCena.Text = (cenaPoDanu * ((dtpDatumDo.Value.Date - dtpDatumOd.Value.Date).Days + 1)).ToString("0.00");
            }
        }

        private void btnIzbrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if (lbxRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijednu rezervaciju!");
            }
            else
            {
                int index = nadjiSelektovanuRezervaciju();
                napraviPonudu(ispisRezervacija[index]);
                ispisRezervacija.Remove(ispisRezervacija[index]);
                upisRezervacija();
                if (lbxKupci.SelectedItem != null)
                {
                    ispisiRezervacijeKupca(nadjiSelektovaniIdKupca());
                }
                MessageBox.Show("Rezervacija uspešno obrisana.");
            }
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            double cena;
            if (lbxKupci.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali kupca za rezervaciju!");
            }
            else if (lbxAutomobili.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali automobil za rezervaciju!");
            }
            else if ((cena = procitajCenu()) > 0 && !proveriDaliSuDatumiZauzetiURezervacijama(nadjiSelektovaniIdAutomobila()))
            {
                Rezervacija rezervacija = new Rezervacija(nadjiSelektovaniIdAutomobila(), nadjiSelektovaniIdKupca(),
                                          dtpDatumOd.Value, dtpDatumDo.Value, cena);
                ispisRezervacija.Add(rezervacija);
                upisRezervacija();
                updateujPonude(rezervacija);
                MessageBox.Show("Rezervacija uspešno dodata.");
            }
        }

        private void updateujPonude(Rezervacija rezervacija)
        {
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (dtpDatumOd.Value.Date > ispisPonuda[i].DatumOd.Date &&
                dtpDatumDo.Value.Date < ispisPonuda[i].DatumDo.Date)
                {
                    Ponuda p1 = new Ponuda(rezervacija.IdAutomobila, ispisPonuda[i].CenaPoDanu,
                                           ispisPonuda[i].DatumOd, dtpDatumOd.Value.AddDays(-1));
                    Ponuda p2 = new Ponuda(rezervacija.IdAutomobila, ispisPonuda[i].CenaPoDanu,
                                           dtpDatumDo.Value.AddDays(1), ispisPonuda[i].DatumDo);
                    ispisPonuda.Remove(ispisPonuda[i]);
                    ispisPonuda.Add(p1);
                    ispisPonuda.Add(p2);
                    upisPonuda();
                }
                else if (dtpDatumOd.Value.Date <= ispisPonuda[i].DatumOd.Date &&
                    dtpDatumDo.Value.Date >= ispisPonuda[i].DatumDo.Date)
                {
                    ispisPonuda.Remove(ispisPonuda[i]);
                    upisPonuda();
                }
                else if (dtpDatumDo.Value.Date == ispisPonuda[i].DatumDo.Date
                         && dtpDatumOd.Value.Date > ispisPonuda[i].DatumOd)
                {
                    ispisPonuda[i].DatumDo = dtpDatumOd.Value.AddDays(-1);
                    upisPonuda();
                }
                else if (dtpDatumOd.Value.Date == ispisPonuda[i].DatumOd.Date
                         && dtpDatumDo.Value.Date < ispisPonuda[i].DatumDo)
                {
                    ispisPonuda[i].DatumOd = dtpDatumDo.Value.AddDays(1);
                    upisPonuda();
                }
                else if (dtpDatumDo.Value.Date >= ispisPonuda[i].DatumOd.Date
                         && dtpDatumOd.Value.Date <= ispisPonuda[i].DatumOd)
                {
                    ispisPonuda[i].DatumOd = dtpDatumDo.Value.AddDays(1);
                    upisPonuda();
                }
                else if (dtpDatumOd.Value.Date <= ispisPonuda[i].DatumDo.Date
                         && dtpDatumDo.Value.Date >= ispisPonuda[i].DatumDo)
                {
                    ispisPonuda[i].DatumDo = dtpDatumOd.Value.AddDays(-1);
                    upisPonuda();
                }
            }
            
        }
    }
}
