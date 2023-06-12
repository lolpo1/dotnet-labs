using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces.Reporting
{
    public interface IReporting : IReportSales, IReportRevenue, IReportTotal
    {
        //Interface segregation (Розділення інтерфейсів на окремі операції, за метою виконання.)
        //Іншими словами, ISP рекомендує розбивати великі монолітні інтерфейси на менші, більш конкретні інтерфейси,
        //щоб клієнти могли залежати тільки від інтерфейсів, які їм потрібні. Це може допомогти зменшити зв'язність між
        //компонентами. В даному випадку усі інтерфейси об'єднуються в один, але можуть використовуватись окремо
    }
}
