using DSE_Web_Data_Analysis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using DSE_Web_Data_Analysis.Factory;

namespace DSE_Web_Data_Analysis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStoreDataListUrlFactory _storeDataListUrlFactory;

        public HomeController(ILogger<HomeController> logger, IStoreDataListUrlFactory storeDataListUrlFactory)
        {
            _logger = logger;
            _storeDataListUrlFactory = storeDataListUrlFactory;
        }

        public IActionResult Index()
        {
            //_storeDataListUrlFactory.DataScarpping(5);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
