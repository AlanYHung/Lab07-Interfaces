using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Mammal : Animal
    {
        public abstract bool HasFur { get; set; }
        public abstract bool HasHair { get; set; }
        public abstract bool HasChildren { get; set; }
        public abstract char Gender { get; set; }
        public abstract string Gestation { get; set; }

        public abstract void Nurse();
    }
}
