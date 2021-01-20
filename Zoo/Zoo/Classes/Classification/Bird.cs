using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Bird : Animal
    {
        public abstract string BeakShape { get; set; }
        public abstract bool CanSwim { get; set; }
        public abstract bool Sounds { get; set; }

        public abstract void Sing();
    }
}
