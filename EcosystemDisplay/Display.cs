using EcosystemDisplay;

public static class Display
{
    public static void AsHeirarcy(List<IOrganism> world)
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
}