using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Projekat
{
    [Serializable]
    class Automobil
    {
        static int idINC = 0;
        int id;
        int godiste;
        int kubikaza;
        int brojVrata;
        string marka;
        string gorivo;
        string model;
        string karoserija;
        string pogon;
        string menjac;

        public int IdINC { get { return idINC; } set { idINC = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int Godiste { get { return godiste; } set { godiste = value; } }
        public int Kubikaza { get { return kubikaza; } set { kubikaza = value; } }
        public int BrojVrata { get { return brojVrata; } set { brojVrata = value; } }
        public string Marka { get { return marka; } set { marka = value; } }
        public string Gorivo { get { return gorivo; } set { gorivo = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Karoserija { get { return karoserija; } set { karoserija = value; } }
        public string Pogon { get { return pogon; } set { pogon = value; } }
        public string Menjac { get { return menjac; } set { menjac = value; } }

        public Automobil()
        {
            id = -1;
            godiste = 0;
            kubikaza = 0;
            brojVrata = 0;
            marka = "";
            gorivo = "";
            model = "";
            karoserija = "";
            pogon = "";
            menjac = "";
        }
        public Automobil(int godiste, int kubikaza, int brojVrata, string marka, string gorivo, string model,
                              string karoserija, string pogon, string menjac)
        {
            this.id = idINC++;
            this.godiste = godiste;
            this.kubikaza = kubikaza;
            this.brojVrata = brojVrata;
            this.marka = marka;
            this.gorivo = gorivo;
            this.model = model;
            this.karoserija = karoserija;
            this.pogon = pogon;
            this.menjac = menjac;
        }

        public bool daLiJeMarka(string marka)
        {
            if (this.marka == marka)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return id + ": " + marka + ", " + model + ", " + godiste + ", " + kubikaza + ", " + karoserija
                   + ", " + brojVrata + ", " + gorivo + ", " + pogon + ", " + menjac;
        }

        public string ToStringZaKupca()
        {
            return "ID: " + id + ", " + marka + ", " + model + ", " + godiste;
        }
    }
}
















