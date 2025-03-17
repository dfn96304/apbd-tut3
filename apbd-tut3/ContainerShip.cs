namespace apbd_tut3;

public class ContainerShip
{
    public List<Container> containers = new List<Container>();
    
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public int MaxWeightTons { get; set; }

    public void LoadContainer(Container container)
    {
        containers.Add(container);
    }

    public void LoadContainers(List<Container> containers)
    {
        this.containers.AddRange(containers);
    }
}