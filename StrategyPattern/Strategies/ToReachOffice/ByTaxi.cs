using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Enums;
using StrategyPattern.Interface.Strategies;

namespace StrategyPattern.Strategies.ToReachOffice
{
    public class ByTaxi :IToReachOffice
    {
        public TravelBy TravelBy => TravelBy.Taxi;
        public void Duration()
        {
            Console.WriteLine("By taxi will take 1 hour");
        }
    }
}
