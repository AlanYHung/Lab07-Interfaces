using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface Predator
    {
        public bool isObligate { get; set; }
        public bool isPack { get; set; }

        public abstract void Hunt();

        public abstract void Stalk();

        public abstract void Track();

        public abstract void Hide();
    }
}
