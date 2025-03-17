namespace apbd_tut3;

public class RefrigeratedContainer : Container
{
    public new const string ContainerType = "C";

    public static Dictionary<string, double> RefrigeratedProducts = new Dictionary<string, double>()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };
    
    public string? ProductType { get; set; }
    public double Temperature { get; set; }
    
    public RefrigeratedContainer(int Height, int TareWeight, int Depth) : base(Height, TareWeight, Depth)
    {
        ProductType = null;
    }
    
    public void LoadContainer(string ProductType, int mass)
    {
        if (mass <= 0)
            throw new ArgumentOutOfRangeException("Mass cannot be negative or zero");

        if (!RefrigeratedProducts.ContainsKey(ProductType))
            throw new ArgumentException("Invalid product type");
        
        if (CargoMass == 0)
            this.ProductType = ProductType;
        else if(this.ProductType != ProductType)
            throw new ArgumentException("This container is already loaded with a different product type");

        if (this.Temperature < RefrigeratedProducts[ProductType])
            throw new ArgumentException("The temperature of this container is lower than the required temperature for this product type");
        
        if(CargoMass+mass > MaxPayload)
            throw new OverflowException();

        CargoMass += mass;
    }
}