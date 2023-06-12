using ConsoleApp.Interfaces;
using ConsoleApp.MoneyPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProductPart
{
    public class Product
    {
        public Guid Id { get; set; }

        protected string name;
        public string Name { set { name = value; } get { return name; } }

        protected int count;
        public int Count { set { count = value; } get { return count; } }

        //Принцип підстановки Лісков (Liskov Substitution Principle)
        //ми можемо використовувати об'єкти, які реалізовують інтерфейс IMoney, і програма буде працювати правильно.
        protected IMoney price;
        public IMoney Price { set { price = value; } get { return price; } }

        public Product(string name, IMoney price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.Id = Guid.NewGuid();
        }
        public Product() { }

        public void ShowProductInfo()
        { 
            Console.WriteLine("Product-------------\n" +
                $"Name: {this.name}\n" +
                $"Count: {this.count}\n" +
                $"Price: {this.Price.GetTotalInString()}{this.Price.Sign}\n");
        }
    }
}
