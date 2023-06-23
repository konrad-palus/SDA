using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.PriceCalculatorT3
{
    public class PriceCalculator
    {
        public decimal CalculatePrice(decimal price, int customerAge, DateTime lastTimeVisited)
        {
            if (customerAge < 4)
            {
                return 0;
            }
            else if (customerAge > 65)
            {
                return price * (decimal)0.7;
            }
            else if ((DateTime.Today - lastTimeVisited).TotalDays >= 200)
            {
                return price / 2;
            }
            else
            {
                return price;
            }
        }
    }
}
