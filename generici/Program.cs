using generici;

var letter1 = new Letter("123", 5.0);
var letter2 = new Letter("124",6.0);

var parcel1 = new Parcel("125", 7.0, "Big");
var parcel2 = new Parcel("126",1.0, "like minipekka");

letter1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);

myCargo.GetTotalCost();