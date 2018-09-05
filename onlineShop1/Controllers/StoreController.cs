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
		ShoppingStoreEntities storeDB = new ShoppingStoreEntities();
		// GET: Store
		public ActionResult Index()
		{

			var categories = storeDB.Categories.ToList();
			return View(categories);
		}
		public ActionResult Browse(string category)
		{
			var categoryModel = storeDB.Categories.Include("Items")
				.Single(c => c.Name == category);
			return View(categoryModel);
		}
		public ActionResult Details(int id)
		{
			var item = new Item { Title = "item " + id };
			return View(item);
		}
	}
}