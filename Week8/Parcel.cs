namespace Week8;


public class Parcel : DeliveryItem
{
    public string Dimensions { get ; private set ; }
    
// Calling the base class constructor via base ()
    public Parcel(string TrackingNumber, double Weight, string dimensions) : base( TrackingNumber, Weight)
    {

         Dimensions = dimensions ;
    }
    
// Mandatory implementation of the abstract method
    public override double CalculateCost ()
    {

        double endcost = 50 + Weight * 25;
        return endcost;
    }
    
// Overriding the virtual method with a call to base logic
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.Write($" Dimensions : { Dimensions }% " );
    }
    
}