namespace apbd_tut3;

public class Container
{
    public int CargoMass { get; set; }
    public int Height { get; set; }
    public int TareWeight { get; set; }
    public int Depth { get; set; }

    public const string ContainerType = "C";
    private static int _lastContainerNumber = 0;
    private int _containerNumber;
    
    public string SerialNumber
    {
        get
        {
            return "KON-"+ContainerType+"-"+_containerNumber;
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
        _containerNumber = ++_lastContainerNumber;
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
}