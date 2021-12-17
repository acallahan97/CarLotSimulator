using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public static int NumberOfCars;
        public List<Car> CarList { get; set; } = new List<Car>();

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public static void Greet2()
        {
            Console.WriteLine("Hello again!");
        }
        
    }
}
