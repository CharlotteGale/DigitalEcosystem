// namespace Ecosystem.Tests;

// [TestFixture]
// public class BadgerTests
// {
//     [Test]
//     public void IncreaseHunger_WhenCalled_IncrementsHungerLevel()
//     {
//         Badger badger = new Badger("Brian", 0);
//         int initialHunger = badger.HungerLevel;

//         badger.IncreaseHunger();

//         Assert.That(badger.HungerLevel, Is.GreaterThan(initialHunger));
//     }

//     [Test]
//     public void ConsumeFood_WhenCalled_DecreasesHungerLevel()
//     {
//         Badger badger = new Badger("Brian", 3);
//         int initialHunger = badger.HungerLevel;

//         badger.ConsumeFood(2);

//         Assert.That(badger.HungerLevel, Is.LessThan(initialHunger));
//     }

//     [Test]
//     public void ConsumeFood_WhenCalled_DoesNothingWhenHungerLevelZero()
//     {
//         Badger badger = new Badger("Brian", 0);
//         int initialHunger = badger.HungerLevel;

//         badger.ConsumeFood(2);

//         Assert.That(initialHunger, Is.EqualTo(badger.HungerLevel));
//         Assert.That(initialHunger, Is.AtLeast(0));
//     }

//     [Test]
//     public void ConsumeFood_WhenHungerIsLow_DoesNotGoBelowZero()
//     {
//         Badger badger = new Badger("Brian", 1);
//         badger.ConsumeFood(4);

//         Assert.That(badger.HungerLevel, Is.EqualTo(0));
//     }
// }
