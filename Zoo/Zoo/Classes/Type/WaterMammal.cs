using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class WaterMammal : Mammal
    {
        public abstract int TimeSubmerged { get; set; }
        public abstract bool LandCapable { get; set; }

        public abstract void Swim();
        public abstract void Submerge();
        public abstract void Surface();
    }
}
