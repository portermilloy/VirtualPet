using PetApp;
using NUnit.Framework;

namespace PetApp.Tests
{
    public class Tests
    {
        private Pet pet;
        [SetUp]
        public void Setup()
        {
            pet = new Pet("TestPet");
        }


        // TESTING WHEN THE PET IS FED
        [Test]
        public void Feed_WhenNeutral_BecomesHappy()
        {
            pet.Feed();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Happy));
        }

        [Test]
        public void Feed_WhenHungry_BecomesNeutral()
        {
            pet.Tick();
            pet.Feed();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Neutral));
        }

        [Test]
        public void Feed_WhenSick_BecomesNeutral()
        {
            pet.Tick();
            pet.Tick();
            pet.Feed();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Neutral));
        }

        [Test]
        public void Feed_WhenHappy_StaysHappy()
        {
            pet.Feed();
            pet.Feed();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Happy));
        }

        // TESTING WHEN THE PET GETS PET
        [Test]
        public void Pet_WhenNeutral_BecomesHappy()
        {
            pet.PetAnimal();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Happy));
        }

        [Test]
        public void Pet_WhenHappy_StaysHappy()
        {
            pet.Feed();
            pet.PetAnimal();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Happy));
        }

        [Test]
        public void Pet_WhenHungry_StaysHungry()
        {
            pet.Tick();
            pet.PetAnimal();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Hungry));
        }

        [Test]
        public void Pet_WhenSick_StaysSick()
        {
            pet.Tick();
            pet.Tick();
            pet.PetAnimal();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Sick));
        }

        //TESTING THE TICKS
        [Test]
        public void Tick_IncrementsAgeMinutes()
        {
            pet.Tick();
            Assert.That(pet.AgeMinutes, Is.EqualTo(1));
        }

        [Test]
        public void Tick_WhenHappy_BecomesNeutral()
        {
            pet.Feed();
            pet.Tick();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Neutral));
        }

        [Test]
        public void Tick_WhenNeutral_BecomesHungry()
        {
            pet.Tick();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Hungry));
        }

        [Test]
        public void Tick_WhenHungry_BecomesSick()
        {
            pet.Tick();
            pet.Tick();
            Assert.That(pet.CurrentMood, Is.EqualTo(Mood.Sick));
        }

        [Test]
        public void Tick_At29_StaysBaby()
        {
            for (int i = 0; i < 29; i++)
            {
                pet.Feed();
                pet.Tick();
            }
            Assert.That(pet.CurrentStage, Is.EqualTo(Stage.Baby));
        }

        [Test]
        public void Tick_At30_BecomesTeen()
        {
            for (int i = 0; i < 30; i++)
            {
                pet.Feed();
                pet.Tick();
            }
            Assert.That(pet.CurrentStage, Is.EqualTo(Stage.Teen));
        }

        [Test]
        public void Tick_At60_BecomesAdult()
        {
            for (int i = 0; i < 60; i++)
            {
                pet.Feed();
                pet.Tick();
            }
            Assert.That(pet.CurrentStage, Is.EqualTo(Stage.Adult));
        }
    }
}
