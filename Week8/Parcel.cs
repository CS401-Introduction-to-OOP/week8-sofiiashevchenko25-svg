namespace Week8;


public class Percel : DeliveryItem
{
    public string dimensions { get ; private set ; }
    
// Calling the base class constructor via base ()
    public Percel(string TrackingNumber, double Weight) : base( TrackingNumber, Weight)
    {

        string imensions = dimensions ;
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
        Console.WriteLine($" Brightness : { dimensions }% " );
    }
    
}