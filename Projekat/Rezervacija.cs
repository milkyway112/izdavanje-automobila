using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Projekat
{
    [Serializable]
    class Rezervacija
    {
        int idAutomobila;
        int idKupca;
        DateTime datumOd;
        DateTime datumDo;
        double cena;

        public Rezervacija()
        {
            idAutomobila = -1;
            idKupca = -1;
            datumOd = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            datumDo = DateTime.ParseExact("01/01/0001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cena = 0;
        }

        public Rezervacija(int idAutomobila, int idKupca, DateTime datumOd, DateTime datumDo, double cena)
        {
            this.idAutomobila = idAutomobila;
            this.idKupca = idKupca;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.cena = cena;
        }

        public int IdAutomobila { get { return idAutomobila; } set { idAutomobila = value; } }
        public int IdKupca { get { return idKupca; } set { idKupca = value; } }
        public DateTime DatumOd { get { return datumOd; } set { datumOd = value; } }
        public DateTime DatumDo { get { return datumDo; } set { datumDo = value; } }
        public double Cena { get { return cena; } set { cena = value; } }

        public override string ToString()
        {
            return "ID Kupca: " + idKupca + ", " + datumOd.ToString("dd/MM/yy")
                    + " - " + datumDo.ToString("dd/MM/yy");
        }

        public string ToStringZaKupca()
        {
            string automobil = "";
            FileStream fs = File.OpenRead("automobili.pol");
            BinaryFormatter bf = new BinaryFormatter();
            List<Automobil> ispisAutomobila = bf.Deserialize(fs) as List<Automobil>;
            for (int i = 0; i < ispisAutomobila.Count; i++)
            {
                if (ispisAutomobila[i].Id == idAutomobila)
                {
                    automobil += ispisAutomobila[i].ToStringZaKupca();
                }
            }
            fs.Close();
            return automobil + ": " + datumOd.ToString("dd/MM/yy")
                   + " - " + datumDo.ToString("dd/MM/yy");
        }
    }
}
