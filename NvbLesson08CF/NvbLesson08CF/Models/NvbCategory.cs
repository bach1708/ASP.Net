using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvbLesson08CF.Models
{
    /// <summary>
    /// Tạo cấu trúc bảng dữ liệu
    /// </summary>
    public class NvbCategory
    {
        [Key]
        public int NvbCategoryId { get; set; }
        public string NvbCategoryName { get; set; }
        // thuộc tinh quan hệ
        public virtual ICollection<NvbBook> NvbBooks { get; set; }
    }
}