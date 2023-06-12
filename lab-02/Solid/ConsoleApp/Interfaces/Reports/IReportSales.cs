using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces.Reporting
{
    public interface IReportSales
    {
        public void CreateSalesInvoice(Product product, string description);

    }
}
