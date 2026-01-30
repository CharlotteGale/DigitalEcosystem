namespace Ecosystem.Tests;

[TestFixture(typeof(Badger))]
[TestFixture(typeof(Caterpillar))]
public class AnimalTests
{
    private readonly Type _animalType;
    private Animal _animal;

    public AnimalTests(Type animalType)
    {
        _animalType = animalType;
    }
    
    [SetUp]
    public void SetUp()
    {
        _animal = (Animal)Activator.CreateInstance(_animalType, "test animal", 0)!;
    }

    [Test]
    public void IncreaseHunger_WhenCalled_IncrementsHungerLevel()
    {
        int initialHunger = _animal.HungerLevel;

        _animal.IncreaseHunger();

        Assert.That(_animal.HungerLevel, Is.GreaterThan(initialHunger));
    }

    [Test]
    public void ConsumeFood_When_Called_DecreasesHungerLevel()
    {
        _animal.IncreaseHunger();
        _animal.IncreaseHunger();

        int initialHunger = _animal.HungerLevel;


        _animal.ConsumeFood(1);

        Assert.That(_animal.HungerLevel, Is.LessThan(initialHunger));
    }  

    [Test]
    public void ConsumeFood_WhenCalled_DoesNothingWhenHungerLevelZero()
    {
        int initialHunger = _animal.HungerLevel;

        _animal.ConsumeFood(2);

        Assert.That(initialHunger, Is.EqualTo(_animal.HungerLevel));
        Assert.That(initialHunger, Is.AtLeast(0));
    }

    [Test]
    public void ConsumeFood_WhenHungerIsLow_DoesNotGoBelowZero()
    {
        _animal.IncreaseHunger();
        _animal.IncreaseHunger();

        _animal.ConsumeFood(4);

        Assert.That(_animal.HungerLevel, Is.EqualTo(0));
    }
}
