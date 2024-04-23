using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai3_1.NVB.Controllers
{
    public class NVBStudentController : Controller
    {
        // GET: NVBStudent
        public ActionResult Index()
        {
            // dữ liệu từ view data
            ViewData["msg"] = "View Data - Nông Văn Bách";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList() 
        {
            //Sử dụng ViewBag
            //Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Nông Văn Bách";
            //Giá trị là một tập hợp
            string[] names = { "Trần Tiến", "Tạ Hồng", "Diễm Hương", "Vương Định" };
            ViewBag.list = names;
            // GIá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name = "Bach Bach",
                age = "23"
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}