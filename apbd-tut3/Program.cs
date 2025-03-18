using apbd_tut3;

Container c1 = new Container(200, 100, 1000, 1000);

c1.LoadContainer(400);

ContainerShip cs1 = new ContainerShip();
cs1.MaxSpeed = 50.0;
cs1.MaxContainers = 10000;
cs1.MaxWeightTons = 10000;

cs1.LoadContainer(c1);

List<Container> cl1 = new List<Container>
{
    new Container(200, 100, 1000, 1000),
    new LiquidContainer(200, 150, 1000, 1000, true),
    new RefrigeratedContainer(200, 200, 1000, 1000, "Bananas", 14)
};

cs1.LoadContainers(cl1);
