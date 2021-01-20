using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class LandMammal : Mammal
    {
        public abstract bool CanClimb { get; set; }
        public abstract int WalksOn { get; set; }
        public abstract decimal JumpHeight { get; set; }

        public abstract void Walk();
        public abstract void Run();
        public abstract void Play();

    }
}
