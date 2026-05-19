//namespace StudentManagementBasic.Forms
//{
//    partial class AddStudent
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            SuspendLayout();
//            // 
//            // AddStudent
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(672, 328);
//            Name = "AddStudent";
//            Text = "AddStudent";
//            ResumeLayout(false);
//        }

//        #endregion
//    }
//}

namespace StudentManagementBasic.Forms
{
    partial class AddStudent
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNamNhapHoc;
        private System.Windows.Forms.Label lblTrangThai;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.NumericUpDown nudNamNhapHoc;
        private System.Windows.Forms.CheckBox chkTrangThai;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblDiaChi = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblMaLop = new Label();
            lblNamNhapHoc = new Label();
            lblTrangThai = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            txtDiaChi = new TextBox();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtMaLop = new TextBox();
            nudNamNhapHoc = new NumericUpDown();
            chkTrangThai = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudNamNhapHoc).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.ForeColor = Color.Red;
            lblMaSV.Location = new Point(20, 32);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(100, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên:*";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.ForeColor = Color.Red;
            lblHoTen.Location = new Point(20, 68);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(63, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:*";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 104);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.ForeColor = Color.Red;
            lblGioiTinh.Location = new Point(20, 140);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(74, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:*";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(20, 176);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(20, 232);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 10;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 268);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(20, 304);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(59, 20);
            lblMaLop.TabIndex = 14;
            lblMaLop.Text = "Mã lớp:";
            // 
            // lblNamNhapHoc
            // 
            lblNamNhapHoc.AutoSize = true;
            lblNamNhapHoc.Location = new Point(20, 340);
            lblNamNhapHoc.Name = "lblNamNhapHoc";
            lblNamNhapHoc.Size = new Size(109, 20);
            lblNamNhapHoc.TabIndex = 16;
            lblNamNhapHoc.Text = "Năm nhập học:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(300, 340);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(140, 29);
            txtMaSV.MaxLength = 10;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.PlaceholderText = "VD: SV001, SV002...";
            txtMaSV.Size = new Size(350, 27);
            txtMaSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(140, 65);
            txtHoTen.MaxLength = 100;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Nhập họ và tên đầy đủ";
            txtHoTen.Size = new Size(350, 27);
            txtHoTen.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(140, 101);
            dtpNgaySinh.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(350, 27);
            dtpNgaySinh.TabIndex = 5;
            dtpNgaySinh.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(140, 137);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(350, 28);
            cboGioiTinh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(140, 173);
            txtDiaChi.MaxLength = 200;
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Nhập địa chỉ chi tiết";
            txtDiaChi.Size = new Size(350, 50);
            txtDiaChi.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(140, 229);
            txtSoDienThoai.MaxLength = 15;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "VD: 0912345678";
            txtSoDienThoai.Size = new Size(350, 27);
            txtSoDienThoai.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 265);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "VD: ten.sinhvien@school.edu.vn";
            txtEmail.Size = new Size(350, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(140, 301);
            txtMaLop.MaxLength = 10;
            txtMaLop.Name = "txtMaLop";
            txtMaLop.PlaceholderText = "VD: CTK45, DCT123...";
            txtMaLop.Size = new Size(350, 27);
            txtMaLop.TabIndex = 15;
            // 
            // nudNamNhapHoc
            // 
            nudNamNhapHoc.Location = new Point(140, 338);
            nudNamNhapHoc.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNamNhapHoc.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNamNhapHoc.Name = "nudNamNhapHoc";
            nudNamNhapHoc.Size = new Size(150, 27);
            nudNamNhapHoc.TabIndex = 17;
            nudNamNhapHoc.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(379, 340);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(92, 24);
            chkTrangThai.TabIndex = 19;
            chkTrangThai.Text = "Đang học";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(190, 405);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(402, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(296, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "Nhập lại";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMaSV);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lblNgaySinh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(lblGioiTinh);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(lblDiaChi);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(lblSoDienThoai);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblMaLop);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(lblNamNhapHoc);
            groupBox1.Controls.Add(nudNamNhapHoc);
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(chkTrangThai);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 458);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm sinh viên mới";
            ((System.ComponentModel.ISupportInitialize)nudNamNhapHoc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }
    }
}