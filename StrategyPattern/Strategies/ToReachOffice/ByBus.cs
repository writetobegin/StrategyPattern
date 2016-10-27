using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Enums;
using StrategyPattern.Interface.Strategies;

namespace StrategyPattern.Strategies.ToReachOffice
{
    public class ByBus : IToReachOffice
    {
        public TravelBy TravelBy => TravelBy.Bus;
        public void Duration()
        {
            Console.WriteLine("By bus will take 1 and half hour ");
        }
    }
}
