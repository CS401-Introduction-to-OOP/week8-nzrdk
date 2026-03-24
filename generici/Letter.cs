namespace generici;

public class Letter : DeliveryItem
{
    public string Design { get; set; }

    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    
    {
        
    }

    public override double CalculateCost()
    {
        return 15 + (Weight) * 10;
    }
}