using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreNLog.Models;

namespace AspNetCoreNLog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("NLog Info logging");
            _logger.LogError("NLog Error");
            _logger.LogWarning("NLog Warning");
            _logger.LogDebug("NLog Debug");
            _logger.LogTrace("NLog Trace");
            _logger.LogCritical("NLog Critical");
            
            //_logger.LogInformation($"Created OrderId: {order.OrderId}, FriendlyId: {order.FriendlyId}, User: {user.UserName}.");
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
