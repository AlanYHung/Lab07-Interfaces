using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Reptile : Animal
    {
        public abstract bool IsCold { get; set; }
        public abstract bool IsGrowing { get; set; }
        public abstract bool CanSwim { get; set; }

        public abstract void SunBathe();
        public abstract void ShedSkin();
    }
}
