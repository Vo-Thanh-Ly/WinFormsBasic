using Microsoft.EntityFrameworkCore;
using StudentManagementBasic.Data;
using StudentManagementBasic.Models;

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
            SetupComboBoxAutoComplete();
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
                    MessageBox.Show($"Mã SV: {existingStudent.MaSV}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MaLop = GetSelectedMaLop(),
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

        private string GetSelectedMaLop()
        {
            // Trường hợp 1: Chọn từ danh sách (SelectedItem là object Lop)
            if (cboMaLop.SelectedItem is Lop selectedLop)
            {
                return selectedLop.MaLop;
            }

            // Trường hợp 2: Người dùng nhập tay (không chọn từ danh sách)
            string inputText = cboMaLop.Text;
            if (!string.IsNullOrWhiteSpace(inputText))
            {
                // Nếu nhập tay chỉ gõ mã lớp (không có dấu " - ")
                if (!inputText.Contains(" - "))
                {
                    return inputText.Trim();
                }

                // Nếu nhập tay theo định dạng "MaLop - TenLop"
                if (inputText.Contains(" - "))
                {
                    return inputText.Split('-')[0].Trim();
                }
            }

            // Trường hợp 3: Không có gì được chọn hoặc nhập
            return null;
        }

        private void AddNewStudent()
        {
            _context.SinhViens.Add(AddedStudent);
            _context.SaveChanges();
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
            cboMaLop.SelectedItem = null;
            cboMaLop.Text = string.Empty;
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

        private void SetupComboBoxAutoComplete()
        {
            // Cấu hình ComboBox
            cboMaLop.DropDownStyle = ComboBoxStyle.DropDown; // Cho phép gõ
            cboMaLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Gợi ý và tự động thêm
            cboMaLop.AutoCompleteSource = AutoCompleteSource.ListItems; // Lấy từ danh sách có sẵn

            // Đổ dữ liệu ban đầu
            LoadDataToComboBox();
        }

        //private void LoadDataToComboBox()
        //{
        //    cboMaLop.Items.Clear();

        //    List<Lop> lop = _context.Lops.ToList();

        //    if (lop != null && lop.Any()) // Kiểm tra có dữ liệu không
        //    {
        //        // Thêm từng đối tượng Lop vào ComboBox
        //        foreach (var item in lop)
        //        {
        //            cboMaLop.Items.Add(item);
        //        }

        //        // Hoặc dùng AddRange (nhưng phải chuyển sang object array)
        //        // cboMaLop.Items.AddRange(lop.ToArray());
        //    }
        //}
        private void LoadDataToComboBox()
        {
            cboMaLop.Items.Clear();

            List<Lop> lop = _context.Lops.ToList();

            if (lop != null && lop.Any())
            {
                // Đăng ký sự kiện Format trước khi thêm dữ liệu
                cboMaLop.Format += CboMaLop_Format;

                foreach (var item in lop)
                {
                    cboMaLop.Items.Add(item);
                }
            }
        }

        // Hàm xử lý format hiển thị
        private void CboMaLop_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Lop lop)
            {
                e.Value = $"{lop.MaLop} - {lop.TenLop}";
            }
        }

    }
}
