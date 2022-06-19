
using Task_1_2;
using Task1And2;

//try
//{
//Product product = new Product("Product1", 12.5, 13.0);
//Console.WriteLine(product.ToString());

//DairyProducts dairy1 = new DairyProducts("Milk", 1.0, DateTime.Now, 12.5);
//Console.WriteLine(dairy1.ToString());
//Meat meat = new Meat("Meat1", Type.Chicken, Category.Extra, 1.3, 12.4);
//Console.WriteLine(meat.ToString());

Buy buyer1 = new Buy("Product3", 1, 12.4, 13.2);
//Console.WriteLine(buyer1.ToString());

//Storage myStorage = new Storage(2, 23.4, 22.6);
//Console.WriteLine(myStorage.ToString());

//Check check = new Check();
//CheckDecor checkDecor = new CheckDecor();


IViewerBuy viewerBuy = new Check();
viewerBuy.ViewerBuy(buyer1);

viewerBuy = new CheckDecor();
viewerBuy.ViewerBuy(buyer1);

Product product1 = new Product("Milk", 3.9, 4.5);
Product product2 = new Product("Chokolade", 1.2, 5.5f);

Console.WriteLine(product2.CompareTo(product1));

List<Product> products = new List<Product>()
{
    new Product("Apple", 2.1, 3.2),
    new Product("Bubble", 0.1, 18.2),
    new Product("Iron", 2.4, 8.2),
    new Product("Melon", 3.7, 2.1),
};
foreach (Product product in products)
{
    Console.WriteLine(product);
}

products.Sort();
Console.WriteLine("********");

foreach (Product product in products)
{
    Console.WriteLine(product);
}

CompareByPrice comparePrice = new CompareByPrice();

products.Sort(comparePrice);

Console.WriteLine("********");

foreach (Product product in products)
{
    Console.WriteLine(product);
}

//}
//catch (ArgumentException)
//{
//    Console.WriteLine("Argument problem");
//}
//catch (Exception)
//{
//    Console.WriteLine("Problem");
//}


