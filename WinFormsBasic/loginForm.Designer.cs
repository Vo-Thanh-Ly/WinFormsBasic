namespace WinFormsBasic
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username_txt = new Label();
            Password_txt = new Label();
            groupBox1 = new GroupBox();
            Password_textBox = new TextBox();
            Username_textBox = new TextBox();
            Login_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Username_txt
            // 
            Username_txt.AutoSize = true;
            Username_txt.Location = new Point(27, 38);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(89, 15);
            Username_txt.TabIndex = 0;
            Username_txt.Text = "Tên đăng nhập:";
            // 
            // Password_txt
            // 
            Password_txt.AutoSize = true;
            Password_txt.Location = new Point(27, 77);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(63, 15);
            Password_txt.TabIndex = 1;
            Password_txt.Text = "Mật khẩu: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(Password_textBox);
            groupBox1.Controls.Add(Username_textBox);
            groupBox1.Controls.Add(Password_txt);
            groupBox1.Controls.Add(Username_txt);
            groupBox1.Location = new Point(15, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 135);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(132, 69);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(126, 23);
            Password_textBox.TabIndex = 3;
            // 
            // Username_textBox
            // 
            Username_textBox.Location = new Point(132, 35);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(126, 23);
            Username_textBox.TabIndex = 1;
            // 
            // Login_button
            // 
            Login_button.Anchor = AnchorStyles.None;
            Login_button.AutoSize = true;
            Login_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_button.BackColor = Color.LightSkyBlue;
            Login_button.FlatStyle = FlatStyle.Popup;
            Login_button.Location = new Point(133, 192);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(75, 25);
            Login_button.TabIndex = 4;
            Login_button.Text = "Đăng nhập";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 246);
            Controls.Add(Login_button);
            Controls.Add(groupBox1);
            Name = "loginForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username_txt;
        private Label Password_txt;
        private GroupBox groupBox1;
        private TextBox Password_textBox;
        private TextBox Username_textBox;
        private Button Login_button;
    }
}
