using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IWarehouseManagerReport
    {

        public int GetCountProducts();
        public void ShowInventarisationReport();
        public void ShowAllReports();
        public void ShowWarehouseInfo();



    }
}
