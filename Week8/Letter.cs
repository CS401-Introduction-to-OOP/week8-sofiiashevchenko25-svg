namespace Week8;

public class Letter : DeliveryItem
{
    public int Brightness { get ; private set ; }
    
// Calling the base class constructor via base ()
    public Letter(string TrackingNumber, double Weight) : base( TrackingNumber, Weight)
    {
        int cost = 15;
    }
    
// Mandatory implementation of the abstract method
    public override double CalculateCost ()
    {

        double endcost = 15 + Weight * 10;
        return endcost;
    }
    
// Overriding the virtual method with a call to base logic
    
}