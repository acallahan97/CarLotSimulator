﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();
            lot.Greet();
            CarLot.Greet2();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car honda = new Car()
            {
                Year = 1998,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "loud",
                HonkNoise = "quiet",
                IsDriveable = true
            };

            lot.CarList.Add(honda);

            Car ford = new Car()
            {
                Year = 2021,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "loud",
                HonkNoise = "quiet",
                IsDriveable = false
            };

            lot.CarList.Add(ford);
            Car toyota = new Car()
            {
                Year = 2022,
                Make = "Toyota",
                Model = "Highlander",
                EngineNoise = "quiet",
                HonkNoise = "loud",
                IsDriveable = true
            };

            lot.CarList.Add(toyota);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine();

            }

        }
    }
}
