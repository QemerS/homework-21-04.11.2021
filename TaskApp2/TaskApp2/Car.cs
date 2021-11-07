using System;
using System.Collections.Generic;
using System.Text;

namespace TaskApp2
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The car is Driving");
        }
    }
}
