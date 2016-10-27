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
    class StratgeyInvoker
    {
        private ToReachOfficeStrategiesResolver _toReachOfficeResolver;

        

        public void DurationList()
        {
            Init();

            //For Bus
            var bus = _toReachOfficeResolver.Resolve(s => s.TravelBy == TravelBy.Bus);
            bus.Duration();
            //For Car
            var car = _toReachOfficeResolver.Resolve(s => s.TravelBy == TravelBy.Car);
            car.Duration();
            //For Taxi
            var taxi = _toReachOfficeResolver.Resolve(s => s.TravelBy == TravelBy.Taxi);
            taxi.Duration();
            //After few days busness want to add one more feature called bike
            //To implement that I have adde Bike class with implementation 
            //and add enum value for bik, no other changes.
            //Am I violating open close principle.

            //For Bike
            //var bike = toReachOfficeResolver.Resolve(s => s.TravelBy == TravelBy.Bike);
            //bike.Duration();

        }


        private void Init()
        {
            var strategies = new List<IToReachOffice>
                             {
                                 new ByBus(),
                                 new ByCar(),
                                 new ByTaxi(),
                                //new ByBike()
                             };

            _toReachOfficeResolver = new ToReachOfficeStrategiesResolver(strategies);
        }
    }
}
