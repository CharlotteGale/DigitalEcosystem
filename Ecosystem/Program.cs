namespace Ecosystem;

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

        RunSimulation();
        

    }

    static List<IOrganism> World = new List<IOrganism>();

    static List<IOrganism> ShuffleWorld()
    {
        return World.OrderBy( x => Random.Shared.NextInt64() ).ToList( );
    }

        static void DisplayWorld()
    {
        foreach(IOrganism organism in World)
        {
            Console.WriteLine(organism.GetState());
        }
    }


    static void RunSimulation()
    {
        var loopCounter = 0;

        while (loopCounter < 3)
        {
            Console.Clear();
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

            DisplayWorld();

            Thread.Sleep(2000);
            
            Display.AsCircle(shuffledWorld);
            
            // Thread.Sleep(2000);

            // Console.WriteLine("\n=== DEBUG ===");
            // Console.WriteLine($"Shuffled order: {string.Join(", ", shuffledWorld.Select(o => o.GetType().Name))}");
            // Console.WriteLine("=============\n");

            Thread.Sleep(5000);

            loopCounter++;
        }
    }
}
