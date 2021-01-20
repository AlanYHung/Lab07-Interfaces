using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Saltwater : Fish
    {
        public abstract bool IsEdible { get; set; }
        public abstract bool CanGlow { get; set; }
        public abstract decimal Depth { get; set; }

        public abstract void Gather();
    }
}
