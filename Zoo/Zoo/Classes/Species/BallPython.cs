using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class BallPython : Legless, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public decimal Length { get; set; }
        public override bool IsPoisonous { get; set; }
        public override bool IsAggresive { get; set; }
        public override bool IsCold { get; set; }
        public override bool IsGrowing { get; set; }
        public override bool CanSwim { get; set; }
        public override string FoodSource { get; set; }
        public override string Size { get; set; }
        public override string Location { get; set; }
        public override bool IsEndangered { get; set; }
        public override decimal Weight { get; set; }
        public bool isObligate { get; set; }
        public bool isPack { get; set; }

        public BallPython() { }

        public void Bite() { }
        public void Squeeze() { }
        public void Swallow() { }

        public override void Slither()
        {
            
        }

        public override void Hiss()
        {
            
        }

        public override void SunBathe()
        {
            
        }

        public override void ShedSkin()
        {
            
        }

        public override string EatAndDrink()
        {
            return "The snake swallows a mouse- whole!";
        }

        public override void Sleep()
        {
            
        }

        public override string Sound()
        {
            return "*rustling leaves*";
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
