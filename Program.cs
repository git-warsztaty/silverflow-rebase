using System;

namespace silverflow_rebase
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(name: "Alice", age: 18);
            Console.WriteLine($"Hello {person.Name}");

            var car = new Car();
            var carRentalService = new CarRentalService();

            carRentalService.AddCarForRenting(car);
        }
    }
}
