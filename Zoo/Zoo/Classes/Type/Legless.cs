using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Legless : Reptile
    {
        public abstract bool IsPoisonous { get; set; }
        public abstract bool IsAggresive { get; set; }

        public abstract void Slither();
        public abstract void Hiss();
    }
}
