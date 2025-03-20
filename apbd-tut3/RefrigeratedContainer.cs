namespace apbd_tut3;

public class RefrigeratedContainer : Container
{
    public override string ContainerType
    {
        get
        {
            return "C";
        }
    }

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
    
    public string ProductType { get; set; }
    public double Temperature { get; set; }
    
    public RefrigeratedContainer(int height, int tareWeight, int depth, int maxPayload, string productType, double temperature) : base(height, tareWeight, depth, maxPayload)
    {
        ProductType = productType;
        Temperature = temperature;
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
    
    public override string? ToString()
    {
        return "Type: RefrigeratedContainer" +
               ", Number: " + ContainerNumber +
               ", Cargo mass: " + CargoMass + " kg / " + MaxPayload + " kg max" +
               ", Max payload: " + MaxPayload + " kg" +
               ", Tare weight: " + TareWeight + " kg" +
               ", Height: " + Height + " cm" +
               ", Depth: " + Depth + " cm" +
               ", ProductType: " + ProductType +
               ", Temperature: " + Temperature;
    }
}