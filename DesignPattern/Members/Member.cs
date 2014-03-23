using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Strategies;

namespace Strategy.Members
{
    public abstract class Member
    {
        #region Properties

        string name;
        bool gender;
        string address;
        string cellphone;

        #endregion

        protected List<IDiscountStrategy> strategies = new List<IDiscountStrategy>();

        public virtual double Discount(double price)
        {
            foreach (IDiscountStrategy strategy in strategies)
            {
                price = strategy.Discount(price);
            }
            return price;
        }

        public void AddStrategy(IDiscountStrategy str)
        {
            strategies.Add(str);
        }
    }
}
