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


        //GET
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ShopList obj)
        {
            if (obj.ProductName == obj.Size.ToString())
            {
                ModelState.AddModelError("name", "You fucked up");
            }
            if (ModelState.IsValid)
            {
                _db.shopLists.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var shopListFromDb = _db.shopLists.Find(id);

            if (shopListFromDb == null)
            {
                return NotFound();
            }

            return View(shopListFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ShopList obj)
        {
            if (obj.ProductName == obj.Size.ToString())
            {
                ModelState.AddModelError("name", "You fucked up");
            }
            if (ModelState.IsValid)
            {
                _db.shopLists.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
