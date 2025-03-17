namespace apbd_tut3;

public class LiquidContainer : Container
{
    public new const string ContainerType = "L";
    
    public bool HazardousCargo { get; set; }
    
    public LiquidContainer(int Height, int TareWeight, int Depth) : base(Height, TareWeight, Depth)
    {
        
    }
    
    
}