using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Store.Reporting
{
    public class Report
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }

        public string GetReport()
        {
            return $"\n-------------------------\n" +
                $"Report {this.Id}\n" +
                $"Product: {this.Product.Name}\n" +
                $"Description: {this.Description}\n" +
                $"-------------------------\n";
        }
        public Report() { }
        public Report(Product product, string description)
        {
            this.Product = product;
            this.Description = description;
            Id = Guid.NewGuid();
        }
    }
}
