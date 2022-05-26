using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2And3
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
        public Product[] AllProducts { get; set; }
        public Storage() : this(0, 0.0, 0.0) { }
        public Storage(int productsAmount, double totalWeight, double totalPrice)
        {
            ProductsAmount = productsAmount;
            TotalWeight = totalWeight;
            TotalPrice = totalPrice;
            AllProducts = new Product[productsAmount];
        }
        void UserDialogue()
        {
            Console.WriteLine("Enter your product"); //зробити тут метод ручного вводу з перевірками
            string product = Console.ReadLine();

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

        public void ChangePrice(Product[] products, int rate)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].Price = (double)products[i].Price + (products[i].Price * rate / 100);
            }
        }
        public Product this[int index]
        {
            get { return AllProducts[index]; }
            set { AllProducts[index] = value; }
        }
        public override string ToString()
        {
            return string.Format("Amount: " + ProductsAmount + " Total Weight: " + TotalWeight +
                " Total Price: " + TotalPrice);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Storage);
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
