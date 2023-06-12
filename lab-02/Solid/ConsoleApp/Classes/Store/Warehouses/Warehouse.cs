using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ProductPart
{
    public abstract class Warehouse
        //Single Responsibility Principle(Принцип єдиної відповідальності  
        //Warehouse спрямований лише на виконання однієї відповідальності.
        //Це допомагає зберігати код простим, зрозумілим та легко підтримуваним.
        //Це клас реалізований для зберігання даних складу. А дії над )
    {
        public abstract string Title { set; get; }
        public IMoney Money { set; get; }
        public List<Product> Products { set; get; }
        public DateTime LastDeliveryTime { set; get; }
        public Warehouse(IMoney money)
        {
            this.Money = money;
            this.Products = new List<Product>();
        }

    }
}
