using System;
using System.Collections.Generic;
using System.Linq;

namespace silverflow_rebase
{
    internal class CarRentalService
    {
        private List<Car> _cars = new List<Car>();

        internal void AddCarForRenting(Car car) => _cars.Add(car);

        internal void PrepareAllCarsForRenting() => _cars.ForEach(c => c.FillFuel(50));

        internal void RequestCarForCustomer(Person person)
        {
            Console.WriteLine($"Hello {person.Name}");

            if(_cars.Any() && person.Age >= 21 && _cars.First().IsReadyToRide)
                Console.WriteLine("We have car which will suit you fine");
                
            else
                Console.WriteLine("Sorry, we can't help you right now");
        }
    }
}