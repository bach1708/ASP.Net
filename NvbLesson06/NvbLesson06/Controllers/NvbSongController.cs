using NvbLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace NvbLesson06.Controllers
{
    public class NvbSongController : Controller
    {
        private static List<NvbSong> nvbSongs = new List<NvbSong>()
        {
            new NvbSong{Id=221090003, NvbTitle="Nông Văn Bách", NvbAuthor="K22CNT2", NvbArtist="Bách", NvbYearRelease=2020},
            new NvbSong{Id=123, NvbTitle="Nong Van Bach", NvbAuthor="K22CNT2", NvbArtist="Bách", NvbYearRelease=2021},
        };
        // GET: NvbSong
        public ActionResult NvbIndex()
        {
            return View(nvbSongs);
        }
        //Get: Nvb Create
        public ActionResult NvbCreate()
        {  
            var nvbSong = new NvbSong();
            return View(nvbSong); 
        }
        //POST: NvbCreate
        [HttpPost]
        public ActionResult NvbCreate(NvbSong nvbSong)
        {
            if(!ModelState.IsValid) //Nếu có lỗi
            {
                return View(nvbSong);
            }
            //Nếu dữ liệu đúng
            nvbSongs.Add(nvbSong);
            return RedirectToAction("NvbIndex");
        }
    }
}