﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class DiscountFesteval : IDiscountStrategy
    {
        public double Discount(double price)
        {
            return price * 0.75;
        }
    }
}
