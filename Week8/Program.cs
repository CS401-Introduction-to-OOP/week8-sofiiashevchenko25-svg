// See https://aka.ms/new-console-template for more information
using Week8;

Letter object1 = new Letter("12345", 25);
Letter object2 = new Letter("23456", 10);

Parcel object3 = new Parcel("abcde", 22, "20x30x10");
Parcel object4 = new Parcel("bcdef", 12, "20x30x15");

object1.PrintInfo();
object4.PrintInfo();

CargoContainer <DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(object1);
myCargo.AddItem(object2);
myCargo.AddItem(object3);
myCargo.AddItem(object4);

Console.WriteLine(myCargo.GetTotalCost());