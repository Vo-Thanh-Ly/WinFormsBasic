using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    [Table("DiemSo")]
    public class DiemSo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDiem { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã sinh viên")]
        public string MaSV { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã môn học")]
        public string MaMH { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã học kỳ")]
        public string MaHK { get; set; }

        [Display(Name = "Điểm chuyên cần")]
        [Range(0, 10)]
        public double? DiemChuyenCan { get; set; }

        [Display(Name = "Điểm giữa kỳ")]
        [Range(0, 10)]
        public double? DiemGiuaKy { get; set; }

        [Display(Name = "Điểm cuối kỳ")]
        [Range(0, 10)]
        public double? DiemCuoiKy { get; set; }

        [Display(Name = "Điểm tổng kết")]
        [Range(0, 10)]
        public double? DiemTongKet { get; set; }

        [Display(Name = "Xếp loại")]
        [StringLength(20)]
        public string? XepLoai { get; set; } // Xuất sắc, Giỏi, Khá, Trung bình, Yếu

        // Navigation properties
        [ForeignKey("MaSV")]
        public virtual SinhVien? SinhVien { get; set; }

        [ForeignKey("MaMH")]
        public virtual MonHoc? MonHoc { get; set; }

        [ForeignKey("MaHK")]
        public virtual HocKy? HocKy { get; set; }
    }
}