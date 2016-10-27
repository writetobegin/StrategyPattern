using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Enums;
using StrategyPattern.Interface.Strategies;
using StrategyPattern.Strategies.ToReachOffice;

namespace StrategyPattern
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var stratgeyInvoker = new StratgeyInvoker();

            stratgeyInvoker.DurationList();



        }

        
    }
}
