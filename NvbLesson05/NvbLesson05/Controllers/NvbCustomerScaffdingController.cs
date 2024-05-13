using NvbLesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NvbLesson05.Controllers
{
    public class NvbCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<NvbCustomer> listCustomer = new List<NvbCustomer>()
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

    // GET: NvbCustomerScaffding
    //listcustomer
    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult Nvbcreate()
        {
            var model =new NvbCustomer();
            return View();
        }
        [HttpPost]
        public ActionResult Nvbcreate(NvbCustomer model)
        {
            //Thêm mới đối tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);
            //return View();
            // Chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult NvbEdit( int id )
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}