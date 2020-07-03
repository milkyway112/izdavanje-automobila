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
    public partial class Statistika : Form
    {
        Admin admin;
        AplikacijaZaAdmina aplikacija;
        List<Automobil> ispisAutomobila;
        List<Rezervacija> ispisRezervacija;
        DateTime mesec;
        float popunjenost;
        public Statistika(Admin admin, AplikacijaZaAdmina aplikacija)
        {
            this.aplikacija = aplikacija;
            this.admin = admin;
            InitializeComponent();
            ispisAutomobila = ispisiAutomobile();
            ispisRezervacija = ispisiRezervacije();
        }

        private void btnIzlistajAutomobile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ispisAutomobila.Count; i++)
            {
                lbxAutomobili.Items.Add(ispisAutomobila[i].ToStringZaKupca());
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

        private void Statistika_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cbxGodine.Items.Add(i.ToString());
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

        private void cbxMesec_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxGodine.SelectedItem != null)
            {
                mesec = DateTime.ParseExact("01/" + konvertujMesecUBroj() + "/" + cbxGodine.SelectedItem.ToString(), "dd/MM/yyyy",
                            System.Globalization.CultureInfo.InvariantCulture);
            }

        }

        private void cbxGodine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMesec.SelectedItem != null)
            {
                mesec = DateTime.ParseExact("01/" + konvertujMesecUBroj() + "/" + cbxGodine.SelectedItem.ToString(), "dd/MM/yyyy",
                            System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        private void Statistika_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        private void btnPrikaziStatistiku_Click(object sender, EventArgs e)
        {
            if (cbxMesec.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali mesec za koji želite da prikažete statistiku!");
            }
            else if (cbxGodine.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali u kojoj godini se nalazi mesec za koji želite da prikažete statistiku!");
            }
            else if (lbxAutomobili.SelectedItem == null)
            {
                MessageBox.Show("Niste selektovali automobil za koji želite da prikažete statistiku!");
            }
            else
            {
                popunjenost = vratiPopunjenost(nadjiRezervacije(nadjiSelektovaniIdAutomobila())) * 360F;
                this.Paint += crtanje;
                this.Invalidate();
            }
        }

        private void crtanje(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Blue, new Rectangle(130, 250, 150, 150));
            e.Graphics.FillPie(Brushes.Red, new Rectangle(130, 250, 150, 150), -90.0F, popunjenost);
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

        private List<Rezervacija> nadjiRezervacije(int idAutomobila)
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            for (int i = 0; i < ispisRezervacija.Count; i++)
            {
                if (ispisRezervacija[i].IdAutomobila == idAutomobila && 
                    (ispisRezervacija[i].DatumOd.Month == mesec.Month || 
                    ispisRezervacija[i].DatumDo.Month == mesec.Month))
                {
                    rezervacije.Add(ispisRezervacija[i]);
                }
            }
            return rezervacije;
        }

        private float vratiPopunjenost(List<Rezervacija> rezervacije)
        {
            float popunjenost = 0;
            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (rezervacije[i].DatumOd.Month < mesec.Month)
                {
                    rezervacije[i].DatumOd = mesec;
                }
                if (rezervacije[i].DatumDo.Month > mesec.Month)
                {
                    rezervacije[i].DatumDo = mesec.AddDays(DateTime.DaysInMonth(mesec.Year, mesec.Month) - 1);
                }
                popunjenost += (rezervacije[i].DatumDo - rezervacije[i].DatumOd).Days + 1;
            }
            popunjenost = popunjenost / DateTime.DaysInMonth(mesec.Year, mesec.Month);
            return popunjenost;
        }
    }
}
