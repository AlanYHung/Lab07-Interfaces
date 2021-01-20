using System;
using Xunit;
using Zoo;

namespace ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void Build_Lion()
        {
            Lion Cherry = new Lion();
            Cherry.Name = "Cherry";
            Assert.Equal("Cherry",Cherry.Name);
        }

        [Fact]
        public void Build_Orca_Whale()
        {
            Manatee Shamu = new Manatee();
            Shamu.TimeSubmerged = 90;
            Assert.Equal(90, Shamu.TimeSubmerged);

        }

        [Fact]
        public void Build_Parrot()
        {
            Parrot Polly = new Parrot();
            Polly.Sounds = true;
            Assert.True(Polly.Sounds);
        }

        [Fact]
        public void Build_Dodo()
        {
            Dodo Parsley = new Dodo();
            Parsley.IsEndangered = false;
            Assert.False(Parsley.IsEndangered);
        } 

        [Fact]
        public void Build_Komodo_Dragon()
        {
            Tortoise BruceLee = new Tortoise();
            BruceLee.Personality = "Cocky";
            Assert.Equal("Cocky", BruceLee.Personality);
        }

        [Fact]
        public void Build_Ball_Python()
        {
            BallPython Destiny = new BallPython();
            Destiny.IsPoisonous = false;
            Assert.False(Destiny.IsPoisonous);
        }

        [Fact]
        public void Build_Betta_Fish()
        {
            BettaFish Percival = new BettaFish();
            Percival.Color = "blue";
            Assert.Equal("blue", Percival.Color);
        }

        [Fact]
        public void Build_Sea_Bass()
        {
            SeaBass EmergencyFoodSupply = new SeaBass();
            EmergencyFoodSupply.FoodSource = "tasty meal";
            Assert.Equal("tasty meal", EmergencyFoodSupply.FoodSource);
        }
    }
}
