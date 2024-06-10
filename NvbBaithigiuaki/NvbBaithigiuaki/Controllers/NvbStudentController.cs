using NvbBaithigiuaki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvbBaithigiuaki.Controllers
{
    public class NvbStudentController : Controller
    {
        public static List<NvbStudent> list = new List<NvbStudent>()
        {
        new NvbStudent(){ NvbId = 2210900003 , NvbFullName = "Bach" , NvbEmail = "example@gmail.com", NvbPhone = "0123456789", NvbGender = 0 , NvbAge = 20 },
        new NvbStudent(){ NvbId = 1 , NvbFullName = "Bach" , NvbEmail = "example@gmail.com", NvbPhone = "0123456789", NvbGender = 0 , NvbAge = 20 },
        new NvbStudent(){ NvbId = 1 , NvbFullName = "Bach" , NvbEmail = "example@gmail.com", NvbPhone = "0123456789", NvbGender = 0 , NvbAge = 20 }
        };
        public ActionResult List()
        {
            return View(list);
        }
        public ActionResult Create() 
        { 
            var NvbStudent = new NvbStudent();
            return View(NvbStudent);
        }
        [HttpPost]
        public ActionResult Create(NvbStudent student) 
        {
            if(!ModelState.IsValid) // lỗi
            {
                return View();
            }
            return View(student);
        }
        

    }
}