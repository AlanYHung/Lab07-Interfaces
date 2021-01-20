using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Freshwater : Fish
    {
        public abstract string BodyOfWater { get; set; }
        public abstract bool IsBottomfeeder { get; set; }
        public abstract bool IsTasty { get; set; }

        public abstract void Afraid();
    }
}
