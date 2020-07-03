using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Projekat
{
    public partial class Rezervisi : Form
    {
        List<Automobil> ispisAutomobila;
        List<Ponuda> ispisPonuda;
        List<Rezervacija> ispisRezervacija;
        int idAutomobila = -1;
        string[] parametar;
        ComboBox[] cbx;
        Kupac kupac;
        int idKupca = 0;
        AplikacijaZaKupca1 aplikacija;
        public Rezervisi(Kupac kupac, AplikacijaZaKupca1 aplikacija)
        {
            this.aplikacija = aplikacija;
            this.kupac = kupac;
            InitializeComponent();
            cbx = new ComboBox[9];
            if (File.Exists("automobili.pol"))
            {
                FileStream fs = File.OpenRead("automobili.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisAutomobila = bf.Deserialize(fs) as List<Automobil>;
                fs.Close();
            }
            else
            {
                ispisAutomobila = new List<Automobil>();
            }
            if (File.Exists("ponude.pol"))
            {
                FileStream fs = File.OpenRead("ponude.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisPonuda = bf.Deserialize(fs) as List<Ponuda>;
                fs.Close();
            }
            else
            {
                ispisPonuda = new List<Ponuda>();
            }
            if (File.Exists("rezervacije.pol"))
            {
                FileStream fs = File.OpenRead("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
            }
            else
            {
                ispisRezervacija = new List<Rezervacija>();
            }
        }

        private void Rezervisi_Load(object sender, EventArgs e)
        {
            parametar = new string[9];
            cbx[0] = cbxMarka;
            cbx[1] = cbxModel;
            cbx[2] = cbxGodiste;
            cbx[3] = cbxKubikaza;
            cbx[4] = cbxKaroserija;
            cbx[5] = cbxBrojVrata;
            cbx[6] = cbxGorivo;
            cbx[7] = cbxPogon;
            cbx[8] = cbxMenjac;
            for (int i = 0; i < cbx.Length; i++)
            {
                cbx[i].SelectedValueChanged += (sender2, e2) => cbxValue_Changed(sender2, e2, Array.IndexOf(cbx, sender2));
            }
            for (int i = 0; i < ispisAutomobila.Count; i++)
            {
                cbx[0].Items.Add(ispisAutomobila[i].Marka);
            }

        }

        void cbxValue_Changed(Object sender, EventArgs e, int index)
        {
            //int id;
            bool match;
            if (index < 8)
            {
                lbxPonude.Items.Clear();
                idAutomobila = -1;
                for (int i = index + 1; i < cbx.Length; i++)
                {
                    cbx[i].Items.Clear();
                    cbx[i].Text = "";
                }
                for (int i = 0; i < ispisAutomobila.Count; i++)
                {
                    match = true;
                    parametar[0] = ispisAutomobila[i].Marka;
                    parametar[1] = ispisAutomobila[i].Model;
                    parametar[2] = ispisAutomobila[i].Godiste.ToString();
                    parametar[3] = ispisAutomobila[i].Kubikaza.ToString();
                    parametar[4] = ispisAutomobila[i].Karoserija;
                    parametar[5] = ispisAutomobila[i].BrojVrata.ToString();
                    parametar[6] = ispisAutomobila[i].Gorivo;
                    parametar[7] = ispisAutomobila[i].Pogon;
                    parametar[8] = ispisAutomobila[i].Menjac;
                    //id = ispisAutomobila[i].Id;
                    for (int j = index; j >= 0; j--)
                    {
                        if (!(parametar[j] == cbx[j].SelectedItem.ToString()))
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match == true)
                    {
                        if (!paramDodat(cbx[index + 1], parametar[index + 1]))
                        {
                            cbx[index + 1].Items.Add(parametar[index + 1]);
                        }
                    }
                }
                if (cbx[index + 1].Items.Count == 1)
                {
                    cbx[index + 1].SelectedItem = cbx[index + 1].Items[0];
                }
            }
            else
            {
                idAutomobila = nadjiJedninstveniAutomobil();
            }
        }

        public int nadjiJedninstveniAutomobil()
        {
            bool match;
            for (int i = 0; i < ispisAutomobila.Count; i++)
            {
                match = true;
                parametar[0] = ispisAutomobila[i].Marka;
                parametar[1] = ispisAutomobila[i].Model;
                parametar[2] = ispisAutomobila[i].Godiste.ToString();
                parametar[3] = ispisAutomobila[i].Kubikaza.ToString();
                parametar[4] = ispisAutomobila[i].Karoserija;
                parametar[5] = ispisAutomobila[i].BrojVrata.ToString();
                parametar[6] = ispisAutomobila[i].Gorivo;
                parametar[7] = ispisAutomobila[i].Pogon;
                parametar[8] = ispisAutomobila[i].Menjac;
                for (int j = 0; j < cbx.Length; j++)
                {
                    if (!(cbx[j].SelectedItem.ToString() == parametar[j]))
                    {
                        match = false;
                        break;
                    }
                }
                if (match == true)
                {
                    return ispisAutomobila[i].Id;
                }
            }
            return -1;
        }

        private bool paramDodat(ComboBox cbx, string param)
        {
            foreach (var item in cbx.Items)
            {
                if (item.ToString() == param)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnPrikaziTermine_Click(object sender, EventArgs e)
        {
            napuniListBoxPonudama();
        }

        private void dtpDatumOd_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpDatumOd.Value > dtpDatumDo.Value)
            {
                dtpDatumDo.Value = dtpDatumOd.Value;
            }
        }

        private void dtpDatumDo_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpDatumDo.Value < dtpDatumOd.Value)
            {
                dtpDatumOd.Value = dtpDatumDo.Value;
            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            bool nadjenaPonuda = false;
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (idAutomobila == ispisPonuda[i].IdAutomobila &&
                    dtpDatumOd.Value.Date >= ispisPonuda[i].DatumOd.Date && dtpDatumDo.Value.Date <= ispisPonuda[i].DatumDo.Date)
                {
                    if (!proveriDaliSuDatumiZauzetiURezervacijama(idAutomobila))
                    {
                        int rasponDana = (dtpDatumDo.Value - dtpDatumOd.Value).Days + 1;
                        if (File.Exists("rezervacije.pol"))
                        {
                            Rezervacija r = new Rezervacija(idAutomobila, kupac.Id,
                                                            dtpDatumOd.Value, dtpDatumDo.Value,
                                                            rasponDana * ispisPonuda[i].CenaPoDanu);
                            ispisRezervacija.Add(r);
                        }
                        else
                        {
                            Rezervacija r = new Rezervacija(idAutomobila, kupac.Id, dtpDatumOd.Value, dtpDatumDo.Value,
                                                            rasponDana * ispisPonuda[i].CenaPoDanu);
                            ispisRezervacija.Add(r);

                        }
                        upisRezervacija();
                        nadjenaPonuda = true;
                        txtUkupnaCena.Text = (rasponDana * ispisPonuda[i].CenaPoDanu).ToString("0.00") + " rsd";
                        updateujPonude(i);
                        MessageBox.Show("Rezervacija uspešna.");
                    }
                }
            }
            if (!nadjenaPonuda)
            {
                MessageBox.Show("Nismo nasli ponudu za izabrani automobil u izabranom periodu.");
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

        private void updateujPonude(int index)
        {
            if (dtpDatumOd.Value.Date > ispisPonuda[index].DatumOd.Date &&
                dtpDatumDo.Value.Date < ispisPonuda[index].DatumDo.Date)
            {
                Ponuda p1 = new Ponuda(idAutomobila, ispisPonuda[index].CenaPoDanu, 
                                       ispisPonuda[index].DatumOd, dtpDatumOd.Value.AddDays(-1));
                Ponuda p2 = new Ponuda(idAutomobila, ispisPonuda[index].CenaPoDanu, 
                                       dtpDatumDo.Value.AddDays(1), ispisPonuda[index].DatumDo);
                ispisPonuda.Remove(ispisPonuda[index]);
                ispisPonuda.Add(p1);
                ispisPonuda.Add(p2);
                upisPonuda();
                napuniListBoxPonudama();
            }
            else if (dtpDatumOd.Value.Date == ispisPonuda[index].DatumOd.Date &&
                dtpDatumDo.Value.Date == ispisPonuda[index].DatumDo.Date)
            {
                ispisPonuda.Remove(ispisPonuda[index]);
                upisPonuda();
                napuniListBoxPonudama();
            }
            else if (dtpDatumOd.Value.Date == ispisPonuda[index].DatumOd.Date)
            {
                ispisPonuda[index].DatumOd = dtpDatumDo.Value.AddDays(1);
                upisPonuda();
                napuniListBoxPonudama();
            }
            else if (dtpDatumDo.Value.Date == ispisPonuda[index].DatumDo.Date)
            {
                ispisPonuda[index].DatumDo = dtpDatumOd.Value.AddDays(-1);
                upisPonuda();
                napuniListBoxPonudama();
            }
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

        private void napuniListBoxPonudama()
        {
            if (idAutomobila < 0)
            {
                MessageBox.Show("Niste izabrali zeljeni automobil." + Environment.NewLine +
                                "Molimo vas popunite sve stavke.");
            }
            else
            {
                lbxPonude.Items.Clear();
                for (int i = 0; i < ispisPonuda.Count; i++)
                {
                    if (ispisPonuda[i].IdAutomobila == idAutomobila)
                    {
                        lbxPonude.Items.Add(ispisPonuda[i].ToString());
                        poredjajPonudePoDatumima();
                    }
                }
            }
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

        private void Rezervisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        /*private void Rezervisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplikacija f = new Aplikacija();
            f.Show();
        }*/
    }
}
