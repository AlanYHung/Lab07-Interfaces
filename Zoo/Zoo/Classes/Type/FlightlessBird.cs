using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class FlightlessBird : Bird
    {
        public abstract bool IsExtinct { get; set; }
        public abstract decimal LandSpeed { get; set; }

        public abstract void Swim();
        public abstract void Run();
    }
}
