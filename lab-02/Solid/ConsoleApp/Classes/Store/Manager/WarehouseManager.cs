using ConsoleApp.Interfaces;
using ConsoleApp.ProductPart;
using System;
using ConsoleApp.Classes.Store.Reporting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Store.Manager
{
    public class WarehouseManager : IWarehouseManager, IWarehouseManagerReport
    //Interface segregation (Розділення інтерфейсів на окремі операції, за метою виконання.)
    //Іншими словами, ISP рекомендує розбивати великі монолітні інтерфейси на менші, більш конкретні інтерфейси,
    //щоб клієнти могли залежати тільки від інтерфейсів, які їм потрібні. Це може допомогти зменшити зв'язність між
    //компонентами. Якщо ми створимо якийсь клас - WarehouseManagerOnlyReport, то нам знадобиться реалізація тільки IWarehouseManagerReport.
    {
        protected Warehouse Warehouse;
        protected ClReporting Reporting;
        public WarehouseManager(Warehouse house)
        {
            this.Warehouse = house;
            this.Reporting = new ClReporting(house);
        }
        public Product AddProduct(Product product)
        {
            Product existProduct = this.isProductExist(product);
            if (existProduct != null)
            {
                IncrementCountOfProduct(existProduct, product);
                this.Reporting.CreateRevenueInvoice(product, "Replenishment of quantity of goods.");
                Warehouse.LastDeliveryTime = DateTime.Now;
            }
            else
            {
                Warehouse.Products.Add(product);
                Warehouse.LastDeliveryTime = DateTime.Now;
                this.Reporting.CreateRevenueInvoice(product, "Product added to Sklad.");
                return product;
            }
            return product;
        }

        public int GetCountProducts()
        {
           return Warehouse.Products.Count;
        }

        public void RemoveProduct(Product product)
        {
            Product existProduct = this.isProductExist(product);
            if (existProduct == null)
            {
                Console.WriteLine("You can't remove this product, because it doesn't exist!");
            }
            else
            {
                Warehouse.Products.Remove(existProduct);
                this.Reporting.CreateSalesInvoice(product, "The product has been sold.");
                //Console.WriteLine("Remove is successful");
            }
        }
        public Product FindProduct(string name)
        {
            Product found = Warehouse.Products.Find(item=> item.Name == name );
            return found;
        }
        public void ShowAllReports()
        {
            Console.WriteLine(this.Reporting.GetAllReports());
        }

        public void ShowInventarisationReport()
        {
            Console.WriteLine(this.Reporting.Invertarisation());

        }

        public void ShowWarehouseInfo()
        {
            Console.WriteLine("WarehouseInfo-------------------\n" +
                $"Titile: {Warehouse.Title}\n" +
                $"Count of products: {this.GetCountProducts()}\n" +
                $"Last delivery time: {Warehouse.LastDeliveryTime.ToString()}");
        }
        protected void IncrementCountOfProduct(Product existProduct, Product newInputProduct)
        {
            existProduct.Count += newInputProduct.Count;
        }
        public Product isProductExist(Product product)
        {
            foreach (Product p in Warehouse.Products)
            {
                if (p.Name == product.Name)
                    return p;
            }
            return null;
        }
    }
}
