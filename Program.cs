using System;

namespace silverflow_rebase
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person(name: "Alice", age: 18);
            var car = new Car();
            var carRentalService = new CarRentalService();

            carRentalService.AddCarForRenting(car);
            carRentalService.PrepareAllCarsForRenting();
            carRentalService.RequestCarForCustomer(alice);
        }
    }
}
