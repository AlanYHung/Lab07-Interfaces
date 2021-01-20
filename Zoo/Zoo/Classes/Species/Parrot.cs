using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Parrot : FlyingBird, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public bool CanSpeak { get; set; }
        public bool IsPirate { get; set; }
        public override string NestHabitat { get; set; }
        public override string Color { get; set; }
        public override decimal AvgFlyDist { get; set; }
        public override decimal AvgFlyHeight { get; set; }
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

        public Parrot() { }

        public void WantsCracker() { }
        public void Mimic() { }
        public void Curse() { }

        public override void Fly()
        {
            
        }

        public override void Land()
        {
            
        }

        public override void Sing()
        {
            
        }

        public override string EatAndDrink()
        {
            return "It crunches a cracker and spills crumbs all over your shirt. Clean yourself up, jeez.";
        }

        public override void Sleep()
        {
            
        }

        public override string Sound()
        {
            return "...SKWAWK...";
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
