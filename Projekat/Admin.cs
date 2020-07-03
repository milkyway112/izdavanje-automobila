using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    public class Admin : Korisnik
    {
        bool glavniAdmin;
        double plata;
        DateTime datumRodjenja;
        string telefon;

        public Admin() : base()
        {
            glavniAdmin = false;
        }

        public Admin(int id, string ime, string prezime, string username, string password, 
                     DateTime datumRodjenja, bool glavniAdmin, double plata, string telefon) 
                    : base (id, ime, prezime, username, password)
        {
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
            this.plata = plata;
            this.glavniAdmin = glavniAdmin;
        }

        public bool GlavniAdmin { get { return glavniAdmin; } set { glavniAdmin = value; } }
        public double Plata { get { return plata; } set { plata = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }

        public DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }

        public override string ToString()
        {
            return "ID: " + Id + ", " + Ime + " " + Prezime; 
        }
    }
}
