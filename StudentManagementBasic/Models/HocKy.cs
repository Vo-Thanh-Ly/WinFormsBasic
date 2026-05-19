using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementBasic.Models
{
    [Table("HocKy")]
    public class HocKy
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã học kỳ")]
        public string MaHK { get; set; } // Ví dụ: HK20241 (Học kỳ 1 năm 2024)

        [Required(ErrorMessage = "Tên học kỳ không được để trống")]
        [StringLength(100)]
        [Display(Name = "Tên học kỳ")]
        public string TenHK { get; set; } // Học kỳ 1 - Năm học 2024-2025

        [Display(Name = "Năm học")]
        [Required]
        [StringLength(10)]
        public string NamHoc { get; set; } // 2024-2025

        [Display(Name = "Học kỳ thứ")]
        [Range(1, 3, ErrorMessage = "Học kỳ từ 1 đến 3")]
        public int HocKyThu { get; set; } // 1, 2 hoặc 3 (hè)

        [Display(Name = "Ngày bắt đầu")]
        [DataType(DataType.Date)]
        public DateTime NgayBatDau { get; set; }

        [Display(Name = "Ngày kết thúc")]
        [DataType(DataType.Date)]
        public DateTime NgayKetThuc { get; set; }

        // Navigation properties
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new HashSet<LopHocPhan>();
    }
}