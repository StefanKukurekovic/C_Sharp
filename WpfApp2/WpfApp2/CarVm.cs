using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfApp2
{
    public class CarVm : ViewModelBase
    {
        public Car Auto { get; set; }
        private int verfuegbarkeit;
        public int Verfuegbarkeit
        {
            get { return verfuegbarkeit; }
            set { verfuegbarkeit = value; }
        }

        public CarVm(string markenname, string modelname, int preis, int baujahr, string farbe, int ps, int verfuegbarkeit)
        {
            Auto = new Car(markenname, modelname, preis, baujahr, farbe, ps);
            Verfuegbarkeit = verfuegbarkeit;
        }
    }
}
