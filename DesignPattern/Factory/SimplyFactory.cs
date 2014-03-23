using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Members;
using Strategy.Strategies;

namespace Strategy.Factory
{
    public class SimplyFactory
    {
        public static Member Create(double cost)
        {
            Member member;
            if (cost > 10000)
            {
                member = new GoldenMember();
                member.AddStrategy(new Discount75());
                member.AddStrategy(new DiscountFesteval());
                member.AddStrategy(new DiscountAmount());
                return member;
            }
            if (cost > 2000)
            {
                member = new SilverMember();
                member.AddStrategy(new Discount80());
                member.AddStrategy(new DiscountFesteval());
                return member;
            } 
            member = new BronzeMember();
            member.AddStrategy(new Discount90());
            return member;
        }
    }
}
