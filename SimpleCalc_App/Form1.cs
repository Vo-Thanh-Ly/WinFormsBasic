namespace SimpleCalc_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //        private void RunButton_Click(object sender, EventArgs e)
        //        {
        //            //Kiểm tra A và B có rỗng hay không
        //            if (String.IsNullOrWhiteSpace(SoA_textBox.Text) || String.IsNullOrWhiteSpace(SoB_textBox.Text))
        //            {
        //                MessageBox.Show("Vui lòng nhập đầy đủ số A và số B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            //Kiểm tra xem người dùng có nhập đúng định dạng số hay không
        //            else if (!double.TryParse(SoA_textBox.Text, out double soA) || !double.TryParse(SoB_textBox.Text, out double soB))
        //            {
        //                MessageBox.Show("Vui lòng nhập số hợp lệ cho A và B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            //Kiểm tra xem người dùng đã chọn phép tính nào chưa
        //            else if (String.IsNullOrWhiteSpace(PhepToan_comboBox.Text))
        //            {
        //                MessageBox.Show("Vui lòng chọn một phép tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //else
        //            {
        //                switch(PhepToan_comboBox.Text)
        //                {
        //                    case "+":
        //                        MessageBox.Show("Phép cộng có thể dẫn đến kết quả lớn, hãy cẩn thận với số lớn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        ketQua_textBox.Text = (soA + soB).ToString();
        //                        break;
        //                    case "-":
        //                        MessageBox.Show("Phép trừ có thể dẫn đến kết quả âm, hãy cẩn thận với số nhỏ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        ketQua_textBox.Text = (soA - soB).ToString();
        //                        break;
        //                    case "*":
        //                        MessageBox.Show("Phép nhân có thể dẫn đến kết quả lớn, hãy cẩn thận với số lớn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        ketQua_textBox.Text = (soA * soB).ToString();
        //                        break;
        //                    case "/":
        //                        if (soB == 0)
        //                        {
        //                            MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            ketQua_textBox.Text = "";
        //                        }
        //                        else
        //                        {MessageBox.Show("Chia cho 0 sẽ trả về vô cùng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                            ketQua_textBox.Text = (soA / soB).ToString();
        //                        }
        //                        break;

        //                    default:
        //                        MessageBox.Show("Phép tính không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        break;
        //                }
        //            }
        //        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra A và B có rỗng hay không
            if (String.IsNullOrWhiteSpace(SoA_textBox.Text) || String.IsNullOrWhiteSpace(SoB_textBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số A và số B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dùng return để thoát sớm, giúp code không bị lồng sâu
            }

            // 2. Kiểm tra xem người dùng có nhập đúng định dạng số hay không
            if (!double.TryParse(SoA_textBox.Text, out double soA) || !double.TryParse(SoB_textBox.Text, out double soB))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho A và B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra xem người dùng đã chọn phép tính nào chưa
            if (String.IsNullOrWhiteSpace(PhepToan_comboBox.Text))
            {
                MessageBox.Show("Vui lòng chọn một phép tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Thực hiện phép tính
            switch (PhepToan_comboBox.Text)
            {
                case "+":
                    ketQua_textBox.Text = (soA + soB).ToString();
                    break;
                case "-":
                    ketQua_textBox.Text = (soA - soB).ToString();
                    break;
                case "*":
                    ketQua_textBox.Text = (soA * soB).ToString();
                    break;
                case "/":
                    if (soB == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ketQua_textBox.Text = string.Empty; // Dùng string.Empty thay cho ""
                    }
                    else
                    {
                        ketQua_textBox.Text = (soA / soB).ToString();
                    }
                    break;
                default:
                    MessageBox.Show("Phép tính không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
