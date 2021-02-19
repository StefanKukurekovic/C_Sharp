using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp2
{
    public class Car
    {
        public string Markenname { get; set; }
        public string Modelname { get; set; }
        public int Preis { get; set; }
        public int Baujahr { get; set; }
        public string Farbe { get; set; }
        public int Ps { get; set; }
        
        public Car(string markenname, string modelname, int preis, int baujahr, string farbe, int ps)
        {
            Markenname = markenname;
            Modelname = modelname;
            Preis = preis;
            Baujahr = baujahr;
            Farbe = farbe;
            Ps = ps;
        }



    }
}
