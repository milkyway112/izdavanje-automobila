using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    public class Kupac: Korisnik
    {

        string jmbg;
        DateTime datumRodjenja;
        string telefon;

        public Kupac() : base()
        {
            this.jmbg = "";
            datumRodjenja = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            this.telefon = "";
        }

        public Kupac(int id, string ime, string prezime, string username, string password, 
                     string jmbg, DateTime datumRodjenja, string telefon) : base(id, ime,prezime, username, password)
        {
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
        }

        public string Jmbg { get { return jmbg; } set { jmbg = value;} }
        public DateTime DatumRodjenja { get { return datumRodjenja; } set { datumRodjenja = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }

        public override string ToString()
        {
            return "ID: " + Id + ", " + Ime + " " + Prezime;
        }
    }
}
