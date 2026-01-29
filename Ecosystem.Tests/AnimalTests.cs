namespace Ecosystem.Tests;

[TestFixture(typeof(Badger))]
[TestFixture(typeof(Caterpillar))]
public class AnimalTests<TAnimal> where TAnimal : Animal, new()
{
    [Test]
    public void IncreaseHunger_WhenCalled_IncrementsHungerLevel()
    {
        TAnimal animal = new TAnimal();
        int initialHunger = animal.HungerLevel;

        animal.IncreaseHunger();

        Assert.That(animal.HungerLevel, Is.GreaterThan(initialHunger));
    }

    [Test]
    public void ConsumeFood_When_Called_DecreasesHungerLevel()
    {
        TAnimal animal = new TAnimal();
        int initialHunger = animal.HungerLevel;

        animal.IncreaseHunger();
        animal.IncreaseHunger();

        animal.ConsumeFood(1);

        Assert.That(animal.HungerLevel, Is.LessThan(initialHunger));
    }  

    [Test]
    public void ConsumeFood_WhenCalled_DoesNothingWhenHungerLevelZero()
    {
        TAnimal animal = new TAnimal();
        int initialHunger = animal.HungerLevel;

        animal.ConsumeFood(2);

        Assert.That(initialHunger, Is.EqualTo(animal.HungerLevel));
        Assert.That(initialHunger, Is.AtLeast(0));
    }

    [Test]
    public void ConsumeFood_WhenHungerIsLow_DoesNotGoBelowZero()
    {
        TAnimal animal = new TAnimal();
        int initialHunger = animal.HungerLevel;

        animal.IncreaseHunger();
        animal.IncreaseHunger();

        animal.ConsumeFood(4);

        Assert.That(animal.HungerLevel, Is.EqualTo(0));
    }
}
