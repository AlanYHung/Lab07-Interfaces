using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Tortoise : HasLegs, Herbivore
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public string Diet { get; set; }
        public override bool IsCamoflauged { get; set; }
        public override int NumOfHorns { get; set; }
        public override bool IsCold { get; set; }
        public override bool IsGrowing { get; set; }
        public override bool CanSwim { get; set; }
        public override string FoodSource { get; set; }
        public override string Size { get; set; }
        public override string Location { get; set; }
        public override bool IsEndangered { get; set; }
        public override decimal Weight { get; set; }
        public bool isObligate { get; set; }
        public bool isHerd { get; set; }

        public Tortoise() { }

        public void Lounge() { }
        public void Hide() {
            Console.WriteLine("It disappears into it's shell. Bye!");
        }
        public void Swim() { }

        public override void Skitter()
        {
            
        }

        public override void Bite()
        {
            
        }

        public override void SunBathe()
        {
            
        }

        public override void ShedSkin()
        {
            
        }

        public override void EatAndDrink()
        {
            Console.WriteLine("It monches slowly and contently on a hibiscus flower");
        }

        public override void Sleep()
        {
            
        }


        public void Forage()
        {
            
        }

        public void Avoid()
        {
            
        }
    }
}
