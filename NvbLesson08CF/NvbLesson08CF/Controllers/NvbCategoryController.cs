using NvbLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvbLesson08CF.Controllers
{
    public class NvbCategoryController : Controller
    {
        private static NvbBookStore _NvbBookStore;
        public NvbCategoryController()
        {
            _NvbBookStore = new NvbBookStore();
        }
        // GET: NvbCategory
        public ActionResult NvbIndex()
        {
            var nvbCategory = _NvbBookStore.NvbCategories.ToList();
            return View(nvbCategory);
        }
        [HttpGet]
        public ActionResult NvbCreate() { 
            
            var nvbCategory = new NvbCategory();
                return View(nvbCategory);
        }
        [HttpPost]
        public ActionResult NvbCreate(NvbCategory nvbCategory)
        {
            _NvbBookStore.NvbCategories.Add(nvbCategory);
            _NvbBookStore.SaveChanges();
            return RedirectToAction("NvbIndex");
        }
    }
}