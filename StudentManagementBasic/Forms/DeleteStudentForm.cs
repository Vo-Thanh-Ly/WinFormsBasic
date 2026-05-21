using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Data;
using StudentManagementBasic.Models;

namespace StudentManagementBasic.Forms
{
    public partial class DeleteStudentForm : Form
    {
        private readonly AppDbContext _context;
        private string _studentId;
        private SinhVien _studentToDelete; // ✅ Khai báo, không khởi tạo

        // Property để form cha biết kết quả xóa
        public bool IsDeleted { get; private set; }

        public DeleteStudentForm(string studentId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _studentId = studentId; // ✅ Gán ID TRƯỚC khi dùng
            SetupEvents();
            LoadStudentData(); // ✅ Gọi LoadStudentData SAU khi có ID
        }

        private void SetupEvents()
        {
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void LoadStudentData()
        {
            try
            {
                // ✅ Tìm kiếm sinh viên trong LoadStudentData
                _studentToDelete = _context.SinhViens.Find(_studentId);

                if (_studentToDelete != null)
                {
                    lblMaSVValue.Text = _studentToDelete.MaSV;
                    lblHoTenValue.Text = _studentToDelete.HoTen;
                    lblNgaySinhValue.Text = _studentToDelete.NgaySinh.ToString("dd/MM/yyyy");
                    lblGioiTinhValue.Text = _studentToDelete.GioiTinh;
                    lblDiaChiValue.Text = string.IsNullOrEmpty(_studentToDelete.DiaChi)
                        ? "Chưa cập nhật" : _studentToDelete.DiaChi;
                    lblSoDienThoaiValue.Text = string.IsNullOrEmpty(_studentToDelete.SoDienThoai)
                        ? "Chưa cập nhật" : _studentToDelete.SoDienThoai;
                    lblEmailValue.Text = string.IsNullOrEmpty(_studentToDelete.Email)
                        ? "Chưa cập nhật" : _studentToDelete.Email;
                    lblMaLopValue.Text = string.IsNullOrEmpty(_studentToDelete.MaLop)
                        ? "Chưa xếp lớp" : _studentToDelete.MaLop;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sinh viên có mã {_studentId}!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra _studentToDelete có tồn tại không
                if (_studentToDelete == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên để xóa!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Xác nhận xóa lần nữa
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên {_studentToDelete.HoTen} (Mã: {_studentToDelete.MaSV})?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Thực hiện xóa
                    _context.SinhViens.Remove(_studentToDelete);
                    _context.SaveChanges();

                    IsDeleted = true;
                    MessageBox.Show($"Đã xóa sinh viên {_studentToDelete.HoTen} thành công!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Không thể xóa vì dữ liệu liên quan: {ex.InnerException?.Message ?? ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
