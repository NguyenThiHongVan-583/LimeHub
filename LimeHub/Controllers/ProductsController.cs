using Microsoft.AspNetCore.Mvc;
using LimeHub.Models.Interfaces;
using LimeHub.Models;


namespace LimeHub.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository; 

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
           
            return View(productRepository.GetAllProducts());
        }

        public ActionResult Detail(int id)
        {
           
            var product = productRepository.GetProductDetail(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}