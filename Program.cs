using System;

namespace silverflow_rebase
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person(name: "Alice", age: 17);
            var bob = new Person(name: "Bob", age: 34);
            var car = new Car();
            var carRentalService = new CarRentalService();

            carRentalService.AddCarForRenting(car);
            carRentalService.PrepareAllCarsForRenting();
            carRentalService.RequestCarForCustomer(alice);
            carRentalService.RequestCarForCustomer(bob);
        }
    }
}
