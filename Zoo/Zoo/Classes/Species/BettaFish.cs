using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class BettaFish : Freshwater, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public string FinType { get; set; }
        public char Gender { get; set; }
        public override string BodyOfWater { get; set; }
        public override bool IsBottomfeeder { get; set; }
        public override bool IsTasty { get; set; }
        public override string Habitat { get; set; }
        public override string Color { get; set; }
        public override bool TeethVisible { get; set; }
        public override bool HasEyes { get; set; }
        public override int NumOfFins { get; set; }
        public override string FoodSource { get; set; }
        public override string Size { get; set; }
        public override string Location { get; set; }
        public override bool IsEndangered { get; set; }
        public override decimal Weight { get; set; }
        public bool isObligate { get; set; }
        public bool isPack { get; set; }

        public BettaFish() { }

        public void BuildNest() { }
        public void MortalCombat() { }

        public override void Afraid()
        {
            
        }

        public override void Swim()
        {
            
        }

        public override void Jump()
        {
            
        }

        public override string EatAndDrink()
        {
            return base.EatAndDrink();
        }

        public override void Sleep()
        {
            
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
