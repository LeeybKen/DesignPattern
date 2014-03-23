using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Strategies;

namespace Strategy.Members
{
    public class GoldenMember : Member
    {
        public GoldenMember()
            : base()
        {
            strategies = new List<IDiscountStrategy>();
            strategies.Add(new Discount75());
            strategies.Add(new DiscountFesteval());
            strategies.Add(new DiscountAmount());
        }
    }
}
