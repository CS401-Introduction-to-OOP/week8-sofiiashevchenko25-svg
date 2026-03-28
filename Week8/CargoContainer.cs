namespace Week8;

public class SmartRoom <T > where T : DeliveryItem
{
    private List <T > _post = new List <T >() ;
    
    public void AddItem ( T item )
    {
        _post.Add(item) ;
        Console.WriteLine( $" Added : { item.TrackingNumber } ( Type : { typeof ( T ) . Name}) " ) ;
    }
    
    public  double GetTotalCost()
    {
        double allcost = 0;
        foreach ( var item  in _post )
        {
            allcost += item.CalculateCost();
        }

        return allcost;
    }
}