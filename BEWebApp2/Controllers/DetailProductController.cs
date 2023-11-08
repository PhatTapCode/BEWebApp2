using BEWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BEWebApp2.Controllers
{
    public class DetailProductController : Controller
    {
        private StoreMgmtEntities db = new StoreMgmtEntities();

        // GET: DetailProduct
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetailProduct()
        {   
            List<Product> listProduct=db.Products.ToList();
            List<Color> colorList = db.Colors.ToList();
            return View();
        }
    }
}