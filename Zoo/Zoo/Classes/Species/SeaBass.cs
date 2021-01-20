using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class SeaBass : Saltwater, Predator
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public bool ForDisplay { get; set; }
        public decimal Length { get; set; }
        public override bool IsEdible { get; set; }
        public override bool CanGlow { get; set; }
        public override decimal Depth { get; set; }
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

        public SeaBass() { }

        public void Cook() { }
        public void EvadeCapture() { }

        public override void Gather()
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
