using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interface.Resolver;
using StrategyPattern.Interface.Strategies;

namespace StrategyPattern.Strategies.ToReachOffice
{
    public class ToReachOfficeStrategiesResolver : IStrategyResolver<IToReachOffice>
    {
        public IEnumerable<IToReachOffice> Strategies { get; set; }

        public ToReachOfficeStrategiesResolver(IEnumerable<IToReachOffice> toReachOfficeStrategies)
        {
            Strategies = toReachOfficeStrategies;
        }


        public IToReachOffice Resolve(Func<IToReachOffice, bool> firstOrDefaultPredicate)
        {
            var strategy = Strategies.FirstOrDefault(firstOrDefaultPredicate);

            if (strategy == null)
            {
                throw new ArgumentException("Strategy not found.");
            }

            return strategy;
        }
    }
}
