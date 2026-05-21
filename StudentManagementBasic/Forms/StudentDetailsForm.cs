using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Data;
using StudentManagementBasic.Models;
using StudentManagementBasic.ViewModel.StudentManagementBasic.ViewModels;

namespace StudentManagementBasic.Forms
{
    public partial class StudentDetailsForm : Form
    {
        private readonly AppDbContext _context;
        private string _studentId;
        private SinhVien _student;

        // Property để form cha biết có thay đổi không
        public bool DataChanged { get; private set; }

        // Constructor nhận ID
        public StudentDetailsForm(string studentId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _studentId = studentId;
            SetupEvents();
            LoadStudentData();
        }

        // Constructor nhận ViewModel
        public StudentDetailsForm(SinhVienViewModel studentVM) : this(studentVM.MaSV)
        {
        }

        // Constructor nhận Model
        public StudentDetailsForm(SinhVien student) : this(student.MaSV)
        {
        }

        private void SetupEvents()
        {
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClose.Click += BtnClose_Click;
        }

        private void LoadStudentData()
        {
            try
            {
                _student = _context.SinhViens
                    .Include(s => s.Lop)
                    .FirstOrDefault(s => s.MaSV == _studentId);

                if (_student != null)
                {
                    DisplayStudentInfo();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sinh viên có mã {_studentId}!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayStudentInfo()
        {
            lblMaSVValue.Text = _student.MaSV;
            lblHoTenValue.Text = _student.HoTen;
            lblNgaySinhValue.Text = _student.NgaySinh.ToString("dd/MM/yyyy");
            lblGioiTinhValue.Text = _student.GioiTinh;
            lblDiaChiValue.Text = string.IsNullOrEmpty(_student.DiaChi) ? "Chưa cập nhật" : _student.DiaChi;
            lblSoDienThoaiValue.Text = string.IsNullOrEmpty(_student.SoDienThoai) ? "Chưa cập nhật" : _student.SoDienThoai;
            lblEmailValue.Text = string.IsNullOrEmpty(_student.Email) ? "Chưa cập nhật" : _student.Email;
            lblMaLopValue.Text = string.IsNullOrEmpty(_student.MaLop) ? "Chưa xếp lớp" : $"{_student.MaLop} - {_student.Lop?.TenLop}";
            lblNamNhapHocValue.Text = _student.NamNhapHoc.ToString();
            lblTrangThaiValue.Text = _student.TrangThai ? "Đang học" : "Đã nghỉ";
            lblTrangThaiValue.ForeColor = _student.TrangThai ? Color.Green : Color.Red;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Mở form cập nhật
            using (AddStudent editForm = new AddStudent(_student))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DataChanged = true;
                    // Tải lại dữ liệu mới
                    LoadStudentData();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sinh viên {_student.HoTen} (Mã: {_student.MaSV})?\n\nHành động này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _context.SinhViens.Remove(_student);
                    _context.SaveChanges();

                    DataChanged = true;
                    MessageBox.Show($"Đã xóa sinh viên {_student.HoTen} thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Không thể xóa vì sinh viên đã có dữ liệu liên quan: {ex.InnerException?.Message ?? ex.Message}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DataChanged ? DialogResult.OK : DialogResult.Cancel;
            this.Close();
        }


    }
}
