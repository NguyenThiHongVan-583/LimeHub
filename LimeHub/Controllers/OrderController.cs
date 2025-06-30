using LimeHub.Models;
using LimeHub.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LimeHub.Controllers
{
   
        public class OrdersController : Controller
        {
            private IOrderRepository orderRepository;
            private IShoppingCartRepository shoppingCartRepository;

            public OrdersController(IOrderRepository oderRepository, IShoppingCartRepository shoppingCartRepossitory)
            {
                this.orderRepository = oderRepository;
                this.shoppingCartRepository = shoppingCartRepossitory;
            }

            public IActionResult Checkout() => View();

            [HttpPost]
            public IActionResult Checkout(Order order)
            {
                orderRepository.PlaceOrder(order);
                shoppingCartRepository.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            public IActionResult CheckoutComplete() => View();
        }
}
