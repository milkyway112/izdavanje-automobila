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
    public partial class Logovanje : Form
    {
        public Logovanje()
        {
            InitializeComponent();
        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            bool popunjeno = true;
            if (rbtnKupac.Checked)
            {
                if (txtUsername.Text.Length == 0)
                {
                    lblUsername.ForeColor = Color.Red;
                    popunjeno = false;
                }
                else
                {
                    lblUsername.ForeColor = Color.Black;
                }
                if (txtPassword.Text.Length == 0)
                {
                    lblPassword.ForeColor = Color.Red;
                    popunjeno = false;
                }
                else
                {
                    lblPassword.ForeColor = Color.Black;
                }
                if (!popunjeno)
                {
                    MessageBox.Show("Niste uneli sve podatke.");
                }
                else
                {
                    if (!File.Exists("kupci.pol"))
                    {
                        MessageBox.Show("Nalog ne postoji!");
                    }
                    else
                    {
                        bool nadjenUsername = false;
                        bool tacanPassword = false;
                        FileStream fs = File.OpenRead("kupci.pol");
                        BinaryFormatter bf = new BinaryFormatter();
                        List<Kupac> ispisKupaca = bf.Deserialize(fs) as List<Kupac>;
                        fs.Close();
                        for (int i = 0; i < ispisKupaca.Count; i++)
                        {
                            if (txtUsername.Text == ispisKupaca[i].Username)
                            {
                                nadjenUsername = true;
                            }
                            if (txtPassword.Text == ispisKupaca[i].Password)
                            {
                                tacanPassword = true;
                            }
                            if (nadjenUsername && tacanPassword)
                            {
                                MessageBox.Show("Dobrodošli, " + ispisKupaca[i].Ime + "!");
                                this.Hide();
                                var aplikacija = new AplikacijaZaKupca1(ispisKupaca[i]);
                                aplikacija.Closed += (s, args) => this.Close();
                                aplikacija.Show();
                                break;
                            }
                        }
                        if (!nadjenUsername)
                        {
                            MessageBox.Show("Nalog nije pronadjen!");
                            lblUsername.ForeColor = Color.Red;
                        }
                        if (nadjenUsername && !tacanPassword)
                        {
                            MessageBox.Show("Netačan password!");
                            lblPassword.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                if (txtUsername.Text.Length == 0)
                {
                    lblUsername.ForeColor = Color.Red;
                    popunjeno = false;
                }
                else
                {
                    lblUsername.ForeColor = Color.Black;
                }
                if (txtPassword.Text.Length == 0)
                {
                    lblPassword.ForeColor = Color.Red;
                    popunjeno = false;
                }
                else
                {
                    lblPassword.ForeColor = Color.Black;
                }
                if (!popunjeno)
                {
                    MessageBox.Show("Niste uneli sve podatke.");
                }
                else
                {
                    if (!File.Exists("admini.pol"))
                    {
                        MessageBox.Show("Nalog ne postoji!");
                    }
                    else
                    {
                        bool nadjenUsername = false;
                        bool tacanPassword = false;
                        FileStream fs = File.OpenRead("admini.pol");
                        BinaryFormatter bf = new BinaryFormatter();
                        List<Admin> ispisAdmina = bf.Deserialize(fs) as List<Admin>;
                        fs.Close();
                        for (int i = 0; i < ispisAdmina.Count; i++)
                        {
                            if (txtUsername.Text == ispisAdmina[i].Username)
                            {
                                nadjenUsername = true;
                            }
                            if (txtPassword.Text == ispisAdmina[i].Password)
                            {
                                tacanPassword = true;
                            }
                            if (nadjenUsername && tacanPassword)
                            {
                                MessageBox.Show("Dobrodošli, " + ispisAdmina[i].Ime + "!");
                                this.Hide();
                                var aplikacija = new AplikacijaZaAdmina(ispisAdmina[i]);
                                aplikacija.Closed += (s, args) => this.Close();
                                aplikacija.Show();
                                break;

                            }
                        }
                        if (!nadjenUsername)
                        {
                            MessageBox.Show("Nalog nije pronadjen!");
                            lblUsername.ForeColor = Color.Red;
                        }
                        if (nadjenUsername && !tacanPassword)
                        {
                            MessageBox.Show("Netačan password!");
                            lblPassword.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void lblNapraviteGa_Click(object sender, EventArgs e)
        {
            PravljenjeKorisnickogNaloga p = new PravljenjeKorisnickogNaloga(this);
            this.Hide();
            p.Show();
        }
    }
}
