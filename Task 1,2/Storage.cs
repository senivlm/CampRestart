using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1And2
{
    internal class Storage
    {
        private int productsAmount;
        private double totalWeight;
        private double totalPrice;
        private Product[] allProducts;

        public int ProductsAmount { get; set; }
        public double TotalWeight { get; set; }
        public double TotalPrice { get; set; }
        
        public Storage() : this(0, 0.0, 0.0) { }
        public Storage(int productsAmount, double totalWeight, double totalPrice)
        {
            ProductsAmount = productsAmount;
            TotalWeight = totalWeight;
            TotalPrice = totalPrice;
            allProducts = new Product[productsAmount];
        }
        public override string ToString()
        {
            return string.Format("Amount: " + ProductsAmount + " Total Weight: " + TotalWeight +
                " Total Price: " + TotalPrice);
        }
        public override bool Equals(object? otherStorage)
        {
            return ProductsAmount.Equals(((Storage)otherStorage).ProductsAmount) &&
                TotalWeight.Equals(((Storage)otherStorage).TotalWeight) &&
                TotalPrice.Equals(((Storage)otherStorage).TotalPrice);
        }

        public void Initialization(string name, double weight, double price)
        {
            Product product = new Product(name, price, weight);
        }
        public void Print(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ToString());
            }
        }
        public Product[] AddProduct(Product product)
        {
            Product[] temp = new Product[allProducts.Length + 1];
            temp[temp.Length - 1] = product;
            allProducts = temp;
            return allProducts;
        }
        public void ChangePrice(Product[] products, int rate)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].Price = (double)products[i].Price + (products[i].Price * rate / 100);
            }
        }
        public Product this[int index]
        {
            get 
            { if (index >= 0 && index < allProducts.Length)
                {
                    return allProducts[index];
                }
                else throw new ArgumentOutOfRangeException();
            }
            set 
            { if (index >= 0 && index < allProducts.Length)
                {
                    allProducts[index] = value;
                }
                else throw new ArgumentOutOfRangeException();
            }
        }
       
        public void Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            string[] arrayStr = str.Split(' ');
            if (!(int.TryParse(arrayStr[0], out productsAmount)))
            {
                throw new ArgumentException();
            }
            if (!(double.TryParse(arrayStr[1], out totalWeight)))
            {
                throw new ArgumentException();
            }
            if (!(double.TryParse(arrayStr[2], out totalPrice)))
            {
                throw new ArgumentException();
            }
        }
    }
}
