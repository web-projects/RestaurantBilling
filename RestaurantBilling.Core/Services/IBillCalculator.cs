using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBilling.Core.Services
{
    public interface IBillCalculator
    {
        double TipAmount(double subTotal, int gratuity);
        double BillTotal(double subTotal, int gratuity);
    }
}
