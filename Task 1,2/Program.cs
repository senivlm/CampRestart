using Task1And2;

try
{
    Product product = new Product("Product1", 12.5, 13.0);
    Console.WriteLine(product.ToString());
    Dairy_products dairy1 = new Dairy_products("Milk", 1.0, DateTime.Now, 12.5);
    Console.WriteLine(dairy1.ToString());
    Meat meat = new Meat("Meat1", Type.Chicken, Category.Extra, 1.3, 12.4);
    Console.WriteLine(meat.ToString());

    Buy buyer1 = new Buy(1, 12.4, 13.2);
    Console.WriteLine(buyer1.ToString());
    Check checkBuy = new Check("Product2", 2, 13.5, 34);
    Console.WriteLine(checkBuy.ToString());
    Storage myStorage = new Storage(2, 23.4, 22.6);
    Console.WriteLine(myStorage.ToString());
}
catch (ArgumentException)
{
    Console.WriteLine("Argument problem");
}
catch (Exception)
{
    Console.WriteLine("Problem");
}
Console.ReadLine();