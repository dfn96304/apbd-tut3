namespace apbd_tut3;

public class Container
{
    public int CargoMass { get; set; }
    public int Height { get; set; }
    public int TareWeight { get; set; }
    public int Depth { get; set; }

    public const string ContainerType = "C";
    private static int _lastContainerNumber = 0;
    public int ContainerNumber { get; }
    
    public string SerialNumber
    {
        get
        {
            return "KON-"+ContainerType+"-"+ContainerNumber;
        }
    }
    
    public int MaxPayload { get; set; }

    public Container(int height, int tareWeight, int depth, int maxPayload)
    {
        this.Height = height;
        this.TareWeight = tareWeight;
        this.Depth = depth;
        this.MaxPayload = maxPayload;
        CargoMass = 0;
        ContainerNumber = ++_lastContainerNumber;
    }
    
    public virtual void EmptyContainer()
    {
        CargoMass = 0;
    }

    public virtual void LoadContainer(int mass)
    {
        if (mass <= 0)
            throw new ArgumentOutOfRangeException("Mass cannot be negative or zero");
        
        if(CargoMass+mass > MaxPayload)
            throw new OverflowException();

        CargoMass += mass;
    }

    public override string? ToString()
    {
        return "Type: Container" +
               ", Number: " + ContainerNumber +
               ", Cargo mass: " + CargoMass + " kg / " + MaxPayload + " kg max" +
               ", Max payload: " + MaxPayload + " kg" +
               ", Tare weight: " + TareWeight + " kg" +
               ", Height: " + Height + " cm" +
               ", Depth: " + Depth + " cm";
    }
}