using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class HasLegs : Reptile
    {
        public abstract bool IsCamoflauged { get; set; }
        public abstract int NumOfHorns { get; set; }

        public abstract void Skitter();
        public abstract void Bite();
    }
}
