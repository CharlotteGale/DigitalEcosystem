public class Animal : ISpeak, IOrganism
{
    public string Name {get; set;}
    public int HungerLevel {get; set;}

    public List<Dictionary<string, string>> History {get; set;} = new List<Dictionary<string, string>>();

    public Animal(string name, int hungerLevel)
    {
        this.Name = name;
        this.HungerLevel = hungerLevel;
    }

    public string GetState()
    {
        return $"My name is {this.Name}! My hunger level is at {this.HungerLevel}.";
    }
    
    public void IncreaseHunger()
    {
        int oldHunger = this.HungerLevel;
        this.HungerLevel += 1;

        var eventEntry = new Dictionary<string, string>
        {
            { "Type", "Hunger Increased" },
            { "Description", $"Previously my hunger level was {oldHunger}, but now it's {this.HungerLevel}" }
        };

        this.History.Add(eventEntry);
    }

    public void ConsumeFood(int foodLevel)
    {
        int oldHunger = this.HungerLevel;

        if(this.HungerLevel - foodLevel < 0)
        {
            this.HungerLevel = 0;
        }
        else
        {
            this.HungerLevel -= foodLevel;
        }

        var eventEntry = new Dictionary<string, string>
        {
            { "Type", "Fed" },
            { "Description", $"Ate food with a value of {foodLevel}, and my hunger level went down from {oldHunger} to {this.HungerLevel}" }
        };
        
        this.History.Add(eventEntry);
    }

    public string Greet(Animal other)
    {
        return $"Hello there, {other}!";
    }

    public void Tick()
    {
        IncreaseHunger();
    }
    
    public void InteractWith(IOrganism other)
    {
        if(other is Animal animal)
        {
            this.Greet(animal);
            animal.Greet(this);
        } 
        else if(other is Plant plant)
        {
            this.ConsumeFood(plant.Eaten(this.HungerLevel));
        }
    }

    public string Speak()
    {
        return $"Hi! I am {this.Name}, nice to meet you!";
    }
}