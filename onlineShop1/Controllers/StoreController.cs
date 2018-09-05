using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using onlineShop1.Models;

namespace onlineShop1.Controllers
{
  public class StoreController : Controller
  {
    // GET: Store
    public ActionResult Index()
    {
      var category = new List<Category> {
        new Category { Name = "Electronics"},
        new Category { Name = "Furniture"},
        new Category { Name = "Sport"},
        new Category { Name = "Accessories"},
      };
      return View(category);
    }
    public ActionResult Browse(string category)
    {
      var categoryModel = new Category { Name = category };
      return View(categoryModel);
    }
    public ActionResult Details(int id)
    {
      var item = new Item { Title = "item " + id };
      return View(item);
    }
  }
}