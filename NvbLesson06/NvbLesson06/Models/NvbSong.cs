using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvbLesson06.Models
{
    public class NvbSong
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nvb: Hãy nhập tiêu đề bài hát")]
        [DisplayName ("Tiêu đề")]
        public string NvbTitle { get; set; }

        [Required(ErrorMessage ="Nvb: Hãy nhập tác giả bài hát")]
        [DisplayName("Tác Giả")]
        public string NvbAuthor { get; set;}

        [Required(ErrorMessage = "Nvb: Hãy nhập tên nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Nvb: Độ dài trong khoảng [2-50]")]
        [DisplayName("Nghệ sĩ")]
        public string NvbArtist { get; set;}

        [Required(ErrorMessage = "Nvb: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="NVB: Nhập năm xuất bản là 4 ký tự số")]
        [Range(1900,2020,ErrorMessage ="Nvb: Nhập năm trong khoảng[1900-2020]")]
        [DisplayName("Năm xuất bản")]
        public int NvbYearRelease { get; set;}
    }
}