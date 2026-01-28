namespace Ecosystem.Tests;

[TestFixture(typeof(Badger))]
[TestFixture(typeof(Caterpillar))]
public class AnimalTests<TAnimal> where TAnimal : Animal, new()
{
    [Test]
    [TestCase]
    public void IncreaseHunger_WhenCalled_IncrementsHungerLevel()
    {
        TAnimal animal = new TAnimal();
        int initialHunger = animal.HungerLevel;

        animal.IncreaseHunger();

        Assert.That(animal.HungerLevel, Is.GreaterThan(initialHunger));
    }
}
