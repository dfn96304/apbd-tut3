using apbd_tut3;

public class Program
{
    public static void Test()
    {
        Container c1 = new Container(200, 100, 1000, 1000); // Create a container

        c1.LoadContainer(400); // Load cargo into a given container

        ContainerShip cs1 = new ContainerShip(50.0, 10000, 10000);

        cs1.LoadContainer(c1); // Load a container onto a ship

        List<Container> cl1 = new List<Container>
        {
            new Container(200, 100, 1000, 1000),
            new LiquidContainer(200, 150, 1000, 1000, true),
            new RefrigeratedContainer(200, 200, 1000, 1000, "Bananas", 14)
        };
        
        Console.WriteLine(cl1[0].SerialNumber);
        Console.WriteLine(cl1[1].SerialNumber);


        cs1.LoadContainers(cl1); // Load a list of containers onto a ship

        Container? removed1 = cs1.RemoveContainerWithNumber(1); // Remove a container from the ship

        removed1.EmptyContainer(); // Unload a container

        Container?
            replaced2 = cs1.ReplaceContainerWithNumber(2,
                removed1); // Replace a container on the ship with a given number with another container

        ContainerShip cs2 = new ContainerShip(40.0, 1000, 1000);

        cs1.TransferContainer(1, cs2); // The possibility of transferring a container between two ships

        Container test = new Container(200, 100, 1000, 1000);

        test.LoadContainer(100);

        Console.WriteLine(test); // Print information about a given container

        Console.WriteLine(cs1); // Print information about a given ship and its cargo
        Console.WriteLine(cs2);
    }

    public static void Main(string[] args)
    {
        Test();

        /*List<Container> containers = new List<Container>();
        List<ContainerShip> ships = new List<ContainerShip>();
        
        while (true)
        {
            Console.WriteLine("Container list: ");
            for (int i = 0; i < containers.Count; i++)
            {
                Console.WriteLine(containers[i]);
            }
            
            Console.WriteLine("Ship list: ");
            for (int i = 0; i < ships.Count; i++)
            {
                Console.WriteLine(ships[i].ToStringOnlyShip());
            }
            
            Console.WriteLine("Please enter a number: " +
                              "1. Add a container ship" +
                              "2. Remove a container ship" +
                              "3. Add a container" +
                              "4. Load a container on a ship" +
                              "5. Remove a container from a ship" +
                              "6. Exit");
        
            string input = Console.ReadLine();

            try
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Max speed: ");
                        double maxSpeed = double.Parse(Console.ReadLine());
                        Console.WriteLine("Max containers: ");
                        int maxContainers = int.Parse(Console.ReadLine());
                        Console.WriteLine("Max weight (tons): ");
                        int maxWeight = int.Parse(Console.ReadLine());
                        ships.Add(new ContainerShip(maxSpeed, maxContainers, maxWeight));
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}