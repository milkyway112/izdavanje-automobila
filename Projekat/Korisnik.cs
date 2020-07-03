using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    public class Korisnik
    {
        string username;
        string password;
        int id;
        string ime;
        string prezime;

        public Korisnik(int id, string ime, string prezime, string username, string password)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.username = username;
            this.password = password;
        }
        public Korisnik()
        {
            this.id = -1;
            this.ime = "";
            this.prezime = "";
        }

        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public int Id { get { return id; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}


