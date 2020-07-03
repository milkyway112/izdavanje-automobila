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
    public partial class AplikacijaZaKupca1 : Form
    {
        List<Rezervacija> ispisRezervacija;
        Kupac kupac;
        public AplikacijaZaKupca1(Kupac kupac)
        {
            this.kupac = kupac;
            InitializeComponent();
        }

        private void btnPrikaziRezervacije_Click(object sender, EventArgs e)
        {
            lbxRezervacije.Items.Clear();
            if (File.Exists("rezervacije.pol"))
            {
                FileStream fs = File.OpenRead("rezervacije.pol");
                BinaryFormatter bf = new BinaryFormatter();
                ispisRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                fs.Close();
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (ispisRezervacija[i].IdKupca == kupac.Id)
                    {
                        lbxRezervacije.Items.Add(ispisRezervacija[i].ToStringZaKupca());
                    }
                }
            }
        }

        private void btnObrisiRezevraciju_Click(object sender, EventArgs e)
        {
            if (lbxRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali nijednu rezervaciju za brisanje.");
            }
            else
            {
                for (int i = 0; i < ispisRezervacija.Count; i++)
                {
                    if (ispisRezervacija[i].ToStringZaKupca() == lbxRezervacije.SelectedItem.ToString())
                    {
                        dodajIUpisiPonudu(ispisRezervacija[i]);
                        ispisRezervacija.Remove(ispisRezervacija[i]);
                        lbxRezervacije.Items.Remove(lbxRezervacije.SelectedItem);
                        upisRezervacija();
                        if (lbxRezervacije.Items.Count > 0)
                        {
                            lbxRezervacije.SelectedItem = lbxRezervacije.Items[0];
                        }
                    }
                }
            }
        }

        private void btnNapraviNovuRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervisi rezervisi = new Rezervisi(kupac, this);
            this.Hide();
            rezervisi.Show();
        }

        private void upisRezervacija()
        {
            FileStream fs = File.OpenWrite("rezervacije.pol");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ispisRezervacija as List<Rezervacija>);
            fs.Close();
        }

        private void dodajIUpisiPonudu(Rezervacija rezervacija)
        {
            FileStream fs = File.OpenRead("ponude.pol");
            BinaryFormatter bf = new BinaryFormatter();
            List<Ponuda> ispisPonuda = bf.Deserialize(fs) as List<Ponuda>;
            fs.Close();
            if (!proveriDaLiSuDatumiZauzeti(ispisPonuda, rezervacija.DatumOd, rezervacija.DatumDo, rezervacija.IdAutomobila))
            {
                Ponuda p = new Ponuda(rezervacija.IdAutomobila,
                           rezervacija.Cena / ((rezervacija.DatumDo - rezervacija.DatumOd).Days + 1),
                           rezervacija.DatumOd, rezervacija.DatumDo);
                ispisPonuda.Add(p);
                fs = File.OpenWrite("ponude.pol");
                bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                fs.Close();
            }
        }

        private bool proveriDaLiSuDatumiZauzeti(List<Ponuda> ispisPonuda, DateTime datumOd, DateTime datumDo, int idAutomobila)
        {
            if (!File.Exists("ponude.pol"))
            {
                return false;
            }
            bool zauzet = false;
            for (int i = 0; i < ispisPonuda.Count; i++)
            {
                if (ispisPonuda[i].IdAutomobila == idAutomobila)
                {
                    if ((datumOd.Date >= ispisPonuda[i].DatumOd.Date && datumOd.Date <= ispisPonuda[i].DatumDo.Date)
                        || (datumDo.Date >= ispisPonuda[i].DatumOd.Date && datumDo.Date <= ispisPonuda[i].DatumDo.Date)
                        || datumOd.Date <= ispisPonuda[i].DatumOd.Date && datumDo.Date >= ispisPonuda[i].DatumDo.Date
                        || datumOd.Date == ispisPonuda[i].DatumOd.Date
                        || datumOd.Date == ispisPonuda[i].DatumDo.Date
                        || datumDo.Date == ispisPonuda[i].DatumDo.Date
                        || datumDo.Date == ispisPonuda[i].DatumOd.Date)
                    {
                        zauzet = true;
                    }
                }
            }
            return zauzet;
        }
    }
}
