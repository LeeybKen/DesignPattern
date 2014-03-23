using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Members;
using Strategy.Strategies;
using Strategy.Factory;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region new a instance
            GoldenMember goldenMember = new GoldenMember();
            Console.WriteLine(goldenMember.Discount(5000));

            SilverMember silverMember = new SilverMember();
            Console.WriteLine(silverMember.Discount(1000));
            #endregion

            #region Simple Factory

            Member member = SimplyFactory.Create(5000);
            member.Discount(600);

            #endregion
        }
    }
}
