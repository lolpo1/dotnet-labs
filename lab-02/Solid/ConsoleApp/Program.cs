using ConsoleApp.Classes.Store;
using ConsoleApp.Classes.Store.Manager;
using ConsoleApp.MoneyPart;
using ConsoleApp.ProductPart;
using System;

namespace ConsoleApp


{
    class Program
    {
        static void Main(string[] args)
        {
            //Store creating
            Warehouse electronicsStore = new ElectronicsWareHouse(new Dollar());
            //Manager creating
            WarehouseManager electronicsStoreManager = new WarehouseManager(electronicsStore);
            //Goods creating
            Product product1 = new Product("Samsung TV", new Dollar("699,09"),4);
            Product product2 = new Product("Samsung TV2", new Dollar("699,09"),5);
            Product product3 = new Product("Samsung TV3", new Dollar("699,09"),4);
            //Adding goods
            electronicsStoreManager.AddProduct(product1);
            electronicsStoreManager.AddProduct(product2);
            electronicsStoreManager.AddProduct(product3);
            electronicsStoreManager.AddProduct(product3);
            electronicsStoreManager.RemoveProduct(product2);
            //Actions
            electronicsStoreManager.ShowAllReports();
            electronicsStoreManager.ShowInventarisationReport();

        }
    }
}
