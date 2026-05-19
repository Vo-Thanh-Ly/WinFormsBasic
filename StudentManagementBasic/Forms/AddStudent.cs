////namespace StudentManagementBasic.Forms
////{
////    public partial class AddStudent : Form
////    {
////        public AddStudent()
////        {
////            InitializeComponent();
////        }
////    }
////}

//using Microsoft.EntityFrameworkCore;
//using StudentManagementBasic.Data;
//using StudentManagementBasic.Models;
//using System;
//using System.Linq;
//using System.Windows.Forms;

//namespace StudentManagementBasic.Forms
//{
//    public partial class AddStudent : Form
//    {
//        private readonly AppDbContext _context; // Thay bằng DbContext của bạn
//        private bool isEditMode = false;
//        private SinhVien existingStudent;

//        public AddStudent()
//        {
//            InitializeComponent();
//            _context = new AppDbContext(); // Khởi tạo context
//            SetupEvents();
//        }

//        // Constructor cho chế độ sửa
//        public AddStudent(SinhVien student) : this()
//        {
//            isEditMode = true;
//            existingStudent = student;
//            LoadStudentData();
//            this.Text = "Sửa thông tin sinh viên";
//            btnSave.Text = "Cập nhật";
//            txtMaSV.ReadOnly = true;
//            txtMaSV.BackColor = System.Drawing.Color.LightGray;
//        }

//        private void SetupEvents()
//        {
//            btnSave.Click += BtnSave_Click;
//            btnClear.Click += BtnClear_Click;
//            btnCancel.Click += BtnCancel_Click;

//            // Validation events
//            txtMaSV.Leave += TxtMaSV_Leave;
//            txtEmail.Leave += TxtEmail_Leave;
//            txtSoDienThoai.Leave += TxtSoDienThoai_Leave;
//        }

//        private void LoadStudentData()
//        {
//            if (existingStudent != null)
//            {
//                txtMaSV.Text = existingStudent.MaSV;
//                txtHoTen.Text = existingStudent.HoTen;
//                dtpNgaySinh.Value = existingStudent.NgaySinh;
//                cboGioiTinh.SelectedItem = existingStudent.GioiTinh;
//                txtDiaChi.Text = existingStudent.DiaChi;
//                txtSoDienThoai.Text = existingStudent.SoDienThoai;
//                txtEmail.Text = existingStudent.Email;
//                txtMaLop.Text = existingStudent.MaLop;
//                nudNamNhapHoc.Value = existingStudent.NamNhapHoc;
//                chkTrangThai.Checked = existingStudent.TrangThai;
//            }
//        }

//        private void BtnSave_Click(object sender, EventArgs e)
//        {
//            //    if (!ValidateInput())
//            //        return;

//            //    try
//            //    {
//            //        if (isEditMode)
//            //        {
//            //            UpdateStudent();
//            //            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
//            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
//            //        }
//            //        else
//            //        {
//            //            AddNewStudent();
//            //            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
//            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
//            //            ClearForm();
//            //        }

//            //        this.DialogResult = DialogResult.OK;
//            //        this.Close();
//            //    }
//            //    catch (DbUpdateException ex)
//            //    {
//            //        MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.InnerException?.Message ?? ex.Message}",
//            //            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            //    }
//            //    catch (Exception ex)
//            //    {
//            //        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
//            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
//            //    }

//            // Tạo đối tượng sinh viên từ dữ liệu nhập
//            AddedStudent = new SinhVien
//            {
//                MaSV = txtMaSV.Text,
//                HoTen = txtHoTen.Text,
//                NgaySinh = dtpNgaySinh.Value,
//                GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
//                DiaChi = txtDiaChi.Text,
//                SoDienThoai = txtSoDienThoai.Text,
//                Email = txtEmail.Text,
//                MaLop = txtMaLop.Text,
//                NamNhapHoc = (int)nudNamNhapHoc.Value,
//                TrangThai = chkTrangThai.Checked
//            };

//            // Set DialogResult = OK để form cha biết là thành công
//            this.DialogResult = DialogResult.OK;
//            this.Close(); // Đóng form con

//        }

//        private void AddNewStudent()
//        {
//            var newStudent = new SinhVien
//            {
//                MaSV = txtMaSV.Text.Trim(),
//                HoTen = txtHoTen.Text.Trim(),
//                NgaySinh = dtpNgaySinh.Value,
//                GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
//                DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? null : txtDiaChi.Text.Trim(),
//                SoDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim(),
//                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
//                MaLop = string.IsNullOrWhiteSpace(txtMaLop.Text) ? null : txtMaLop.Text.Trim(),
//                NamNhapHoc = (int)nudNamNhapHoc.Value,
//                TrangThai = chkTrangThai.Checked
//            };

//            _context.SinhViens.Add(newStudent);
//            _context.SaveChanges();
//        }

//        private void UpdateStudent()
//        {
//            if (existingStudent != null)
//            {
//                existingStudent.HoTen = txtHoTen.Text.Trim();
//                existingStudent.NgaySinh = dtpNgaySinh.Value;
//                existingStudent.GioiTinh = cboGioiTinh.SelectedItem?.ToString();
//                existingStudent.DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? null : txtDiaChi.Text.Trim();
//                existingStudent.SoDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim();
//                existingStudent.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
//                existingStudent.MaLop = string.IsNullOrWhiteSpace(txtMaLop.Text) ? null : txtMaLop.Text.Trim();
//                existingStudent.NamNhapHoc = (int)nudNamNhapHoc.Value;
//                existingStudent.TrangThai = chkTrangThai.Checked;

//                _context.Entry(existingStudent).State = EntityState.Modified;
//                _context.SaveChanges();
//            }
//        }

//        private bool ValidateInput()
//        {
//            // Validate Mã SV
//            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
//            {
//                errorProvider.SetError(txtMaSV, "Mã sinh viên không được để trống!");
//                txtMaSV.Focus();
//                return false;
//            }
//            errorProvider.Clear();

//            // Validate Họ tên
//            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
//            {
//                errorProvider.SetError(txtHoTen, "Họ tên không được để trống!");
//                txtHoTen.Focus();
//                return false;
//            }
//            if (txtHoTen.Text.Length > 100)
//            {
//                errorProvider.SetError(txtHoTen, "Họ tên không quá 100 ký tự!");
//                txtHoTen.Focus();
//                return false;
//            }
//            errorProvider.Clear();

//            // Validate Ngày sinh
//            if (dtpNgaySinh.Value > DateTime.Now.AddYears(-15))
//            {
//                MessageBox.Show("Sinh viên phải từ 15 tuổi trở lên!", "Cảnh báo",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            // Validate Giới tính
//            if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
//            {
//                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                cboGioiTinh.Focus();
//                return false;
//            }

//            // Validate Email (nếu có)
//            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
//            {
//                try
//                {
//                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
//                    if (addr.Address != txtEmail.Text.Trim())
//                    {
//                        throw new Exception();
//                    }
//                }
//                catch
//                {
//                    errorProvider.SetError(txtEmail, "Email không hợp lệ!");
//                    txtEmail.Focus();
//                    return false;
//                }
//            }
//            errorProvider.Clear();

//            // Validate Số điện thoại (nếu có)
//            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
//            {
//                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^[0-9]{10,15}$"))
//                {
//                    errorProvider.SetError(txtSoDienThoai, "Số điện thoại chỉ chứa số và từ 10-15 chữ số!");
//                    txtSoDienThoai.Focus();
//                    return false;
//                }
//            }
//            errorProvider.Clear();

//            // Validate Năm nhập học
//            if (nudNamNhapHoc.Value < 2000 || nudNamNhapHoc.Value > 2100)
//            {
//                MessageBox.Show("Năm nhập học không hợp lệ (2000-2100)!", "Cảnh báo",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            // Kiểm tra Mã SV đã tồn tại (chỉ khi thêm mới)
//            if (!isEditMode)
//            {
//                if (_context.SinhViens.Any(s => s.MaSV == txtMaSV.Text.Trim()))
//                {
//                    errorProvider.SetError(txtMaSV, "Mã sinh viên đã tồn tại trong hệ thống!");
//                    txtMaSV.Focus();
//                    return false;
//                }
//            }

//            return true;
//        }

//        private void ClearForm()
//        {
//            txtMaSV.Clear();
//            txtHoTen.Clear();
//            dtpNgaySinh.Value = new DateTime(DateTime.Now.Year - 18, 1, 1);
//            cboGioiTinh.SelectedIndex = 0;
//            txtDiaChi.Clear();
//            txtSoDienThoai.Clear();
//            txtEmail.Clear();
//            txtMaLop.Clear();
//            nudNamNhapHoc.Value = DateTime.Now.Year;
//            chkTrangThai.Checked = true;
//            errorProvider.Clear();
//            txtMaSV.Focus();
//        }

//        private void BtnClear_Click(object sender, EventArgs e)
//        {
//            if (isEditMode)
//            {
//                if (MessageBox.Show("Bạn có muốn reset thông tin về trạng thái ban đầu?",
//                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                {
//                    LoadStudentData();
//                }
//            }
//            else
//            {
//                ClearForm();
//            }
//        }

//        private void BtnCancel_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("Bạn có muốn thoát? Dữ liệu chưa lưu sẽ bị mất.",
//                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                this.DialogResult = DialogResult.Cancel;
//                this.Close();
//            }
//        }

//        private void TxtMaSV_Leave(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrWhiteSpace(txtMaSV.Text) && !isEditMode)
//            {
//                if (_context.SinhViens.Any(s => s.MaSV == txtMaSV.Text.Trim()))
//                {
//                    errorProvider.SetError(txtMaSV, "Mã sinh viên đã tồn tại!");
//                }
//                else
//                {
//                    errorProvider.Clear();
//                }
//            }
//        }

//        private void TxtEmail_Leave(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
//            {
//                try
//                {
//                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
//                    if (addr.Address != txtEmail.Text.Trim())
//                    {
//                        errorProvider.SetError(txtEmail, "Email không hợp lệ!");
//                    }
//                    else
//                    {
//                        errorProvider.Clear();
//                    }
//                }
//                catch
//                {
//                    errorProvider.SetError(txtEmail, "Email không hợp lệ!");
//                }
//            }
//        }

//        private void TxtSoDienThoai_Leave(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
//            {
//                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^[0-9]{10,15}$"))
//                {
//                    errorProvider.SetError(txtSoDienThoai, "Số điện thoại không hợp lệ!");
//                }
//                else
//                {
//                    errorProvider.Clear();
//                }
//            }
//        }

//    }
//}

using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Data;
using StudentManagementBasic.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementBasic.Forms
{
    public partial class AddStudent : Form
    {
        private readonly AppDbContext _context;
        private bool isEditMode = false;
        private SinhVien existingStudent;

        // Khai báo property để lưu kết quả trả về (Cách 3)
        public SinhVien AddedStudent { get; private set; }

        public AddStudent()
        {
            InitializeComponent();
            _context = new AppDbContext();
            SetupEvents();
        }

        // Constructor cho chế độ sửa
        public AddStudent(SinhVien student) : this()
        {
            isEditMode = true;
            existingStudent = student;
            LoadStudentData();
            this.Text = "Sửa thông tin sinh viên";
            btnSave.Text = "Cập nhật";
            txtMaSV.ReadOnly = true;
            txtMaSV.BackColor = System.Drawing.Color.LightGray;
        }

        private void SetupEvents()
        {
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;
            btnCancel.Click += BtnCancel_Click;

            // Validation events
            txtMaSV.Leave += TxtMaSV_Leave;
            txtEmail.Leave += TxtEmail_Leave;
            txtSoDienThoai.Leave += TxtSoDienThoai_Leave;
        }

        private void LoadStudentData()
        {
            if (existingStudent != null)
            {
                txtMaSV.Text = existingStudent.MaSV;
                txtHoTen.Text = existingStudent.HoTen;
                dtpNgaySinh.Value = existingStudent.NgaySinh;
                cboGioiTinh.SelectedItem = existingStudent.GioiTinh;
                txtDiaChi.Text = existingStudent.DiaChi;
                txtSoDienThoai.Text = existingStudent.SoDienThoai;
                txtEmail.Text = existingStudent.Email;
                txtMaLop.Text = existingStudent.MaLop;
                nudNamNhapHoc.Value = existingStudent.NamNhapHoc;
                chkTrangThai.Checked = existingStudent.TrangThai;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu trước khi lưu
            if (!ValidateInput())
                return;

            try
            {
                if (isEditMode)
                {
                    // Chế độ sửa: Cập nhật trực tiếp vào database
                    UpdateStudent();
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gán dữ liệu đã sửa vào property
                    AddedStudent = existingStudent;
                }
                else
                {
                    // Chế độ thêm mới: Tạo đối tượng sinh viên từ dữ liệu nhập
                    AddedStudent = new SinhVien
                    {
                        MaSV = txtMaSV.Text.Trim(),
                        HoTen = txtHoTen.Text.Trim(),
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                        DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? null : txtDiaChi.Text.Trim(),
                        SoDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim(),
                        Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                        MaLop = string.IsNullOrWhiteSpace(txtMaLop.Text) ? null : txtMaLop.Text.Trim(),
                        NamNhapHoc = (int)nudNamNhapHoc.Value,
                        TrangThai = chkTrangThai.Checked
                    };

                    // Lưu vào database
                    AddNewStudent();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Set DialogResult = OK để form cha biết là thành công
                this.DialogResult = DialogResult.OK;
                this.Close(); // Đóng form con
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu: {ex.InnerException?.Message ?? ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewStudent()
        {
            _context.SinhViens.Add(AddedStudent);
            _context.SaveChanges();
        }

        private void UpdateStudent()
        {
            if (existingStudent != null)
            {
                existingStudent.HoTen = txtHoTen.Text.Trim();
                existingStudent.NgaySinh = dtpNgaySinh.Value;
                existingStudent.GioiTinh = cboGioiTinh.SelectedItem?.ToString();
                existingStudent.DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? null : txtDiaChi.Text.Trim();
                existingStudent.SoDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim();
                existingStudent.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                existingStudent.MaLop = string.IsNullOrWhiteSpace(txtMaLop.Text) ? null : txtMaLop.Text.Trim();
                existingStudent.NamNhapHoc = (int)nudNamNhapHoc.Value;
                existingStudent.TrangThai = chkTrangThai.Checked;

                _context.Entry(existingStudent).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        private bool ValidateInput()
        {
            // Validate Mã SV
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider.SetError(txtMaSV, "Mã sinh viên không được để trống!");
                txtMaSV.Focus();
                return false;
            }
            errorProvider.Clear();

            // Validate Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.Focus();
                return false;
            }
            if (txtHoTen.Text.Length > 100)
            {
                errorProvider.SetError(txtHoTen, "Họ tên không quá 100 ký tự!");
                txtHoTen.Focus();
                return false;
            }
            errorProvider.Clear();

            // Validate Ngày sinh
            if (dtpNgaySinh.Value > DateTime.Now.AddYears(-15))
            {
                MessageBox.Show("Sinh viên phải từ 15 tuổi trở lên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Giới tính
            if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return false;
            }

            // Validate Email (nếu có)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                    if (addr.Address != txtEmail.Text.Trim())
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    errorProvider.SetError(txtEmail, "Email không hợp lệ!");
                    txtEmail.Focus();
                    return false;
                }
            }
            errorProvider.Clear();

            // Validate Số điện thoại (nếu có)
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^[0-9]{10,15}$"))
                {
                    errorProvider.SetError(txtSoDienThoai, "Số điện thoại chỉ chứa số và từ 10-15 chữ số!");
                    txtSoDienThoai.Focus();
                    return false;
                }
            }
            errorProvider.Clear();

            // Validate Năm nhập học
            if (nudNamNhapHoc.Value < 2000 || nudNamNhapHoc.Value > 2100)
            {
                MessageBox.Show("Năm nhập học không hợp lệ (2000-2100)!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Mã SV đã tồn tại (chỉ khi thêm mới)
            if (!isEditMode)
            {
                if (_context.SinhViens.Any(s => s.MaSV == txtMaSV.Text.Trim()))
                {
                    errorProvider.SetError(txtMaSV, "Mã sinh viên đã tồn tại trong hệ thống!");
                    txtMaSV.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = new DateTime(DateTime.Now.Year - 18, 1, 1);
            cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtMaLop.Clear();
            nudNamNhapHoc.Value = DateTime.Now.Year;
            chkTrangThai.Checked = true;
            errorProvider.Clear();
            txtMaSV.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (MessageBox.Show("Bạn có muốn reset thông tin về trạng thái ban đầu?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoadStudentData();
                }
            }
            else
            {
                ClearForm();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát? Dữ liệu chưa lưu sẽ bị mất.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void TxtMaSV_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSV.Text) && !isEditMode)
            {
                if (_context.SinhViens.Any(s => s.MaSV == txtMaSV.Text.Trim()))
                {
                    errorProvider.SetError(txtMaSV, "Mã sinh viên đã tồn tại!");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                    if (addr.Address != txtEmail.Text.Trim())
                    {
                        errorProvider.SetError(txtEmail, "Email không hợp lệ!");
                    }
                    else
                    {
                        errorProvider.Clear();
                    }
                }
                catch
                {
                    errorProvider.SetError(txtEmail, "Email không hợp lệ!");
                }
            }
        }

        private void TxtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSoDienThoai.Text, @"^[0-9]{10,15}$"))
                {
                    errorProvider.SetError(txtSoDienThoai, "Số điện thoại không hợp lệ!");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
        }
    }
}
