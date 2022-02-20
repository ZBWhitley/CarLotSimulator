using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
        }

        public Car(int year, string make, string model, string en, string honk, bool driveable )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = en;
            HonkNoise = honk;
            IsDriveable = driveable;

        }
                

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise() 
        {
            return EngineNoise;
        }
        public string MakeHonkNoise() 
        {
            return HonkNoise;
        }
        


    }
}
