using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    [Table("LopHocPhan")]
    public class LopHocPhan
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã lớp học phần")]
        public string MaLHP { get; set; } // Ví dụ: LHP001

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã môn học")]
        public string MaMH { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGV { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã học kỳ")]
        public string MaHK { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Phòng học")]
        public string PhongHoc { get; set; }

        [Display(Name = "Sĩ số tối đa")]
        [Range(10, 200)]
        public int SiSoToiDa { get; set; } = 60;

        [Display(Name = "Sĩ số hiện tại")]
        [Range(0, 200)]
        public int SiSoHienTai { get; set; } = 0;

        // Navigation properties
        [ForeignKey("MaMH")]
        public virtual MonHoc? MonHoc { get; set; }

        [ForeignKey("MaGV")]
        public virtual GiangVien? GiangVien { get; set; }

        [ForeignKey("MaHK")]
        public virtual HocKy? HocKy { get; set; }

        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; } = new HashSet<DangKyHocPhan>();
    }
}