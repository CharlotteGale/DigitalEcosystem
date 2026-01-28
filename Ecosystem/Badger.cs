using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

public class Badger : Animal
{
    public Badger(string name, int hungerLevel) : base(name, hungerLevel){}

    internal string HungerLevelString()
    {
        return $"My hunger level is currently {this.HungerLevel}";
    }

    internal void Greets(Badger otherBadger)
    {
        Console.WriteLine($"Hello {otherBadger.Name}");
    }

    internal void Sees(Willow willow)
    {
        if(this.HungerLevel >= 5)
        {
            while(this.HungerLevel > 0 && willow.Leaves > 0)
            {
                willow.Eaten(1);
                ConsumeFood(1);
            }            
        }
    }

    internal string Status
    {
        get 
        {
            if(this.HungerLevel > 10)
            {
                return "Starving";
            }
            else
            {
                return "fine";
            }
        }
    }
}