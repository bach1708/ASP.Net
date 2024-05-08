using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace NvbLesson04Online.Controllers
{
    /// <summary>
    /// Author: Nông Văn Bách
    /// Class: K22CNT2
    /// </summary>
    public class NvbStudentController : Controller
    {
        // GET: NvbStudent
        public ActionResult Index()
        {
            // Truyền dữ liệu từ Controller -> View
            ViewBag.fullname = "Nông Văn Bách";
            ViewData["Birthday"] = "17/08/2001";
            TempData["Phone"] = "0387387894";
            return View();
        }
        public ActionResult Details()
        {
            string nvbStr = "";
            nvbStr += " <h3> Họ và tên: Nông Văn Bách</h3>";
            nvbStr += "<p> Mã số: 2210900003";
            nvbStr += "<p> Địa chỉ mail: kunkontkls@gmail.com";

            ViewBag.Details = nvbStr;

            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }
        //HTMLHelper
        // GET: NvbStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["MaSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string nvbStr = "<h3>" + fullname + "</h3>";
            nvbStr += "<p>" + masv;
            nvbStr += "<p>" + TaiKhoan;
            nvbStr += "<p>" + MatKhau;

            ViewBag.info = nvbStr;

            return View("Ketqua");
        }
    }
}