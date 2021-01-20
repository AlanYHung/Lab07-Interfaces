using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Dodo : FlightlessBird, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public bool IsCloned { get; set; }
        public override bool IsExtinct { get; set; }
        public override decimal LandSpeed { get; set; }
        public override string BeakShape { get; set; }
        public override bool CanSwim { get; set; }
        public override bool Sounds { get; set; }
        public override string FoodSource { get; set; }
        public override string Size { get; set; }
        public override string Location { get; set; }
        public override bool IsEndangered { get; set; }
        public override decimal Weight { get; set; }
        public bool isObligate { get; set; }
        public bool isPack { get; set; }

        public Dodo() { }

        public void Scavenge() { }
        public void SwallowRock() { }
        public void ShowOff() { }

        public override void Swim()
        {
            
        }

        public override void Run()
        {
            
        }

        public override void Sing()
        {
            
        }

        public override string EatAndDrink()
        {
            return "It cracks open a nut and quickly chomps it";
        }

        public override void Sleep()
        {
            
        }

        public override string Sound()
        {
            return "Dodo.. Dodooooo";
        }

        public void Hunt()
        {
            
        }

        public void Stalk()
        {
            
        }

        public void Track()
        {
            
        }

        public void Hide()
        {
            
        }
    }
}
