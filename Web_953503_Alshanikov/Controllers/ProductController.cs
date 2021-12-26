using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web_953503_Alshanikov.Data;
using Web_953503_Alshanikov.Entities;
using Web_953503_Alshanikov.Models;
using Web_953503_Alshanikov.Extensions;
//using Microsoft.Extensions.Logging;

namespace Web_953503_Alshanikov.Controllers
{
    public class ProductController : Controller
    {
        int _pageSize;
        //private ILogger _logger;
        ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)//, ILogger<ProductController> logger)
        {
            _pageSize = 3;
            //_logger = logger;
            _context = context;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {
            //_logger.LogInformation($"info: group={group}, page={pageNo}");

            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);

            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
    }
}
