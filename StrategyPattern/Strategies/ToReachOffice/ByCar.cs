using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Enums;
using StrategyPattern.Interface.Strategies;

namespace StrategyPattern.Strategies.ToReachOffice
{
    public class ByCar : IToReachOffice
    {
        public TravelBy TravelBy => TravelBy.Car;

        public void Duration()
        {
            Console.WriteLine("By car will take 40 minutes");
        }
    }
}
