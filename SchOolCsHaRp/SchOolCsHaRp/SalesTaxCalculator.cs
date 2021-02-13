using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    class SalesTaxCalculator : TaxCalculator
    {
        public SalesTaxCalculator(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }

        public override double CalculateTax()
        {
            tax = 0.3 * itemPrice;
            return itemPrice + tax;
        }
    }
}
