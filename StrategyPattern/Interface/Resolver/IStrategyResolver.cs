using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface.Resolver
{
    public interface IStrategyResolver<T>
    {
        IEnumerable<T> Strategies { get; set; }

        T Resolve(Func<T, bool> firstOrDefaultPredicate);
    }
}
