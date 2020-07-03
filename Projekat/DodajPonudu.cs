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
    public partial class DodajPonudu : Form
    {
        List<Automobil> ispisAutomobila;
        List<Ponuda> ispisPonuda;
        List<Rezervacija> ispisRezervacija;
        AplikacijaZaAdmina aplikacija;
        Admin admin;
        public DodajPonudu(Admin admin, AplikacijaZaAdmina aplikacija)
        {
            this.admin = admin;
            this.aplikacija = aplikacija;
            InitializeComponent();
            FileStream fs = File.OpenRead("automobili.pol");
            BinaryFormatter bf = new BinaryFormatter();
            ispisAutomobila = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            if (File.Exists("ponude.pol"))
            {
                fs = File.OpenRead("ponude.pol");
                ispisPonuda = bf.Deserialize(fs) as List<Ponuda>;
                fs.Close();
            }
            else
            {
                ispisPonuda = new List<Ponuda>();
            }
            if (File.Exists("rezervacije.pol"))
            {
                fs = File.OpenRead("rezervacije.pol");
                bf = new BinaryFormatter();
                ispisRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
            }
            else
            {
                ispisRezervacija = new List<Rezervacija>();
            }
        }

        private void btnIzlistajAutomobile_Click(object sender, EventArgs e)
        {
            if (lbxAutomobili.DataSource == null)
            {
                lbxAutomobili.DataSource = ispisAutomobila;
            }
        }

        private void lbxAutomobili_SelectedValueChanged(object sender, EventArgs e)
        {
            int selektovaniId = nadjiSelektovaniIdAutomobila();
            lbxPonude.Items.Clear();
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (selektovaniId == ispisPonuda[i].IdAutomobila)
                {
                    lbxPonude.Items.Add(ispisPonuda[i].ToString());
                }
            }
            poredjajPonudePoDatumima();
        }

        private void btnIzmeniPonudu_Click(object sender, EventArgs e)
        {
            int i;
            double cenaPoDanu = procitajCenuPoDanu();
            if ((i = nadjiSelektovanuPonudu()) > -1 &&
                     (cenaPoDanu >= -1) && !proveriDaLiSuDatumiZauzeti(i))
            {
                ispisPonuda[i].DatumDo = dtpDatumDo.Value;
                ispisPonuda[i].DatumOd = dtpDatumOd.Value;
                if (cenaPoDanu > -1)
                {
                    ispisPonuda[i].CenaPoDanu = cenaPoDanu;
                }
                upisPonuda();
                lbxPonude.Items.Remove(lbxPonude.SelectedItem);
                lbxPonude.Items.Add(ispisPonuda[i].ToString());
                poredjajPonudePoDatumima();
                MessageBox.Show("Ponuda uspešno izmenjena.");
            }
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumOd.Value > dtpDatumDo.Value)
            {
                dtpDatumDo.Value = dtpDatumOd.Value;
            }
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumDo.Value < dtpDatumOd.Value)
            {
                dtpDatumOd.Value = dtpDatumDo.Value;
            }
        }

        private void btnDodajPonudu_Click_1(object sender, EventArgs e)
        {
            int selektovaniIdAutomobila;
            double cenaPoDanu = procitajCenuPoDanu();
            if ((selektovaniIdAutomobila = nadjiSelektovaniIdAutomobila()) > -1 && cenaPoDanu > -1
                 && !proveriDaLiSuDatumiZauzeti())
            {
                lblCenaPoDanu.ForeColor = Color.Black;
                Ponuda ponuda = new Ponuda(selektovaniIdAutomobila, cenaPoDanu, dtpDatumOd.Value, dtpDatumDo.Value);
                if (File.Exists("ponude.pol"))
                {
                    ispisPonuda.Add(ponuda);
                    upisPonuda();
                    lbxPonude.Items.Add(ispisPonuda[ispisPonuda.Count - 1].ToString());
                    poredjajPonudePoDatumima();
                    MessageBox.Show("Ponuda uspešno dodata.");
                }
                else
                {
                    FileStream fs = File.Create("ponude.pol");
                    fs.Close();
                    ispisPonuda.Add(ponuda);
                    upisPonuda();
                    lbxPonude.Items.Add(ispisPonuda[ispisPonuda.Count - 1].ToString());
                    poredjajPonudePoDatumima();
                    MessageBox.Show("Ponuda uspešno dodata.");
                }
            }
            else if (cenaPoDanu == -1)
            {
                MessageBox.Show("Niste uneli cenu po danu!");
                lblCenaPoDanu.ForeColor = Color.Red;
                txtCenaPoDanu.Focus();
            }
        }

        private void btnIzbrisiPonudu_Click(object sender, EventArgs e)
        {
            int i;
            if ((i = nadjiSelektovanuPonudu()) > -1)
            {
                ispisPonuda.Remove(ispisPonuda[i]);
                if (ispisPonuda.Count > 0)
                {
                    upisPonuda();
                }
                lbxPonude.Items.Remove(lbxPonude.SelectedItem);
                if (lbxPonude.Items.Count > 0)
                {
                    lbxPonude.SelectedItem = lbxPonude.Items[0];
                }
                MessageBox.Show("Ponuda uspešno izbrisana.");
            }
        }

        private void poredjajPonudePoDatumima()
        { 
            string tempPonuda;
            for (int i = 0; i < lbxPonude.Items.Count - 1; i++)
            {
                for (int j = i + 1; j < lbxPonude.Items.Count; j++)
                {
                    if (procitajDatumOdIzListBoxa(lbxPonude.Items[i].ToString()) 
                        > procitajDatumOdIzListBoxa(lbxPonude.Items[j].ToString()))
                    {
                        tempPonuda = lbxPonude.Items[i].ToString();
                        lbxPonude.Items[i] = lbxPonude.Items[j];
                        lbxPonude.Items[j] = tempPonuda;
                    }
                }
            }
        }

        private DateTime procitajDatumOdIzListBoxa(string lbxPonudeItemS)
        {
            char[] lbxPonudeItemC = lbxPonudeItemS.ToCharArray();
            string datumOdS = "";
            DateTime datumOd;
            for (int i = 0; lbxPonudeItemC[i] != ' '; i++)
            {
                datumOdS += lbxPonudeItemC[i];
            }
            datumOd = DateTime.ParseExact(datumOdS, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return datumOd;
        }
        
        public int nadjiSelektovanuPonudu()
        {
            if (lbxPonude.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijednu ponudu!");
                return -1;
            }
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (ispisPonuda[i].ToString() == lbxPonude.SelectedItem.ToString())
                {
                    return i;
                }
            }
            return -1;
        }

        private bool proveriDaLiSuDatumiZauzeti()
        {
            if (!File.Exists("ponude.pol"))
            {
                return false;
            }
            int selektovaniIdAutomobila = nadjiSelektovaniIdAutomobila();
            bool zauzet = false;
            string zauzetiDatumi = "";
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (ispisPonuda[i].IdAutomobila == selektovaniIdAutomobila)
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
                zauzet = proveriDaliSuDatumiZauzetiURezervacijama();
            }
            return zauzet;
        }

        private bool proveriDaLiSuDatumiZauzeti(int index)
        {
            if (!File.Exists("ponude.pol"))
            {
                return false;
            }
            bool zauzet = false;
            string zauzetiDatumi = "";
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    if (ispisPonuda[i].IdAutomobila == ispisPonuda[index].IdAutomobila)
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
            }
            if (zauzet == true)
            {
                MessageBox.Show("Za ovaj automobil vec postoji ponuda za periode:" + zauzetiDatumi);
            }
            else
            {
                zauzet = proveriDaliSuDatumiZauzetiURezervacijama();
            }
            return zauzet;
        }

        public void upisPonuda()
        {
            if (File.Exists("ponude.pol"))
            {
                FileStream fs = File.OpenWrite("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                fs.Close();
            }
        }
        private double procitajCenuPoDanu()
        {
            double cenaPoDanu;
            if (txtCenaPoDanu.Text.Length > 0)
            {
                if (!double.TryParse(txtCenaPoDanu.Text, out cenaPoDanu))
                {
                    MessageBox.Show("Cena po danu nije upisana u ispravnom formatu!");
                    lblCenaPoDanu.ForeColor = Color.Red;
                    return -2;
                }
                else
                {
                    lblCenaPoDanu.ForeColor = Color.Black;
                    return cenaPoDanu;
                }
            }
            else
            {
                lblCenaPoDanu.ForeColor = Color.Black;
                return -1;
            }
        }
        public int nadjiSelektovaniIdAutomobila()
        {
            if (lbxAutomobili.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali nijedan automobil za ponudu!");
                return -1;
            }
            char[] selektovaniIdC;
            string selektovaniIdS = "";
            selektovaniIdC = lbxAutomobili.SelectedItem.ToString().ToCharArray();
            for (int i = 0; selektovaniIdC[i] != ':'; i++)
            {
                selektovaniIdS += selektovaniIdC[i];
            }
            return int.Parse(selektovaniIdS);
        }

        /*private void DodajPonudu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplikacija f = new Aplikacija();
            f.Show();
        }*/

        private bool proveriDaliSuDatumiZauzetiURezervacijama()
        {
            bool datumRezervisan = false;
            int selektovaniIdAutomobila = nadjiSelektovaniIdAutomobila();
            string rezervisaniDatumi = "";
            for (int i = 0; i < ispisRezervacija.Count; i++)
            {
                if (selektovaniIdAutomobila == ispisRezervacija[i].IdAutomobila)
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
                                Environment.NewLine +  "rezervisani su sledeci periodi:" + rezervisaniDatumi);
            }
            return datumRezervisan;
        }

        private void DodajPonudu_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }
    }
}
