using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvbLesson08CF.Models
{
    /// <summary>
    /// Tạo ra cấu trúc bảng book
    /// </summary>
    public class NvbBook
    {
        [Key]
        public int NvbBookId { get; set; }
        public string NvbTitle { get; set; }
        public string NvbAuthor { get; set; }
        public int NvbYear { get; set; }
        public string NvbPublisher { get; set; }
        public string NvbPicture { get; set; }
        public int NvbCategoryId { get; set; }

        // thuộc tính quan hệ
        public virtual NvbCategory NvbCategory { get; set; }
    }
}