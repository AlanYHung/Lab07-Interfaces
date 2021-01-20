using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Manatee : WaterMammal, Herbivore
    {
        public override string Name { get; set; }
        public override string Personality { get; set; }
        public string Type { get; set; }
        public override int TimeSubmerged { get; set; }
        public override bool LandCapable { get; set; }
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
        public bool isHerd { get; set; }

        public Manatee() { }

        public void Perform() { }
        public void Splash() { }

        public override void Swim()
        {
            
        }

        public override void Submerge()
        {
            
        }

        public override void Surface()
        {
            
        }

        public override void Nurse()
        {
            
        }

        public override string EatAndDrink()
        {
            return base.EatAndDrink();
        }

        public override void Sleep()
        {
            
        }

        public void FunFacts()
        {
            Console.WriteLine("'Fun Fact ALERT!' The loudspeaker croaks. 'Manatee's were often mistaken for mermaids by sailors on the high seas!'");
        }

        public void Forage()
        {
            
        }

        public void Avoid()
        {
            
        }
    }
}
