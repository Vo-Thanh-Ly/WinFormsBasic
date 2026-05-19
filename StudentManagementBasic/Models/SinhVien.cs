using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementBasic.Models
{
    [Table("SinhVien")] // Đặt tên bảng tiếng Việt
    public class SinhVien
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã sinh viên")]
        public string MaSV { get; set; } // Ví dụ: SV001, SV002

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100, ErrorMessage = "Họ tên không quá 100 ký tự")]
        [Display(Name = "Họ và tên")]
        public string HoTen { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; } // "Nam", "Nữ", "Khác"

        [StringLength(200)]
        [Display(Name = "Địa chỉ")]
        public string? DiaChi { get; set; }

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string? SoDienThoai { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã lớp")]
        public string? MaLop { get; set; }

        [Display(Name = "Năm nhập học")]
        [Range(2000, 2100, ErrorMessage = "Năm nhập học không hợp lệ")]
        public int NamNhapHoc { get; set; }

        [Display(Name = "Trạng thái")]
        public bool TrangThai { get; set; } = true; // true: Đang học, false: Đã nghỉ

        // Navigation properties (Quan hệ)
        [ForeignKey("MaLop")]
        public virtual Lop? Lop { get; set; }

        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; } = new HashSet<DangKyHocPhan>();

        public virtual ICollection<DiemSo> DiemSos { get; set; } = new HashSet<DiemSo>();
    }
}