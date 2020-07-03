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
    public partial class PravljenjeKorisnickogNaloga : Form
    {
        Logovanje logovanje;
        List<Kupac> ispisKupaca;
        public PravljenjeKorisnickogNaloga(Logovanje logovanje)
        {
            this.logovanje = logovanje;
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

        private void btnNapraviNalog_Click(object sender, EventArgs e)
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

        private void cbxMesec_SelectedValueChanged(object sender, EventArgs e)
        {
            namestiDane();
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

        private void PravljenjeKorisnickogNaloga_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                cbxGodine.Items.Add(i.ToString());
            }
            cbxDan.SelectedItem = cbxDan.Items[0];
            cbxMesec.SelectedItem = cbxMesec.Items[0];
            cbxGodine.SelectedItem = cbxGodine.Items[cbxGodine.Items.Count - 1];
        }

        private void cbxGodine_SelectedValueChanged(object sender, EventArgs e)
        {
            namestiDane();
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

        private void cbxMesec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGodine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDatumRodjenja_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefon_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblJmbg_Click(object sender, EventArgs e)
        {

        }

        private void lblPrezime_Click(object sender, EventArgs e)
        {

        }

        private void lblIme_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJmbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void PravljenjeKorisnickogNaloga_FormClosing(object sender, FormClosingEventArgs e)
        {
            logovanje.Show();
        }
    }
}
