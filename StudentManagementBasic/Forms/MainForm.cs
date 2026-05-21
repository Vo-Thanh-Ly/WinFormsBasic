
using StudentManagementBasic.Data;
using StudentManagementBasic.Models;
using StudentManagementBasic.ViewModel.StudentManagementBasic.ViewModels;
using System.Windows.Forms.VisualStyles;

namespace StudentManagementBasic.Forms
{
    public partial class MainForm : Form
    {
        private AppDbContext _context;

        // =========================
        // CONSTRUCTOR DEFAULT
        // =========================
        public MainForm() : this(new AppDbContext())
        {
        }

        // =========================
        // CONSTRUCTOR
        // =========================
        public MainForm(AppDbContext context)
        {
            // Gọi phương thức khởi tạo giao diện do Visual Studio tạo ra
            InitializeComponent();

            _context = context;

            InitializeGrid();
            LoadDataStudent();
            RegisterEvents();
        }
        // Đây là nơi chúng ta cấu hình DataGridView để hiển thị dữ liệu sinh viên
        //private void InitializeGrid()
        //{
        //    dataGridView1.AutoGenerateColumns = false;
        //    dataGridView1.AllowUserToAddRows = false;
        //    dataGridView1.RowTemplate.Height = 40;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dataGridView1.ReadOnly = true;

        //    // Tạo cột "Mã sinh viên" và liên kết với thuộc tính MaSV trong SinhVienViewModel
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "MaSV",
        //            HeaderText = "Mã sinh viên",
        //            DataPropertyName = "MaSV"
        //        });

        //    // =========================
        //    // COLUMN HỌ TÊN
        //    // =========================
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "HoTen",
        //            HeaderText = "Họ tên",
        //            DataPropertyName = "HoTen"
        //        });

        //    // =========================
        //    // COLUMN GIỚI TÍNH
        //    // =========================
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "GioiTinh",
        //            HeaderText = "Giới tính",
        //            DataPropertyName = "GioiTinh"
        //        });

        //    // =========================
        //    // COLUMN LỚP
        //    // =========================
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "Lop",
        //            HeaderText = "Lớp",
        //            DataPropertyName = "Lop"
        //        });

        //    // =========================
        //    // COLUMN NGÀY SINH
        //    // =========================
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "NgaySinh",
        //            HeaderText = "Ngày sinh",
        //            DataPropertyName = "NgaySinh"
        //        });

        //    // =========================
        //    // ACTION COLUMN
        //    // =========================
        //    dataGridView1.Columns.Add(
        //        new DataGridViewTextBoxColumn
        //        {
        //            Name = "Action",
        //            HeaderText = "Thao tác",
        //            Width = 220
        //        });
        //}

        private void InitializeGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 40;
            // THAY ĐỔI: Không dùng Fill nữa
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            // Cột Mã sinh viên - co giãn theo tỷ lệ
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "MaSV",
                    HeaderText = "Mã sinh viên",
                    DataPropertyName = "MaSV",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Chỉ cột này fill
                });

            // Cột Họ tên - co giãn
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "HoTen",
                    HeaderText = "Họ tên",
                    DataPropertyName = "HoTen",
                    Width = 150,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

            // Cột Giới tính
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "GioiTinh",
                    HeaderText = "Giới tính",
                    DataPropertyName = "GioiTinh",
                    Width = 80,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

            // Cột Lớp
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Lop",
                    HeaderText = "Lớp",
                    DataPropertyName = "Lop",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

            // Cột Ngày sinh
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "NgaySinh",
                    HeaderText = "Ngày sinh",
                    DataPropertyName = "NgaySinh",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

            // Cột Action - CỐ ĐỊNH, không co giãn
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Action",
                    HeaderText = "Thao tác",
                    Width = 220,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None, // Quan trọng!
                    Frozen = false // Không cố định vị trí (có thể cuộn ngang)
                });
        }

        // Đây là nơi chúng ta đăng ký các sự kiện cho TextBox tìm kiếm và DataGridView
        private void RegisterEvents()
        {
            // Đăng ký sự kiện KeyPress cho TextBox tìm kiếm để xử lý khi người dùng nhấn Enter
            tenSinhVien_textBox.KeyPress += txtTenSinhVien_KeyPress;
            // Đăng ký sự kiện CellPainting để vẽ 3 nút "Sửa", "Xóa", "Chi tiết" trong cột "Thao tác"
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // Đăng ký sự kiện CellClick để xử lý khi người dùng click vào các nút trong cột "Thao tác"
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // =========================
        // LOAD ALL DATA
        // =========================
        private void LoadDataStudent()
        {
            var students = _context.SinhViens
                .Select(s => new SinhVienViewModel
                {
                    MaSV = s.MaSV,
                    HoTen = s.HoTen,
                    GioiTinh = s.GioiTinh,
                    Lop = s.Lop.TenLop ?? "null",
                    NgaySinh = s.NgaySinh
                        .ToString("dd/MM/yyyy")
                })
                .ToList();
            dataGridView1.DataSource = students;
        }

        // =========================
        // SEARCH DATA
        // =========================
        private void LoadDataStudent(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadDataStudent();
                return;
            }

            var students = _context.SinhViens
                .Where(s => s.HoTen.Contains(searchTerm))
                .Select(s => new SinhVienViewModel
                {
                    MaSV = s.MaSV,
                    HoTen = s.HoTen,
                    GioiTinh = s.GioiTinh,
                    Lop = s.Lop.MaLop,
                    NgaySinh = s.NgaySinh.ToString("dd/MM/yyyy")
                })
                .ToList();

            dataGridView1.DataSource = students;
        }

        // =========================
        // SEARCH EVENT
        // =========================
        private void txtTenSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string searchTerm = tenSinhVien_textBox.Text.Trim();
                LoadDataStudent(searchTerm);
            }
        }

        // =========================
        // DRAW 3 BUTTONS
        // =========================
        // Đây là nơi chúng ta vẽ 3 nút "Sửa", "Xóa", "Chi tiết" trong cột "Thao tác" của DataGridView
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name
                == "Action")
            {
                e.Paint(
                    e.CellBounds,
                    DataGridViewPaintParts.All);

                // =========================
                // BUTTON SỬA
                // =========================
                Rectangle editRect =
                    new Rectangle(
                        e.CellBounds.Left + 5,
                        e.CellBounds.Top + 5,
                        55,
                        28);

                ButtonRenderer.DrawButton(
                    e.Graphics,
                    editRect,
                    "Sửa",
                    this.Font,
                    false,
                    PushButtonState.Normal);

                // =========================
                // BUTTON XÓA
                // =========================
                Rectangle deleteRect =
                    new Rectangle(
                        e.CellBounds.Left + 65,
                        e.CellBounds.Top + 5,
                        55,
                        28);

                ButtonRenderer.DrawButton(
                    e.Graphics,
                    deleteRect,
                    "Xóa",
                    this.Font,
                    false,
                    PushButtonState.Normal);

                // =========================
                // BUTTON CHI TIẾT
                // =========================
                Rectangle detailRect =
                    new Rectangle(
                        e.CellBounds.Left + 125,
                        e.CellBounds.Top + 5,
                        75,
                        28);

                ButtonRenderer.DrawButton(
                    e.Graphics,
                    detailRect,
                    "Chi tiết",
                    this.Font,
                    false,
                    PushButtonState.Normal);

                e.Handled = true;
            }
        }

        // =========================
        // BUTTON CLICK
        // =========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name
                == "Action")
            {
                Rectangle cellRect =
                    dataGridView1.GetCellDisplayRectangle(
                        e.ColumnIndex,
                        e.RowIndex,
                        false);

                Point clickPoint = dataGridView1.PointToClient(Cursor.Position);

                int x = clickPoint.X - cellRect.Left;

                var selectedStudent = (SinhVienViewModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // =========================
                // SỬA
                // =========================
                if (x >= 5 && x <= 60)
                {
                    MessageBox.Show(
                        "Sửa sinh viên: "
                        + selectedStudent.HoTen);
                }

                else if (x >= 65 && x <= 120)
                {
                    // Ép đúng kiểu ViewModel
                    var selectedStudentVM = (SinhVienViewModel)dataGridView1.CurrentRow.DataBoundItem;

                    // Chỉ truyền ID thôi
                    using (DeleteStudentForm deleteForm = new DeleteStudentForm(selectedStudentVM.MaSV))
                    {
                        if (deleteForm.ShowDialog() == DialogResult.OK && deleteForm.IsDeleted)
                        {
                            LoadDataStudent();
                        }
                    }
                }

                // =========================
                // CHI TIẾT
                // =========================
                else if (x >= 125 && x <= 200)
                {

                    // Ép đúng kiểu ViewModel
                    var selectedStudentVM = (SinhVienViewModel)dataGridView1.CurrentRow.DataBoundItem;

                    // Chỉ truyền ID thôi
                    using (StudentDetailsForm detailsForm = new StudentDetailsForm(selectedStudentVM.MaSV))
                    {
                        //if (detailsForm.ShowDialog() == DialogResult.OK && detailsForm.IsDeleted)
                        //{
                        //    LoadDataStudent();
                        //}
                        detailsForm.ShowDialog();
                    }
                }
            }
        }

        private void OpenDeleteStudentForm()
        {
            throw new NotImplementedException();
        }

        private void themSinhVien_button_Click(object sender, EventArgs e)
        {
            using (AddStudent addStudentForm = new AddStudent())
            {
                // Hiển thị form con và chờ kết quả
                DialogResult result = addStudentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Lấy dữ liệu từ form con
                    SinhVien newStudent = addStudentForm.AddedStudent;
                    MessageBox.Show("Mở form thêm sinh viên mới..." + newStudent.Lop.MaLop,
                                      "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView
                    LoadDataStudent();
                    MessageBox.Show($"Đã thêm sinh viên: {newStudent.HoTen}",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã hủy thêm sinh viên!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } // using sẽ tự động dispose form con
        }


        private void SaveToDatabase(SinhVien newStudent)
        {
            throw new NotImplementedException();
        }
    }
}