using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Share_Market_Graph.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public FileResult Index()
        {
            string[] xAxis = { "State Bank of India", "Bajaj Finance", "TCS", "Infosys", "Axis Bank", "Tata Steel" };
            string[] yAxis = { "1,086.50", "1,115.00", "2,442.40", "1,151.20", "1,342.90", "188.00" };

            var fileBytes = new Chart(width: 700, height: 400)
                .AddSeries
                (
                    //chartType: "column",
                    //chartType:"Pie",
                    //chartType:"doughnut",
                    //chartType:"Point",
                    chartType:"Line",    

                    xValue: xAxis,
                    yValues: yAxis)
                    .GetBytes();

            return File(fileBytes, "image/png");
        }
    }
}