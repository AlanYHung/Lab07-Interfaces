using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        private string name;
        public virtual string Name { get { return name; } set { name = "Animal"; } }
        private string personality;
        public virtual string Personality { get { return personality; } set { personality = "Wild"; } }
        public abstract string FoodSource { get; set; }
        public abstract string Size { get; set; }
        public abstract string Location { get; set; }
        public abstract bool IsEndangered { get; set; }
        public abstract decimal Weight { get; set; }

        public virtual string EatAndDrink()
        {
            return "It eats some food.";
        }
        public abstract void Sleep();

        public virtual string Sound()
        {
            return "It emits a sound.";
        }

    }
}
