using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    class WarSurchangeCalculator : TaxCalculator
    {
        public WarSurchangeCalculator(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }
        public override double CalculateTax()
        {
            tax = 0.5 * itemPrice;
            return tax + itemPrice;
        }
    }
}
