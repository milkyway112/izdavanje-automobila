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
    public partial class DodajIliUkloniAutomobil : Form
    {
        int brojJoker;
        bool popunjeno = true;
        Admin admin;
        AplikacijaZaAdmina aplikacija;
        public DodajIliUkloniAutomobil(Admin admin, AplikacijaZaAdmina aplikacija)
        {
            this.admin = admin;
            this.aplikacija = aplikacija;
            InitializeComponent();
            //gbxDodavanjeAutomobil.Left = (this.MdiParent.ClientRectangle.Width - gbxDodavanjeAutomobil.ClientRectangle.Width) / 2;
        }

        private bool proveraUnosa(TextBox textBox)
        {
            if (textBox.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool proveraBroja(TextBox textBox)
        {
            if (int.TryParse(txtKubikaza.Text, out brojJoker) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void obojiLabeluUCrveno(Label labela)
        {
            labela.ForeColor = Color.Red;
            popunjeno = false;
        }

        private void obojiLabeluUCrno(Label labela)
        {
            labela.ForeColor = Color.Black;
        }

        private void btnIzlistajAutomobila_Click(object sender, EventArgs e)
        {
            lbxAutomobili.DataSource = null;
            lbxAutomobili.Items.Clear();
            FileStream fs = File.OpenRead("automobili.pol");
            BinaryFormatter bf = new BinaryFormatter();
            List<Automobil> ispis = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            lbxAutomobili.DataSource = ispis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] selektovaniIdC;
            string selektovaniIdS = "";
            int selektovaniId;
            string rezervacije = "";
            bool autoRezervisan = false;
            FileStream fs = File.OpenRead("automobili.pol");
            BinaryFormatter bf = new BinaryFormatter();
            List<Automobil> upis = bf.Deserialize(fs) as List<Automobil>;
            fs.Close();
            if (lbxAutomobili.SelectedItem != null)
            {
                selektovaniIdC = lbxAutomobili.SelectedItem.ToString().ToCharArray();
                for (int i = 0; selektovaniIdC[i] != ':'; i++)
                {
                    selektovaniIdS += selektovaniIdC[i];
                }
                selektovaniId = int.Parse(selektovaniIdS);
                if (File.Exists("rezervacije.pol"))
                {
                    fs = File.OpenRead("rezervacije.pol");
                    bf = new BinaryFormatter();
                    List<Rezervacija> ispisRezervacija = bf.Deserialize(fs) as List<Rezervacija>;
                    fs.Close();
                    for (int i = 0; i < ispisRezervacija.Count; i++)
                    {
                        if (ispisRezervacija[i].IdAutomobila == selektovaniId)
                        {
                            rezervacije += Environment.NewLine + ispisRezervacija[i].ToString();
                            autoRezervisan = true;
                        }
                    }
                    if (autoRezervisan)
                    {
                        if (MessageBox.Show("Za ovaj automobil postoje sledece rezervacije:" + rezervacije, 
                                        "Da li ste sigurni da želite da obrišete ovaj automobil?", MessageBoxButtons.OKCancel) 
                                        == DialogResult.OK)
                        {
                            for (int i = 0; i < upis.Count; i++)
                            {
                                if (upis[i].Id == selektovaniId)
                                {
                                    upis.Remove(upis[i]);
                                }
                            }
                            for (int i = 0; i < ispisRezervacija.Count; i++)
                            {
                                if (ispisRezervacija[i].IdAutomobila == selektovaniId)
                                {
                                    ispisRezervacija.Remove(ispisRezervacija[i]);
                                }
                            }
                            fs = File.OpenRead("ponude.pol");
                            List<Ponuda> ispisPonuda = bf.Deserialize(fs) as List<Ponuda>;
                            fs.Close();
                            for (int i = 0; i < ispisPonuda.Count; i++)
                            {
                                if (ispisPonuda[i].IdAutomobila == selektovaniId)
                                {
                                    ispisPonuda.Remove(ispisPonuda[i]);
                                }
                            }
                            fs = File.OpenWrite("ponude.pol");
                            bf.Serialize(fs, ispisPonuda as List<Ponuda>);
                            fs.Close();
                            fs = File.OpenWrite("rezervacije.pol");
                            bf.Serialize(fs, ispisRezervacija as List<Rezervacija>);
                            fs.Close();
                            fs = File.OpenWrite("automobili.pol");
                            bf.Serialize(fs, upis as List<Automobil>);
                            lbxAutomobili.DataSource = upis;
                            fs.Close();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < upis.Count; i++)
                        {
                            if (upis[i].Id == selektovaniId)
                            {
                                upis.Remove(upis[i]);
                            }
                        }
                        fs = File.OpenWrite("automobili.pol");
                        bf.Serialize(fs, upis as List<Automobil>);
                        lbxAutomobili.DataSource = upis;
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste selektovan nijedan automobil za brisanje!");
            }
        }

        private void btnDodajAutomobil_Click_1(object sender, EventArgs e)
        {
            popunjeno = true;
            if (proveraUnosa(txtMarka))
            {
                obojiLabeluUCrveno(lblMarka);
            }
            else
            {
                obojiLabeluUCrno(lblMarka);
            }
            if (proveraUnosa(txtKubikaza) || proveraBroja(txtKubikaza))
            {
                obojiLabeluUCrveno(lblKubikaza);
            }
            else
            {
                obojiLabeluUCrno(lblKubikaza);
            }
            if (proveraUnosa(txtGorivo))
            {
                obojiLabeluUCrveno(lblGorivo);
            }
            else
            {
                obojiLabeluUCrno(lblGorivo);
            }
            if (proveraUnosa(txtModel))
            {
                obojiLabeluUCrveno(lblModel);
            }
            else
            {
                obojiLabeluUCrno(lblModel);
            }
            if (proveraUnosa(txtKaroserija))
            {
                obojiLabeluUCrveno(lblKaroserija);
            }
            else
            {
                obojiLabeluUCrno(lblKaroserija);
            }
            if (proveraUnosa(txtPogon))
            {
                obojiLabeluUCrveno(lblPogon);
            }
            else
            {
                obojiLabeluUCrno(lblPogon);
            }
            if (proveraUnosa(txtGodiste) || proveraBroja(txtGodiste))
            {
                obojiLabeluUCrveno(lblGodiste);
            }
            else
            {
                obojiLabeluUCrno(lblGodiste);
            }
            if (proveraUnosa(txtBrojVrata) || proveraBroja(txtBrojVrata))
            {
                obojiLabeluUCrveno(lblBrojVrata);
            }
            else
            {
                obojiLabeluUCrno(lblBrojVrata);
            }
            if (proveraUnosa(txtMenjac))
            {
                obojiLabeluUCrveno(lblMenjac);
            }
            else
            {
                obojiLabeluUCrno(lblMenjac);
            }
            if (popunjeno == true)
            {
                Automobil automobil = new Automobil(int.Parse(txtGodiste.Text), int.Parse(txtKubikaza.Text),
                                                    int.Parse(txtBrojVrata.Text), txtMarka.Text, txtGorivo.Text,
                                                    txtModel.Text, txtKaroserija.Text, txtPogon.Text, txtMenjac.Text);
                if (File.Exists("automobili.pol"))
                {
                    FileStream fs = File.OpenRead("automobili.pol");
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Automobil> upis = bf.Deserialize(fs) as List<Automobil>;
                    fs.Close();
                    automobil.Id = upis[upis.Count - 1].Id + 1;
                    upis.Add(automobil);
                    fs = File.OpenWrite("automobili.pol");
                    bf.Serialize(fs, upis as List<Automobil>);
                    fs.Close();
                    upis.Clear();
                }
                else
                {
                    FileStream fs = File.Create("automobili.pol");
                    fs.Close();
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Automobil> upis = new List<Automobil>();
                    automobil.Id = 0;
                    upis.Add(automobil);
                    fs = File.OpenWrite("automobili.pol");
                    bf.Serialize(fs, upis as List<Automobil>);
                    fs.Close();
                    upis.Clear();
                }
            }
        }

        private void DodajIliUkloniAutomobil_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplikacija.Show();
        }

        /*private void DodajIliUkloniAutomobil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplikacija f = new Aplikacija();
            f.Show();
        }*/
    }
}
