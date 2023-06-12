using ConsoleApp.Interfaces.Reporting;
using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Store.Reporting
{
    public class ClReporting : IReporting
    {
        protected List<Report> SalesReports;
        protected List<Report> RevenueReports;
        protected Warehouse Warehouse { set; get; }
        public ClReporting() { }
        public ClReporting(Warehouse warehouse)
        { 
            this.Warehouse = warehouse;
            this.SalesReports = new List<Report>();
            this.RevenueReports = new List<Report>();
        }
        public void CreateRevenueInvoice(Product product,string description)
        {
           this.RevenueReports.Add(new Report(product, description));
        }

        public void CreateSalesInvoice(Product product, string description)
        {
            this.SalesReports.Add(new Report(product, description));
        }

        public string GetAllReports()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in this.SalesReports)
            {
                str.AppendLine(item.GetReport());
            }
            foreach (var item in this.RevenueReports)
            {
                str.AppendLine(item.GetReport());
            }
            return str.ToString();
        }

        public string Invertarisation()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\nInvertarisation:\n");
            List<Product> list = Warehouse.Products;
            int iterator = 0;
            foreach (var item in list)
            {
                str.AppendLine($"{iterator++} - Name: {item.Name} - Count: {item.Count} ");
            }
            return str.ToString();
        }
    }
}
