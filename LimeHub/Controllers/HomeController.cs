using System.Diagnostics;
using LimeHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LimeHub.Models.Interfaces;
using Microsoft.Extensions.Logging; 

namespace LimeHub.Controllers
{
    public class HomeController(IProductRepository productRepository, ILogger<HomeController> logger) : Controller 
    {
        

        public IActionResult Index()
        {
            
            return View(productRepository.GetTrendingProducts());
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