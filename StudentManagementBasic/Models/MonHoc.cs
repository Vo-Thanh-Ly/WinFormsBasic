using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementBasic.Models
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã môn học")]
        public string MaMH { get; set; } // Ví dụ: CSDL, OOP

        [Required(ErrorMessage = "Tên môn học không được để trống")]
        [StringLength(200)]
        [Display(Name = "Tên môn học")]
        public string TenMH { get; set; }

        [Range(1, 10, ErrorMessage = "Số tín chỉ từ 1 đến 10")]
        [Display(Name = "Số tín chỉ")]
        public int SoTinChi { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã khoa")]
        public string? MaKhoa { get; set; }

        [Display(Name = "Mô tả")]
        [StringLength(500)]
        public string? MoTa { get; set; }

        // Navigation properties
        [ForeignKey("MaKhoa")]
        public virtual Khoa? Khoa { get; set; }

        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new HashSet<LopHocPhan>();
    }
}