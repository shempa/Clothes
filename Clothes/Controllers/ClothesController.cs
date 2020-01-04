using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Clothes.Controllers
{
    public class ClothesController : Controller
    {
        Models.ClothesContext db = new Models.ClothesContext();
        public ActionResult GetClothes()
        {      
            return View(db.Clothes);
        }
        [HttpGet]
        public ActionResult AddClothes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClothes(Models.Clothes clothes)
        {
            db.Clothes.Add(clothes);
            db.SaveChanges();
            return RedirectPermanent("~/Clothes/GetClothes");
        }
        public ActionResult EditClothes(int id)
        {
            Models.Clothes clothes = db.Clothes.Find(id);
            return View(clothes);
        }
        public ActionResult NewClothes(Models.Clothes clothes)
        {
           db.Entry(clothes).State= EntityState.Modified;
            db.SaveChanges();
            return RedirectPermanent("~/Clothes/GetClothes");
        }
        public ActionResult DeleteClothes(int id)
        {
            Models.Clothes clothes = db.Clothes.Find(id);
            db.Clothes.Remove(clothes);
            db.SaveChanges();
            return RedirectPermanent("~/Clothes/GetClothes");
        }
    }
}