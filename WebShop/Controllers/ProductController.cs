using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult OrderHistory()
        {
            return View();
        }
        public ActionResult WishList()
        {
            return View();
        }
        public ActionResult CheckOut()
        {
            return View();
        }
        public ActionResult ShoppingCart()
        {
            return View();
        }

        public ActionResult ShopSingleItem()
        {
            return View();
        }
    }
}