using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace bai2_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //Action trả về một View là một trang html và nó có thể truyền tham số hoặc model
        public ViewResult TestViewResult()
        {
            return View();
        }
        //Action trả về một PartialViewResult
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        //Action trả về một View trống (null)
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        // Action đáp ứng việc chuyển trực tiếp tới một view khác
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");

        }
        //Action trả về một kết quả dạng Json
        public JsonResult TestJsonResult()
        {
            List< bai2_1.Models.Student> listStudent = new List<bai2_1.Models.Student>();
            listStudent.Add(new bai2_1.Models.Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311L"
            });
            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }
        //Action trả về một view là JavaScript
        public JavaScriptResult TestJavaScriptResult()
        {
            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?:[w -] +.) * w[w -]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ i if (btloc.test(mail)) { kq = true;  else {alert(“Email address invalid”);kq = false;} return kq; }";
            return JavaScript(js);
        }
        //Acion tra về một ContentResult dữ liệu là dạng văn bản
        public ContentResult TestContentResult()
        {
            XElement content = new XElement("Students",
            new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
            new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
            new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
            new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
            new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")));
            return Content(content.ToString(), "text/xml", Encoding.UTF8);
        }
        // Cả ba kiểu FileContentResult,FileStreamResult,FilePathResult đều cho phép trình duyệt mở hộp thoại lưu file và tải file về
        // phương thức trả về có 3 tham số
        // tham số thứ nhất đối với kiểu FileContentResult là một mảng bytecủa file
        // tham số thứ nhất đối với kiểu FileStreamResult là một FileStream
        // tham sô thứ nhất đổi với kiểu PathFileResult là một đường dẫnfile
        // tham số thứ hai chỉ ra loại định dạng của file
        // tham số thứ ba tên file mà trình duyệt sẽ tải về
        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes =
            System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Chúng Ta Của Hiện Tại.mp3"));
            string fileName = "Chúng Ta Của Hiện Tại.mp3";
            //return File(fileBytes,System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "mp3", fileName);
        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/vv.docx");
            string fileName = "vv.docx";
            return File(new FileStream(pathFile, FileMode.Open), "text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vv.docx");
            string fileName = "vv.docx";
            return File(pathFile, "text/doc", fileName);
        }
    }
}