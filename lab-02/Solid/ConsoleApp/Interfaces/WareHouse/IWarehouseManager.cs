using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IWarehouseManager
    {

        public Product AddProduct(Product product);
        public void RemoveProduct(Product product);
    

    }
}
