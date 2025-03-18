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
            
            containers.Insert(indexForRemoval.Value, replaceWithContainer);
            return removed;
        }
    }
}