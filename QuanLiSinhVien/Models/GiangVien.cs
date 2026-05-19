using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    [Table("GiangVien")]
    public class GiangVien
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGV { get; set; } // Ví dụ: GV001

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100)]
        [Display(Name = "Họ và tên")]
        public string HoTen { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã khoa")]
        public string? MaKhoa { get; set; }

        [StringLength(100)]
        [Display(Name = "Học vị")]
        public string? HocVi { get; set; } // Thạc sĩ, Tiến sĩ, Giáo sư...

        [Phone]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string? SoDienThoai { get; set; }

        // Navigation properties
        [ForeignKey("MaKhoa")]
        public virtual Khoa? Khoa { get; set; }

        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; } = new HashSet<LopHocPhan>();
    }
}