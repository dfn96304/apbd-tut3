namespace apbd_tut3;

public class Container
{
    public int cargoMass { get; set; }
    public int height { get; set; }
    public int tareWeight { get; set; }
    public int depth { get; set; }

    private string containerType;
    private string containerNumber;
    
    private string serialNumber
    {
        get
        {
            return "KON-"+containerType+"-"+containerNumber;
        }
    }
    
    public int maxPayload { get; set; }

    public void emptyContainer()
    {
        cargoMass = 0;
    }

    public void loadContainer(int mass)
    {
        if (mass <= 0)
            throw new ArgumentOutOfRangeException("Mass cannot be negative or zero");
        
        if(cargoMass+mass > maxPayload)
            throw new OverflowException();

        cargoMass += mass;
    }
}