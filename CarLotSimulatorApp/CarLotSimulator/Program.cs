using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car honda = new Car() { Year = 1998,
                Make = "Honda",
                Model = "Civic", 
                EngineNoise = "loud", 
                HonkNoise = "quiet", 
                IsDriveable = true };
            Console.WriteLine($"Make: {honda.Make}, Model: {honda.Model}, " +
                $"Year: {honda.Year}, Engine Noise Level: {honda.EngineNoise}," +
                $"Horn Noise Level: {honda.HonkNoise}, Runs and Drives: {honda.IsDriveable}");

            Car ford = new Car()
            {
                Year = 2021,
                Make = "Ford",
                Model = "F-150",
                EngineNoise = "loud",
                HonkNoise = "quiet",
                IsDriveable = false
            };
            Console.WriteLine($"Make: {ford.Make}, Model: {ford.Model}, " +
                $"Year: {ford.Year}, Engine Noise Level: {ford.EngineNoise}," +
                $"Horn Noise Level: {ford.HonkNoise}, Runs and Drives: {ford.IsDriveable}");

            Car toyota = new Car()
            {
                Year = 2022,
                Make = "Toyota",
                Model = "Highlander",
                EngineNoise = "quiet",
                HonkNoise = "loud",
                IsDriveable = true
            };
            Console.WriteLine($"Make: {toyota.Make}, Model: {toyota.Model}, " +
                $"Year: {toyota.Year}, Engine Noise Level: {toyota.EngineNoise}," +
                $"Horn Noise Level: {toyota.HonkNoise}, Runs and Drives: {toyota.IsDriveable}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
