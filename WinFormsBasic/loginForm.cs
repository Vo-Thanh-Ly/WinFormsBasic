namespace WinFormsBasic
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            Password_textBox.PasswordChar = '*';
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = Username_textBox.Text;
            string password = Password_textBox.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Thiếu tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.Equals(username, "Admin",StringComparison.Ordinal) && String.Equals(password, "12345",StringComparison.Ordinal))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
