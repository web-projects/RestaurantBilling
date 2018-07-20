using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBilling.Core.Services
{
    public class BillCalculator : IBillCalculator
    {
        public double TipAmount(double subTotal, int gratuity)
        {
            return subTotal * ((double)gratuity) / 100.0;
        }

        public double BillTotal(double subTotal, int gratuity)
        {
            return subTotal + TipAmount(subTotal, gratuity);
        }
    }
}
