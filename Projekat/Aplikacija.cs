using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Aplikacija : Form
    {
        Kupac kupac;
        public Aplikacija()
        {
            InitializeComponent();
        }

        private void tlsDodavanjeIUklanjanjeAutomobila_Click(object sender, EventArgs e)
        {
        }

        private void ponudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DodajPonudu f = new DodajPonudu();
            f.Show();
            this.Hide();*/
        }

        /*private void rezervisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervisi f = new Rezervisi();
            f.Show();
            this.Hide();
        }*/
    }
}
