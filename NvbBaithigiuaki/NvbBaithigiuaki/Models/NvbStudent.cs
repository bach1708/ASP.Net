using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvbBaithigiuaki.Models
{
    public class NvbStudent
    {
        [Key]
        [DisplayName("Nvb:Mã sinh viên")]
        [Required(ErrorMessage ="Nvb: Mã sinh viên không được trống")]
        public uint NvbId { get; set; }

        [DisplayName("Nvb:Họ và tên")]
        [Required(ErrorMessage = "Nvb: Họ và tên không được trống")]
        [StringLength(25,MinimumLength =2,ErrorMessage ="Nvb: Họ tên tối thiểu 2 kí tự tối đa 25 kí tự")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Họ và tên chỉ được chứa các ký tự chữ cái và khoảng trắng.")]
        public string NvbFullName { get; set; }

        [DisplayName("Nvb:Email")]
        [Required(ErrorMessage = "Nvb: Email không được để trống")]
        public string NvbEmail { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Điện thoại phải có 10 ký tự số.")]
        [Display(Name = "Nvb: Điện thoại")]
        public string NvbPhone { get; set; }

        [Required(ErrorMessage = "Tuổi là bắt buộc.")]
        [Range(18, 65, ErrorMessage = "Tuổi phải trong phạm vi 18-65.")]
        [Display(Name = "Nvb: Tuổi")]
        public int NvbAge { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        [RegularExpression(@"^[01]$", ErrorMessage = "Giới tính chỉ có thể là 0 hoặc 1.")]
        [Display(Name = "Nvb: Giới tính")]
        public int NvbGender { get; set; }

    }
}