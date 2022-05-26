using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2And3
{
    internal class Meat : Product
    {
        public Type MeatType { get; set; }
        public Category MeatCategory { get; set; }
        public Meat() : this(null, default(Type), default(Category), 0.0, 0.0) { }
        public Meat(string name, Type meatType, Category meatCategory, double weight, double price)
            : base(name, weight, price)
        {
            MeatCategory = meatCategory;
            MeatType = meatType;
        }
        public override double ChangePrice(int rate)
        {
            Console.WriteLine("Enter your category");
            int userCategory = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Wrong input");
            }
            Category category;
            category = (Category)Enum.GetValues(typeof(Category)).GetValue(userCategory - 1);

            switch (category)
            {
                case Category.Extra:
                    Price = Price + (Price * rate / 100.0) + (double)Category.Extra;
                    break;
                case Category.Sort1:
                    Price = Price + (Price * rate / 100) + (double)Category.Sort1;
                    break;
                default:
                    Price = Price + (Price * rate / 100) + (int)Category.Sort2;
                    break;
            }
            return Price;
        }
        public override string ToString()
        {
            return base.ToString() + " Type: " + MeatType + " Category: " + MeatCategory;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Meat);
        }
        public override void Parse(string str)
        {
            base.Parse(str);
            MeatType.ToString();
            MeatCategory.ToString();
        }
    }
}
