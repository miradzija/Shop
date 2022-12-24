using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    public class ShopListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ShopListController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ShopList> itemList = _db.shopLists;
            return View(itemList);
        }


    }
}
