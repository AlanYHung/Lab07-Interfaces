using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class FlyingBird : Bird
    {
        public abstract string NestHabitat { get; set; }
        public abstract string Color { get; set; }
        public abstract decimal AvgFlyDist { get; set; }
        public abstract decimal AvgFlyHeight { get; set; }

        public abstract void Fly();
        public abstract void Land();
    }
}
