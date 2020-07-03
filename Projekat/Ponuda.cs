using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class Ponuda
    {
        int idAutomobila;
        double cenaPoDanu;
        DateTime datumOd;
        DateTime datumDo;

        public Ponuda()
        {
            idAutomobila = -1;
            cenaPoDanu = 0;
            datumOd = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture); ;
            datumDo = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture); ;
        }

        public Ponuda(int idAutomobila, double cenaPoDanu, DateTime datumOd, DateTime datumDo)
        {
            this.idAutomobila = idAutomobila;
            this.cenaPoDanu = cenaPoDanu;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
        }

        public int IdAutomobila { get { return idAutomobila; } set { idAutomobila = value;} }
        public double CenaPoDanu { get { return cenaPoDanu; } set { cenaPoDanu = value; } }
        public DateTime DatumOd { get { return datumOd; } set { datumOd = value; } }
        public DateTime DatumDo { get { return datumDo; } set { datumDo = value; } }
        
        public bool proveriDatum()
        {
            if (datumOd > datumDo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return datumOd.ToString("dd/MM/yyyy") + " - " + datumDo.ToString("dd/MM/yyyy") + ", " + cenaPoDanu.ToString("0.00") + " rsd";
        }
    }
}
