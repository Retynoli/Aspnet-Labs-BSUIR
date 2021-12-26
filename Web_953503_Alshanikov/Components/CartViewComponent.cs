using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_953503_Alshanikov.Extensions;
using Web_953503_Alshanikov.Models;

namespace Web_953503_Alshanikov.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
