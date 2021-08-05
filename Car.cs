using System;

namespace silverflow_rebase
{
    internal class Car
    {
        private int _fuel;

        public Car()
        {
        }

        internal void FillFuel(int fuel) => _fuel = fuel;

        internal bool IsReadyToRide => _fuel > 0;
    }
}