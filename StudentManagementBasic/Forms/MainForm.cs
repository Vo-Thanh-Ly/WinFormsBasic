
//using StudentManagementBasic.Data;
//using System.Drawing;
//using System.Windows.Forms.VisualStyles;
//namespace StudentManagementBasic.Forms
//{
//    public partial class MainForm : Form
//    {
//        private AppDbContext _context;

//        // Constructor không tham số - PHẢI gọi InitializeComponent() và khởi tạo _context
//        public MainForm() : this(new AppDbContext())
//        {
//        }

//               public MainForm(AppDbContext context)
//        {
//            InitializeComponent();

//            _context = context;

//            // Event textbox
//            tenSinhVien_textBox.KeyPress += txtTenSinhVien_KeyPress;

//            // =========================
//            // ACTION COLUMN
//            // =========================
//            if (!dataGridView1.Columns.Contains("Action"))
//            {
//                DataGridViewTextBoxColumn actionColumn =
//                    new DataGridViewTextBoxColumn();

//                actionColumn.Name = "Action";

//                actionColumn.HeaderText = "Thao tác";

//                actionColumn.Width = 220;

//                dataGridView1.Columns.Add(actionColumn);
//            }

//            // =========================
//            // UI GRID
//            // =========================
//            dataGridView1.RowTemplate.Height = 40;

//            dataGridView1.AllowUserToAddRows = false;

//            dataGridView1.AutoSizeColumnsMode =
//                DataGridViewAutoSizeColumnsMode.Fill;

//            // =========================
//            // EVENTS
//            // =========================
//            dataGridView1.CellPainting += dataGridView1_CellPainting;

//            dataGridView1.CellClick += dataGridView1_CellClick;
//        }

//        private void dataGridView1_CellClick(
//     object sender,
//     DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex < 0)
//                return;

//            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
//            {
//                Rectangle cellRect =
//                    dataGridView1.GetCellDisplayRectangle(
//                        e.ColumnIndex,
//                        e.RowIndex,
//                        false);

//                Point clickPoint =
//                    dataGridView1.PointToClient(Cursor.Position);

//                int x =
//                    clickPoint.X - cellRect.Left;

//                // ======================
//                // CLICK SỬA
//                // ======================
//                if (x >= 5 && x <= 60)
//                {
//                    MessageBox.Show("Sửa dòng " + e.RowIndex);
//                }

//                // ======================
//                // CLICK XÓA
//                // ======================
//                else if (x >= 65 && x <= 120)
//                {
//                    MessageBox.Show("Xóa dòng " + e.RowIndex);
//                }

//                // ======================
//                // CLICK CHI TIẾT
//                // ======================
//                else if (x >= 125 && x <= 200)
//                {
//                    MessageBox.Show("Chi tiết dòng " + e.RowIndex);
//                }
//            }
//        }

//        private void dataGridView1_CellPainting(
//     object sender,
//     DataGridViewCellPaintingEventArgs e)
//        {
//            if (e.RowIndex < 0)
//                return;

//            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
//            {
//                e.Paint(e.CellBounds,
//                    DataGridViewPaintParts.All);

//                // ======================
//                // BUTTON SỬA
//                // ======================
//                Rectangle editRect =
//                    new Rectangle(
//                        e.CellBounds.Left + 5,
//                        e.CellBounds.Top + 5,
//                        55,
//                        28);

//                ButtonRenderer.DrawButton(
//                    e.Graphics,
//                    editRect,
//                    "Sửa",
//                    this.Font,
//                    false,
//                    PushButtonState.Normal);

//                // ======================
//                // BUTTON XÓA
//                // ======================
//                Rectangle deleteRect =
//                    new Rectangle(
//                        e.CellBounds.Left + 65,
//                        e.CellBounds.Top + 5,
//                        55,
//                        28);

//                ButtonRenderer.DrawButton(
//                    e.Graphics,
//                    deleteRect,
//                    "Xóa",
//                    this.Font,
//                    false,
//                    PushButtonState.Normal);

//                // ======================
//                // BUTTON CHI TIẾT
//                // ======================
//                Rectangle detailRect =
//                    new Rectangle(
//                        e.CellBounds.Left + 125,
//                        e.CellBounds.Top + 5,
//                        75,
//                        28);

//                ButtonRenderer.DrawButton(
//                    e.Graphics,
//                    detailRect,
//                    "Chi tiết",
//                    this.Font,
//                    false,
//                    PushButtonState.Normal);

//                e.Handled = true;
//            }
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            loadDataStudent();
//        }

//        private void loadDataStudent()
//        {
//            var students = _context.SinhViens.ToList();
//            dataGridView1.DataSource = students;
//        }


//        private void txtTenSinhVien_KeyPress(object sender, KeyPressEventArgs e)
//        {

//            if (e.KeyChar == (char)Keys.Enter)
//            {
//                string searchTerm = tenSinhVien_textBox.Text.Trim();
//                loadDataStudent(searchTerm);
//            }
//        }

//        private void loadDataStudent(string searchTerm)
//        {
//            if (string.IsNullOrEmpty(searchTerm))
//            {
//                // Nếu ô tìm kiếm trống, hiển thị tất cả
//                loadDataStudent();
//                return;
//            }

//            var students = _context.SinhViens
//                .Where(s => s.HoTen.Contains(searchTerm))
//                .ToList();
//            dataGridView1.DataSource = students;
//        }
//    }
//}

using StudentManagementBasic.Data;
using StudentManagementBasic.ViewModel.StudentManagementBasic.ViewModels;

using System.Drawing;
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

            RegisterEvents();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataStudent();
        }

        // =========================
        // INITIALIZE GRID
        // =========================
        private void InitializeGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ReadOnly = true;

            // =========================
            // COLUMN MÃ SV
            // =========================
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
        private void RegisterEvents()
        {
            tenSinhVien_textBox.KeyPress +=
                txtTenSinhVien_KeyPress;

            dataGridView1.CellPainting +=
                dataGridView1_CellPainting;

            dataGridView1.CellClick +=
                dataGridView1_CellClick;
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

                    Lop = s.Lop.TenLop??"null",

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

                    NgaySinh = s.NgaySinh
                        .ToString("dd/MM/yyyy")
                })
                .ToList();

            dataGridView1.DataSource = students;
        }

        // =========================
        // SEARCH EVENT
        // =========================
        private void txtTenSinhVien_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string searchTerm =
                    tenSinhVien_textBox.Text.Trim();

                LoadDataStudent(searchTerm);
            }
        }

        // =========================
        // DRAW 3 BUTTONS
        // =========================
        private void dataGridView1_CellPainting(
            object sender,
            DataGridViewCellPaintingEventArgs e)
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
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
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

                Point clickPoint =
                    dataGridView1.PointToClient(
                        Cursor.Position);

                int x =
                    clickPoint.X - cellRect.Left;

                var selectedStudent =
                    (SinhVienViewModel)
                    dataGridView1.Rows[e.RowIndex]
                    .DataBoundItem;

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
    }
}
