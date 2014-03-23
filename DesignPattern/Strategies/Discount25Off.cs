using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class Discount25Off : IDiscountStrategy
    {
        public double Discount(double price)
        {
            return price * 0.25;
        }
    }
}
