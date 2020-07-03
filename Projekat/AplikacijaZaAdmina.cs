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
    public partial class AplikacijaZaAdmina : Form
    {
        Admin admin;
        public AplikacijaZaAdmina(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void btnAutomobili_Click(object sender, EventArgs e)
        {
            DodajIliUkloniAutomobil forma = new DodajIliUkloniAutomobil(admin, this);
            forma.Show();
            this.Hide();
        }

        private void AplikacijaZaAdmina_Load(object sender, EventArgs e)
        {
            if (!admin.GlavniAdmin)
            {
                btnAdmini.ForeColor = Color.Gray;
            }
        }

        private void btnAdmini_Click(object sender, EventArgs e)
        {
            if (admin.GlavniAdmin)
            {
                DodavanjeIUklanjanjeAdmina d = new DodavanjeIUklanjanjeAdmina(this, admin);
                this.Hide();
                d.Show();
            }
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            Kupci kupci = new Kupci(admin, this);
            kupci.Show();
            this.Hide();
        }

        private void btnPonude_Click(object sender, EventArgs e)
        {
            DodajPonudu forma = new DodajPonudu(admin, this);
            forma.Show();
            this.Hide();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            Rezervacije forma = new Rezervacije(admin, this);
            forma.Show();
            this.Hide();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            Statistika forma = new Statistika(admin, this);
            forma.Show();
            this.Hide();
        }
    }
}
