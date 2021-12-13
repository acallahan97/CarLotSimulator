using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise()
        {
            if (IsDriveable = false)
            {
                return "quiet";
            }
            else
            {
                return "loud";
            }
        }
        public string MakeHonkNoise()
        {
            if (IsDriveable = true)
            {
                return "honk";
            }
            else
            {
                return "no honk";
            }
        }
    }
}
