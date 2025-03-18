namespace apbd_tut3;

public class ContainerShip
{
    private List<Container> containers = new List<Container>();
    
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public int MaxWeightTons { get; set; }

    private int _totalWeight;

    public ContainerShip(double maxSpeed, int maxContainers, int maxWeightTons)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeightTons = maxWeightTons;
    }
    
    private void CalculateTotalWeightKg()
    {
        int total = 0;
        for (int i = 0; i < containers.Count; i++)
        {
            total += containers[i].TareWeight + containers[i].CargoMass;
        }

        _totalWeight = total;
    }

    public bool CheckIfContainerCanBeAdded(Container container)
    {
        if (_totalWeight + container.TareWeight + container.CargoMass > MaxWeightTons * 1000)
            throw new ArgumentException("Max weight for ship exceeded");
        return true;
    }
    
    public void LoadContainer(Container container)
    {
        CheckIfContainerCanBeAdded(container);
        containers.Add(container);
        CalculateTotalWeightKg();
    }

    public void LoadContainerAt(int at, Container container)
    {
        CheckIfContainerCanBeAdded(container);
        containers.Insert(at, container);
        CalculateTotalWeightKg();
    }

    public void LoadContainers(List<Container> containers)
    {
        for (int i = 0; i < containers.Count; i++)
            LoadContainer(containers[i]);
    }

    public int? FindIndexOfContainerWithNumber(int containerNumber)
    {
        for (int i = 0; i < containers.Count; i++)
        {
            if (containers[i].ContainerNumber == containerNumber)
            {
                return i;
            }
        }

        return null;
    }

    public Container? RemoveContainerWithNumber(int containerNumber)
    {
        int? index = FindIndexOfContainerWithNumber(containerNumber);
        if (index == null) return null;
        else
        {
            return containers[index.Value];
        }
    }

    public Container ReplaceContainerWithNumber(int containerNumber, Container replaceWithContainer)
    {
        int? indexForRemoval = FindIndexOfContainerWithNumber(containerNumber);
        if (indexForRemoval == null)
        {
            throw new ArgumentException("Container with number "+containerNumber+" not found");
        }
        else
        {
            Container removed = containers[indexForRemoval.Value];
            containers.RemoveAt(indexForRemoval.Value);
            
            LoadContainerAt(indexForRemoval.Value, replaceWithContainer);
            return removed;
        }
    }

    public void TransferContainer(int containerNumber, ContainerShip toShip)
    {
        Container? container = RemoveContainerWithNumber(containerNumber);
        if (container == null)
        {
            throw new ArgumentException("Container with number " + containerNumber + " not found");
        }
        else
        {
            toShip.LoadContainer(container);
        }
    }

    public override string? ToString()
    {
        string containerInfo = "";
        for (int i = 0; i < containers.Count; i++)
        {
            containerInfo += containers[i].ToString()+"\n";
        }
        return "ContainerShip\n" +
               "Max speed: " + MaxSpeed + " knots" + "\n" +
               "Max containers: " + MaxContainers + "\n" +
               "Max weight: " + MaxWeightTons + " tons" + "\n" + "Containers:\n" + containerInfo;
    }
}