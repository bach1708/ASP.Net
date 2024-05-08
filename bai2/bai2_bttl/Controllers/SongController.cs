using bai2_bttl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai2_bttl.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        private static List<Song> songs = new List<Song>
        {
            new Song { Id = 1, Title = "Chúng Ta Của Hiện Tại", FilePath = "/Content/Chúng Ta Của Hiện Tại.mp3" },
            new Song { Id = 2, Title = "CHÚNG TA CỦA TƯƠNG LAI  OFFICIAL MUSIC VIDEO", FilePath = "/Content/CHÚNG TA CỦA TƯƠNG LAI  OFFICIAL MUSIC VIDEO.mp3" },
            new Song { Id = 3, Title = "Không Quan Tâm  Chi Dân  Official Music Video", FilePath = "/Content/Không Quan Tâm  Chi Dân  Official Music Video.mp3" },
            new Song { Id = 4, Title = "Official MV Gấp Đôi Yêu Thương  Tuấn Hưng", FilePath = "/Content/Official MV Gấp Đôi Yêu Thương  Tuấn Hưng.mp3" },
            new Song { Id = 5, Title = "SỰ THẬT SAU MỘT LỜI HỨA  CHI DÂN MV OFFICIAL", FilePath = "/Content/SỰ THẬT SAU MỘT LỜI HỨA  CHI DÂN MV OFFICIAL.mp3" },
            new Song { Id = 6, Title = "Tìm Lại Bầu Trời  Tuấn Hưng", FilePath = "/Content/Tìm Lại Bầu Trời  Tuấn Hưng.mp3" }
        };
        // GET: TDTD_Home
        public ActionResult Index()
        {
            return View(songs);
        }
        public ActionResult Detail(int id)
        {
            var song = songs.Find(s => s.Id == id);
            return View(song);
        }

        public ActionResult Download(int id)
        {
            var song = songs.Find(s => s.Id == id);
            if (song != null)
            {
                return File(song.FilePath, "audio/mpeg", song.Title + ".mp3");
            }
            return HttpNotFound();
        }
    }
}