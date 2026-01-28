public class Caterpillar : Animal  
{   
    public Caterpillar(string name, int hungerLevel) : base(name, hungerLevel){}

    internal string HungerLevelString()
    {
        return $"My hunger level is currently {this.HungerLevel}";
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