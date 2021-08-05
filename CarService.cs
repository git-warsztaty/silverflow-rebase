using System;
using System.Collections.Generic;

namespace silverflow_rebase
{
    internal class CarRentalService
    {
        private List<Car> _cars = new List<Car>();

        public CarRentalService()
        {
        }

        internal void AddCarForRenting(Car car) => _cars.Add(car);
    }
}