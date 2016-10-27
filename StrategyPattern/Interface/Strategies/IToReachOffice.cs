using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Enums;

namespace StrategyPattern.Interface.Strategies
{
    interface IToReachOffice
    {
        TravelBy TravelBy { get; }
        void Duration();
    }
}
