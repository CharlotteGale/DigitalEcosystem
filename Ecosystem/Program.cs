namespace CSharp.DigitalEcosystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Main method");

        Badger brian = new Badger("Brian", 5);
        Badger bernie = new Badger("Bernie", 1);
        Caterpillar colin = new Caterpillar("Colin", 9);
        Caterpillar charlie = new Caterpillar("Charlie", 6);
        Willow william = new Willow(100);
        Willow wayne = new Willow(1000);

        World.Add(brian);
        World.Add(bernie);
        World.Add(colin);
        World.Add(charlie);
        World.Add(william);
        World.Add(wayne);

        // RunSimulation();
        DisplayWorld();

    }

    static List<IOrganism> World = new List<IOrganism>();

    static List<IOrganism> ShuffleWorld()
    {
        return World.OrderBy( x => Random.Shared.NextInt64() ).ToList( );
    }

        static void DisplayWorld()
    {
        Console.Clear();
        foreach(IOrganism organism in World)
        {
            Console.WriteLine(organism.GetState());
        }
    }


    static void Introduction()
    {
        Console.WriteLine("This is an introductory paragraph about my Ecosystem!");
    }

    static void RunSimulation()
    {
        // Introduction();
        
        while (true)
        {
            foreach(IOrganism organism in World)
            {
                organism.Tick();
            }

            List<IOrganism> shuffledWorld = ShuffleWorld();

            for (int i = 0; i < shuffledWorld.Count - 1; i++)
            {

                var left = shuffledWorld[i];
                var right = shuffledWorld[i + 1];

                left.InteractWith(right);
            }
            Thread.Sleep(1000);
        }
    }
}
