
using StudentManagementBasic.Data;

namespace StudentManagementBasic.Forms
{
    public partial class MainForm : Form
    {
        private AppDbContext _context;

        // Constructor không tham số - PHẢI gọi InitializeComponent() và khởi tạo _context
        public MainForm() : this(new AppDbContext())
        {
        }

        // Constructor có tham số
        public MainForm(AppDbContext context)
        {
            InitializeComponent();  // 👈 Luôn phải có dòng này
            _context = context;


            // 👇 Gán sự kiện bằng code (đảm bảo 100% được gán)
            tenSinhVien_textBox.KeyPress += txtTenSinhVien_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataStudent();
        }

        private void loadDataStudent()
        {
            var students = _context.SinhViens.ToList();
            dataGridView1.DataSource = students;
        }


        private void txtTenSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == (char)Keys.Enter)
            {
                string searchTerm = tenSinhVien_textBox.Text.Trim();
                loadDataStudent(searchTerm);
            }
        }

        private void loadDataStudent(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Nếu ô tìm kiếm trống, hiển thị tất cả
                loadDataStudent();
                return;
            }

            var students = _context.SinhViens
                .Where(s => s.HoTen.Contains(searchTerm))
                .ToList();
            dataGridView1.DataSource = students;
        }
    }
}
