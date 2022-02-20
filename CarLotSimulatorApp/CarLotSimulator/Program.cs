using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new List<Car>();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var hyundai = new Car(); 
            hyundai.Year = 2013;
            hyundai.Make = "Hyundai";
            hyundai.Model = "Sonata";
            hyundai.EngineNoise = "whisper";
            hyundai.HonkNoise = "Beep";
            hyundai.IsDriveable = true;

            carLot.Add(hyundai);

            var chevy = new Car()
            {
                Year = 1989,
                Make = "Chevy",
                Model = "K1500",
                EngineNoise = "growl",
                HonkNoise = "honk",
                IsDriveable = false,
            };
            carLot.Add(chevy);

            var subaru = new Car(2003, "Subaru", "WRX", "rumble", "hella horn", true );
            carLot.Add(subaru);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            foreach (var vehicle in carLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }
    }
}
