using EcosystemDisplay;

public static class Display
{
    private static (List<IOrganism> animals, List<IOrganism> plants) SortOrganisms(List<IOrganism> world)
    {
        var animals = new List<IOrganism>();
        var plants = new List<IOrganism>();

        foreach (var organism in world)
        {
            var baseType = organism.GetType().BaseType?.Name;
            if (baseType == "Animal")
            {
                animals.Add(organism);
            }
            else if (baseType == "Plant")
            {
                plants.Add(organism);
            }
        }

        return (animals, plants);
    }
    public static void AsHeirarcy(List<IOrganism> world)
    {
        var (animals, plants) = SortOrganisms(world);
        
        Console.WriteLine("===== ANIMALS =====");
        foreach(var animal in animals)
        {
            Console.Write($"{animal.GetType().Name[0]} ");
            
        }

        Console.WriteLine("\n");

        Console.WriteLine("===== PLANTS =====");
        foreach(var plant in plants)
        {
            Console.Write($"{plant.GetType().Name[0]} ");
        }

        Console.WriteLine("\n");
    }

    public static void AsCircle(List<IOrganism> world)
    {
        int startY = Console.CursorTop;
        
        int radius = Math.Max(5, world.Count / 2);
        int centerX = radius + 5;
        int centerY = radius + 5;

        for(int i = 0; i < world.Count; i++)
        {
            double angle = 2 * Math.PI * i / world.Count;

            int x = centerX + (int)(radius * Math.Cos(angle));
            int y = centerY + (int)(radius * Math.Sin(angle));

            Console.SetCursorPosition(x, y);
            Console.Write(world[i].GetType().Name[0]);
        }

        Console.SetCursorPosition(0, centerY + radius + 2);
        Console.WriteLine();
    }
}