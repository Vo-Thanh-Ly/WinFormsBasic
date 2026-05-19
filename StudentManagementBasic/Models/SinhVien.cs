using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementBasic.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Họ tên sinh viên")]
        [Required(ErrorMessage = "Họ tên không được để trống")]
        [MaxLength(100)]
        public string HoTen { get; set; }

        [MaxLength(10)]
        [DisplayName("Mã sinh viên")]
        public string MaSinhVien { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? NgaySinh { get; set; }

        [MaxLength(200)]
        [DisplayName("Địa chỉ")]
        public string Email { get; set; }

        [MaxLength(15)]
        [DisplayName("Số điện thoại")]
        public string SoDienThoai { get; set; }

        [DisplayName("Giới tính")]
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
    }
}