using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    [Table("DangKyHocPhan")]
    public class DangKyHocPhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDK { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã sinh viên")]
        public string MaSV { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã lớp học phần")]
        public string MaLHP { get; set; }

        [Display(Name = "Ngày đăng ký")]
        [DataType(DataType.DateTime)]
        public DateTime NgayDangKy { get; set; } = DateTime.Now;

        [Display(Name = "Trạng thái")]
        [StringLength(20)]
        public string TrangThai { get; set; } = "Đã đăng ký"; // Đã đăng ký, Đã hủy, Đã hoàn thành

        [Display(Name = "Điểm quá trình")]
        [Range(0, 10)]
        public double? DiemQuaTrinh { get; set; }

        [Display(Name = "Điểm cuối kỳ")]
        [Range(0, 10)]
        public double? DiemCuoiKy { get; set; }

        [Display(Name = "Điểm tổng kết")]
        [Range(0, 10)]
        public double? DiemTongKet { get; set; }

        [Display(Name = "Kết quả")]
        [StringLength(20)]
        public string? KetQua { get; set; } // Đạt, Không đạt

        // Navigation properties
        [ForeignKey("MaSV")]
        public virtual SinhVien? SinhVien { get; set; }

        [ForeignKey("MaLHP")]
        public virtual LopHocPhan? LopHocPhan { get; set; }
    }
}