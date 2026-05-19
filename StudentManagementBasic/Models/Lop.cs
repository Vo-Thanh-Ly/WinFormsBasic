using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementBasic.Models
{
    [Table("Lop")]
    public class Lop
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã lớp")]
        public string MaLop { get; set; } // Ví dụ: CNTT01

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        [StringLength(100)]
        [Display(Name = "Tên lớp")]
        public string TenLop { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã khoa")]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Khóa học")]
        public string KhoaHoc { get; set; } // K42, K43,...

        [Display(Name = "Sĩ số")]
        [Range(0, 200)]
        public int SiSo { get; set; } = 0;

        // Navigation properties
        [ForeignKey("MaKhoa")]
        public virtual Khoa? Khoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; } = new HashSet<SinhVien>();
    }
}
