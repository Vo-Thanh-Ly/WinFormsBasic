using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    [Table("Khoa")]
    public class Khoa
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã khoa")]
        public string MaKhoa { get; set; } // Ví dụ: CNTT, KINHTE

        [Required(ErrorMessage = "Tên khoa không được để trống")]
        [StringLength(200)]
        [Display(Name = "Tên khoa")]
        public string TenKhoa { get; set; }

        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string? SoDienThoai { get; set; }

        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        // Navigation properties
        public virtual ICollection<Lop> Lops { get; set; } = new HashSet<Lop>();
        public virtual ICollection<GiangVien> GiangViens { get; set; } = new HashSet<GiangVien>();
    }
}