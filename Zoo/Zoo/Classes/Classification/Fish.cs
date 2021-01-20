using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Fish : Animal
    {
        public abstract string Habitat { get; set; }
        public abstract string Color { get; set; }
        public abstract bool TeethVisible { get; set; }
        public abstract bool HasEyes { get; set; }
        public abstract int NumOfFins { get; set; }

        public abstract void Swim();
        public abstract void Jump();
    }
}
