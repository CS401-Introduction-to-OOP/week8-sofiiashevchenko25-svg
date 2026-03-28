public abstract class SmartDevice
{
    public string Name { get ; }
    public bool IsOn { get ; protected set ; } // State can only bemodified internally or in derived classes
    public SmartDevice ( string name )
    {
        Name = name ;
        IsOn = false ;
    }
// Abstract method : each device toggles in its own way
    public abstract void Toggle () ;
// Virtual method : base logic that can be extended
    public virtual void PrintStatus ()
    {
        string status = IsOn ? " On " : " Off " ;
        Console.WriteLine( $" Device : { Name } | Status : { status } ");
    }
}