public abstract class DeliveryItem
{
    public string TrackingNumber { get ; }
    public double Weight { get ; protected set ; } // State can only bemodified internally or in derived classes
    public DeliveryItem ( string trackingNumber, double weight )
    {
        TrackingNumber = trackingNumber ;
        Weight = weight;

    }
// Abstract method : each device toggles in its own way
    public abstract double CalculateCost() ;
    
// Virtual method : base logic that can be extended
    public virtual void PrintInfo()
    {
        //string status = IsOn ? " On " : " Off " ;
        Console.WriteLine( $" Number : { TrackingNumber } | Weight : { Weight } ");
    }
}