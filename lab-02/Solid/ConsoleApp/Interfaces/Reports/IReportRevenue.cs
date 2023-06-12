using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces.Reporting
{
    public interface IReportRevenue
    {
        public void CreateRevenueInvoice(Product product, string description);

    }
}
