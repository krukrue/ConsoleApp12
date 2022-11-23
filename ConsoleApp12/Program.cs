using ClassLibrary1;

Stock<IProduct> sklad = new Stock<IProduct>();
Bike bike = new Bike("Kolo", 2312, 123, 105, 30, 5);
Bike bike1 = new Bike("Honda", 400, 113, 115, 30, 150);
MobilePhone phone = new("Iphone", 1000, 30, 15, 2);
sklad.Add(bike);
sklad.Add(bike1);
sklad.Add(phone);

FilterEvaluator filter = new FilterEvaluator();
WidthFilter widthfilter = new WidthFilter();
PriceFilter pricefilter = new PriceFilter(2100, 500);
filter.Add(pricefilter);
//filter.Add(widthfilter);
var a = sklad.Filter(filter);
foreach(var item in a)
{
    Console.WriteLine(item.Name);
}


Stock<IWheeledVehicle> kola = new Stock<IWheeledVehicle>();
kola.Add(bike);
kola.Add(bike1);
FilterEvaluator filterCars= new FilterEvaluator();
WhellCountFilter wcf = new(5);
filterCars.Add(wcf);
var b = kola.Filter(filterCars);
foreach (var item in b)
{
    Console.WriteLine(item.Name);
}