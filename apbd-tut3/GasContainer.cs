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
}