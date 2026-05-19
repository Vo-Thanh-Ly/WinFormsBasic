using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBasic.ViewModel
{
    using System.ComponentModel;

    namespace StudentManagementBasic.ViewModels
    {
        public class SinhVienViewModel
        {

            [DisplayName("Mã sinh viên")]
            public string MaSV { get; set; }

            [DisplayName("Họ tên")]
            public string HoTen { get; set; }

            [DisplayName("Giới tính")]
            public string GioiTinh { get; set; }

            [DisplayName("Lớp")]
            public string Lop { get; set; }

            [DisplayName("Ngày sinh")]
            public string NgaySinh { get; set; }
        }
    }
}
