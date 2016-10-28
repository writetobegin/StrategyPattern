using System;
using System.Collections.Generic;
using NUnit.Framework;
using StrategyPattern.Enums;
using StrategyPattern.Interface.Strategies;
using StrategyPattern.Strategies.ToReachOffice;

namespace UnitTestStrategyPattern
{
    [TestFixture]
    public class When_Resolving_Strategy
    {
        private ToReachOfficeStrategiesResolver _toReachOfficeStrategiesResolver;
        [TestFixtureSetUp]
        public void Setup()
        {
             
            var strategies = new List<IToReachOffice>
                             {
                                 new ByBus(),
                                 new ByCar(),
                                 new ByTaxi(),
                                //new ByBike()
                             };

            _toReachOfficeStrategiesResolver = new ToReachOfficeStrategiesResolver(strategies);
        }


        [TestCase(TravelBy.Bus, typeof(ByBus))]
        [TestCase(TravelBy.Car, typeof(ByCar))]
        [TestCase(TravelBy.Taxi, typeof(ByTaxi))]
        //[TestCase(TravelBy.Bike , typeof(ByBike))]
        public void Test(TravelBy travelBy, Type strategyType)
        {
            var strategy = _toReachOfficeStrategiesResolver.Resolve(s => s.TravelBy == travelBy );
            Assert.That(strategy.GetType(), Is.EqualTo(strategyType));
        }


    }
}
