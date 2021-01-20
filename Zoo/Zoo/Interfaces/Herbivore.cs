using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface Herbivore
    {
        public bool isObligate { get; set; }

        public bool isHerd { get; set; }

        public abstract void Forage();

        public abstract void Avoid();
    }
}
