using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lion : LandMammal, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public decimal ClawLength { get; set; }
        public bool IsSleeping { get; set; }
        public override bool CanClimb { get; set; }
        public override int WalksOn { get; set; }
        public override decimal JumpHeight { get; set; }
        public override bool HasFur { get; set; }
        public override bool HasHair { get; set; }
        public override bool HasChildren { get; set; }
        public override char Gender { get; set; }
        public override string Gestation { get; set; }
        public override string FoodSource { get; set; }
        public override string Size { get; set; }
        public override string Location { get; set; }
        public override bool IsEndangered { get; set; }
        public override decimal Weight { get; set; }
        public bool isObligate { get; set; }
        public bool isPack { get; set; }

        public Lion() { }

        public void Climb()
        {

        }
        public void Roar()
        {

        }

        public override void Walk()
        {
            
        }

        public override void Run()
        {
            
        }

        public override void Play()
        {
            
        }

        public override void Nurse()
        {
            Console.WriteLine("It takes a chomp out of a fresh zebra");
        }

        public override string EatAndDrink()
        {
            return base.EatAndDrink();
        }

        public override void Sleep()
        {
            
        }

        public override string Sound()
        {
            return "*soft purring*";
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
