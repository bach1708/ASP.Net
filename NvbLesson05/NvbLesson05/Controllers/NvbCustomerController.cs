using NvbLesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace NvbLesson05.Controllers
{
    public class NvbCustomerController : Controller
    {
        // GET: NvbCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NvbCustomerDetail
        public ActionResult NvBCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new NvbCustomer()
            {
                CustomerID = 1,
                FirstName = "Nông Văn",
                LastName = "Bách",
                Address = "K22CNT2",
                YearOfBirth = 2001
            };
            ViewBag.customer = customer;
            return View();
        }
        //GET: NvbListCustomer
        public ActionResult NvbListcustomer()
        {
            var list = new List<NvbCustomer>()
            {
                new NvbCustomer()
                {
                    CustomerID = 1,
                    FirstName = "Nông Văn",
                    LastName = "Bách",
                    Address = "K22CNT2",
                    YearOfBirth = 2001
                },
                    new NvbCustomer()
                    {
                        CustomerID = 2,
                        FirstName = "Đàm Vĩnh",
                        LastName = "Trinh ",
                        Address = "K22CNT1",
                        YearOfBirth = 2022
                    },
                      new NvbCustomer()
                      {
                          CustomerID = 3,
                          FirstName = "Đàm Vĩnh",
                          LastName = "Trinh 1",
                          Address = "K22CNT1",
                          YearOfBirth = 2022
                      },
                      new NvbCustomer()
                      {
                          CustomerID = 4,
                          FirstName = "Đàm Vĩnh",
                          LastName = "Trinh2",
                          Address = "K22CNT1",
                          YearOfBirth = 2022
                      },
            }; 
            ViewBag.list = list;//đưa dữ liệu ra view bằng đối tượng viewbag
            
            return View(list);

        }
    }
}
    
