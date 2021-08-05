using System;
using System.Collections.Generic;
using System.Linq;

namespace silverflow_rebase
{
    internal class CarRentalService
    {
        private List<Car> _cars = new List<Car>();
        private const int AGE_REQUIRED_TO_RENT_A_CAR = 21;

        internal void AddCarForRenting(Car car) => _cars.Add(car);

        internal void PrepareAllCarsForRenting() => _cars.ForEach(c => c.FillFuel(50));

        internal void RequestCarForCustomer(Person p)
        {
            Console.WriteLine($"Hello {p.Name}");

            if(_cars.Any() && p.Age >= AGE_REQUIRED_TO_RENT_A_CAR)
                Console.WriteLine("We have car which will suit you fine");
                
            else
                Console.WriteLine("Sorry, we can't help you right now");
        }
    }
}