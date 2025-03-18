namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public new const string ContainerType = "G";
    
    public GasContainer(int height, int tareWeight, int depth, int maxPayload) : base(height, tareWeight, depth, maxPayload)
    {
        
    }
    
    public void Notify(string serialNumber, string description)
    {
        
    }

    public override void EmptyContainer()
    {
        CargoMass = CargoMass / 20;
    }
    
    public override string? ToString()
    {
        return "Type: GasContainer" +
               ", Number: " + ContainerNumber +
               ", Cargo mass: " + CargoMass + " kg / " + MaxPayload + " kg max" +
               ", Max payload: " + MaxPayload + " kg" +
               ", Tare weight: " + TareWeight + " kg" +
               ", Height: " + Height + " cm" +
               ", Depth: " + Depth + " cm";
    }
}