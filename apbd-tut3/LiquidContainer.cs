namespace apbd_tut3;

public class LiquidContainer : Container, IHazardNotifier
{
    public new const string ContainerType = "L";
    
    public bool HazardousCargo { get; set; }
    
    public LiquidContainer(int height, int tareWeight, int depth, bool hazardousCargo) : base(height, tareWeight, depth)
    {
        HazardousCargo = hazardousCargo;
    }

    public void Notify(string serialNumber, string description)
    {
        
    }

    public override void LoadContainer(int mass)
    {
        if (mass <= 0)
            throw new ArgumentOutOfRangeException("Mass cannot be negative or zero");
        
        if(HazardousCargo)
            if (CargoMass + mass > MaxPayload * 0.5)
            {
                Notify(this.SerialNumber, "Attempted to fill a LiquidContainer with hazardous cargo to more than 50% capacity");
                throw new OverflowException();
            }
        else if (CargoMass + mass > MaxPayload * 0.9)
        {
            Notify(this.SerialNumber, "Attempted to fill a LiquidContainer without hazardous cargo to more than 90% capacity");
            throw new OverflowException();
        }

        CargoMass += mass;
    }
}