using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    abstract class TaxCalculator
    {
        protected double itemPrice;
        protected double tax;

        public abstract double CalculateTax();

        public double Tax { get { return tax; } }
        public double ItemPrice { get { return itemPrice; } }
    }

}
