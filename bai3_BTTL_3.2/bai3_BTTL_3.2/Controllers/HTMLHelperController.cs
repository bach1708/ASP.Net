using bai3_BTTL_3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai3_BTTL_3._2.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTML_Helper_Methods
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<Country>() {
            new Country(){ID="0",Name="-- Loại Hình Doanh Nghiệp --"},
            new Country(){ID="DVSNNN",Name="Đơn Vị Sự Nghiệp Nhà Nước"},
            new Country(){ID="TNHH",Name="Công ty trách nhiệm hữu hạn (TNHH)"},
            new Country(){ID="CTCP",Name="Công ty cổ phần "},
            new Country(){ID="CTHD",Name="Công ty hợp danh "},
            new Country(){ID="DNTN",Name="Doanh nghiệp tư nhân "},

            };
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            
            TempData["Gender"] = Request["Gender"].ToString();
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];

            if (Request["Reading"].ToString().Contains("true")) fvr
            += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true")) fvr +=
            "Shopping ,";
            if (Request["Sport"].ToString().Contains("true")) fvr += "Sport,";

            TempData["Favourist"] = fvr;

            return View();
        }
    }
}