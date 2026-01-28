namespace Ecosystem.Tests;

[TestFixture]
public class CaterpillarTests
{
    [Test]
    public void IncreaseHunger_WhenCalled_IncrementsHungerLevel()
    {
        Caterpillar caterpillar = new Caterpillar("Colin", 0);
        int initialHunger = caterpillar.HungerLevel;

        caterpillar.IncreaseHunger();

        Assert.That(caterpillar.HungerLevel, Is.GreaterThan(initialHunger));
    }

    [Test]
    public void ConsumeFood_WhenCalled_DecreasesHungerLevel()
    {
        Caterpillar caterpillar = new Caterpillar("Colin", 3);
        int initialHunger = caterpillar.HungerLevel;

        caterpillar.ConsumeFood(2);

        Assert.That(caterpillar.HungerLevel, Is.LessThan(initialHunger));
    }

    [Test]
    public void ConsumeFood_WhenCalled_DoesNothingWhenHungerLevelZero()
    {
        Caterpillar caterpillar = new Caterpillar("Colin", 0);
        int initialHunger = caterpillar.HungerLevel;

        caterpillar.ConsumeFood(2);

        Assert.That(initialHunger, Is.EqualTo(caterpillar.HungerLevel));
        Assert.That(initialHunger, Is.AtLeast(0));
    }

    [Test]
    public void ConsumeFood_WhenHungerIsLow_DoesNotGoBelowZero()
    {
        Caterpillar caterpillar = new Caterpillar("Colin", 1);
        caterpillar.ConsumeFood(4);

        Assert.That(caterpillar.HungerLevel, Is.EqualTo(0));
    }
}
