
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
            InitializeComponent();

            _context = context;

            InitializeGrid();
            LoadDataStudent();
            RegisterEvents();
        }

        // =========================
        // FORM LOAD
        // =========================


        // =========================
        // INITIALIZE GRID
        // =========================
        // Đây là nơi chúng ta cấu hình DataGridView để hiển thị dữ liệu sinh viên
        private void InitializeGrid()
        {
            // Tắt tự động tạo cột vì chúng ta sẽ tạo cột thủ công
            dataGridView1.AutoGenerateColumns = false;
            // Không cho phép người dùng thêm hàng mới trực tiếp trên DataGridView
            dataGridView1.AllowUserToAddRows = false;
            // Đặt chiều cao hàng để có đủ không gian cho 3 nút trong cột "Thao tác"
            dataGridView1.RowTemplate.Height = 40;
            // Đặt chế độ tự động điều chỉnh chiều rộng cột để lấp đầy DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Chỉ cho phép chọn toàn bộ hàng khi click vào một ô
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Đặt DataGridView ở chế độ chỉ đọc để người dùng không thể chỉnh sửa trực tiếp
            dataGridView1.ReadOnly = true;

            // =========================
            // COLUMN MÃ SV
            // =========================
            // Tạo cột "Mã sinh viên" và liên kết với thuộc tính MaSV trong SinhVienViewModel
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "MaSV",
                    HeaderText = "Mã sinh viên",
                    DataPropertyName = "MaSV"
                });

            // =========================
            // COLUMN HỌ TÊN
            // =========================
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "HoTen",
                    HeaderText = "Họ tên",
                    DataPropertyName = "HoTen"
                });

            // =========================
            // COLUMN GIỚI TÍNH
            // =========================
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "GioiTinh",
                    HeaderText = "Giới tính",
                    DataPropertyName = "GioiTinh"
                });

            // =========================
            // COLUMN LỚP
            // =========================
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Lop",
                    HeaderText = "Lớp",
                    DataPropertyName = "Lop"
                });

            // =========================
            // COLUMN NGÀY SINH
            // =========================
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "NgaySinh",
                    HeaderText = "Ngày sinh",
                    DataPropertyName = "NgaySinh"
                });

            // =========================
            // ACTION COLUMN
            // =========================
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Action",
                    HeaderText = "Thao tác",
                    Width = 220
                });
        }

        // =========================
        // REGISTER EVENTS
        // =========================
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

                // =========================
                // XÓA
                // =========================
                else if (x >= 65 && x <= 120)
                {
                    MessageBox.Show(
                        "Xóa sinh viên: "
                        + selectedStudent.HoTen);
                }

                // =========================
                // CHI TIẾT
                // =========================
                else if (x >= 125 && x <= 200)
                {
                    MessageBox.Show(
                        "Chi tiết sinh viên: "
                        + selectedStudent.HoTen);
                }
            }
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

                    // Lưu vào database
                    SaveToDatabase(newStudent);

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