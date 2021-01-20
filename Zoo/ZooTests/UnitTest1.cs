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
        public void Build_Manatee()
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
        public void Build_Tortoise()
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

        [Fact]
        public void Test_BallPython_Interface()
        {
            BallPython test = new BallPython { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_BettaFish_Interface()
        {
            BettaFish test = new BettaFish { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Dodo_Interface()
        {
            Dodo test = new Dodo { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Lion_Interface()
        {
            Lion test = new Lion { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Manatee_Interface()
        {
            Manatee test = new Manatee { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Parrot_Interface()
        {
            Parrot test = new Parrot { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_SeaBass_Interface()
        {
            SeaBass test = new SeaBass { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Tortoise_Interface()
        {
            Tortoise test = new Tortoise { isObligate = true };
            Assert.True(test.isObligate);
        }

        [Fact]
        public void Test_Sounds_Method()
        {
            Lion cherry = new Lion();
            Assert.Equal("*soft purring*", cherry.Sound()) ;
        }

        [Fact]
        public void Test_EatAndDrink_Mehod()
        {
            string speak = "It crunches a cracker and spills crumbs all over your shirt. Clean yourself up, jeez.";
            Parrot carlos = new Parrot();
            Assert.Equal(speak, carlos.EatAndDrink());
        }

    }
}
