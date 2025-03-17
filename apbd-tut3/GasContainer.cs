namespace apbd_tut3;

public class GasContainer : Container, IHazardNotifier
{
    public new const string ContainerType = "G";
    
    public GasContainer(int Height, int TareWeight, int Depth) : base(Height, TareWeight, Depth)
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