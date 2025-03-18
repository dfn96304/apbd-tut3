using apbd_tut3;

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

cs1.LoadContainers(cl1); // Load a list of containers onto a ship

Container? removed1 = cs1.RemoveContainerWithNumber(1); // Remove a container from the ship

removed1.EmptyContainer(); // Unload a container

Container? replaced2 = cs1.ReplaceContainerWithNumber(2, removed1); // Replace a container on the ship with a given number with another container

ContainerShip cs2 = new ContainerShip(40.0, 1000, 1000);

cs1.TransferContainer(1, cs2); // The possibility of transferring a container between two ships

Container test = new Container(200, 100, 1000, 1000);

test.LoadContainer(100);

Console.WriteLine(test); // Print information about a given container

Console.WriteLine(cs1); // Print information about a given ship and its cargo
Console.WriteLine(cs2);