namespace Ecosystem.Tests;

[TestFixture]
public class WillowTests
{
    [Test]
    public void IncreaseLeaves_WhenCalled_IncrementsLeaves()
    {
        Willow willow = new Willow(100);
        int initialLeaves = willow.Leaves;

        willow.Grow();
        Assert.That(willow.Leaves, Is.GreaterThan(initialLeaves));
    }

    [Test]
    public void Eaten_WhenCalled_DecreasesLeaves()
    {
        Willow willow = new Willow(100);
        int initialLeaves = willow.Leaves;

        willow.Eaten(2);

        Assert.That(willow.Leaves, Is.LessThan(initialLeaves));
        Assert.That(willow.Leaves, Is.EqualTo(98));
    }

    [Test]
    public void Eaten_WhenCalled_DoesNotGoBelowZero()
    {
        Willow willow = new Willow(0);
        int initialLeaves = willow.Leaves;

        willow.Eaten(2);

        Assert.That(initialLeaves, Is.EqualTo(willow.Leaves));
    }
}