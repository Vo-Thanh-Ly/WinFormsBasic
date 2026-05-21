namespace StudentManagementBasic.Forms
{
    partial class UpdateStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.NumericUpDown nudNamNhapHoc;
        private System.Windows.Forms.CheckBox chkTrangThai;

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblRequiredNote;

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
            lblTitle = new Label();
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
            cboMaLop = new ComboBox();
            nudNamNhapHoc = new NumericUpDown();
            chkTrangThai = new CheckBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnClear = new Button();
            groupBoxInfo = new GroupBox();
            panelButtons = new Panel();
            errorProvider = new ErrorProvider(components);
            lblRequiredNote = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNamNhapHoc).BeginInit();
            groupBoxInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitle.Location = new Point(10, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT SINH VIÊN";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMaSV.ForeColor = Color.Red;
            lblMaSV.Location = new Point(18, 26);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(108, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên:*";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.Red;
            lblHoTen.Location = new Point(18, 56);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(67, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:*";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(18, 86);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGioiTinh.ForeColor = Color.Red;
            lblGioiTinh.Location = new Point(18, 116);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(80, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:*";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(18, 146);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(18, 189);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 10;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 217);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(18, 244);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(59, 20);
            lblMaLop.TabIndex = 14;
            lblMaLop.Text = "Mã lớp:";
            // 
            // lblNamNhapHoc
            // 
            lblNamNhapHoc.AutoSize = true;
            lblNamNhapHoc.Location = new Point(18, 272);
            lblNamNhapHoc.Name = "lblNamNhapHoc";
            lblNamNhapHoc.Size = new Size(109, 20);
            lblNamNhapHoc.TabIndex = 16;
            lblNamNhapHoc.Text = "Năm nhập học:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(262, 272);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = Color.LightGray;
            txtMaSV.Location = new Point(140, 24);
            txtMaSV.Margin = new Padding(3, 2, 3, 2);
            txtMaSV.MaxLength = 10;
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = true;
            txtMaSV.Size = new Size(324, 27);
            txtMaSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(140, 54);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.MaxLength = 100;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(324, 27);
            txtHoTen.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(140, 84);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(324, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(140, 114);
            cboGioiTinh.Margin = new Padding(3, 2, 3, 2);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(324, 28);
            cboGioiTinh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(140, 144);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.MaxLength = 200;
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(324, 38);
            txtDiaChi.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(140, 187);
            txtSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtSoDienThoai.MaxLength = 15;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(324, 27);
            txtSoDienThoai.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 214);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 27);
            txtEmail.TabIndex = 13;
            // 
            // cboMaLop
            // 
            cboMaLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaLop.Location = new Point(140, 242);
            cboMaLop.Margin = new Padding(3, 2, 3, 2);
            cboMaLop.Name = "cboMaLop";
            cboMaLop.Size = new Size(219, 28);
            cboMaLop.TabIndex = 15;
            // 
            // nudNamNhapHoc
            // 
            nudNamNhapHoc.Location = new Point(140, 271);
            nudNamNhapHoc.Margin = new Padding(3, 2, 3, 2);
            nudNamNhapHoc.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNamNhapHoc.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNamNhapHoc.Name = "nudNamNhapHoc";
            nudNamNhapHoc.Size = new Size(105, 27);
            nudNamNhapHoc.TabIndex = 17;
            nudNamNhapHoc.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(346, 272);
            chkTrangThai.Margin = new Padding(3, 2, 3, 2);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(92, 24);
            chkTrangThai.TabIndex = 19;
            chkTrangThai.Text = "Đang học";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(119, 6);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 30);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(376, 8);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 30);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "HỦY";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightYellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(254, 6);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 30);
            btnClear.TabIndex = 1;
            btnClear.Text = "NHẬP LẠI";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblMaSV);
            groupBoxInfo.Controls.Add(txtMaSV);
            groupBoxInfo.Controls.Add(lblHoTen);
            groupBoxInfo.Controls.Add(txtHoTen);
            groupBoxInfo.Controls.Add(lblNgaySinh);
            groupBoxInfo.Controls.Add(dtpNgaySinh);
            groupBoxInfo.Controls.Add(lblGioiTinh);
            groupBoxInfo.Controls.Add(cboGioiTinh);
            groupBoxInfo.Controls.Add(lblDiaChi);
            groupBoxInfo.Controls.Add(txtDiaChi);
            groupBoxInfo.Controls.Add(lblSoDienThoai);
            groupBoxInfo.Controls.Add(txtSoDienThoai);
            groupBoxInfo.Controls.Add(lblEmail);
            groupBoxInfo.Controls.Add(txtEmail);
            groupBoxInfo.Controls.Add(lblMaLop);
            groupBoxInfo.Controls.Add(cboMaLop);
            groupBoxInfo.Controls.Add(lblNamNhapHoc);
            groupBoxInfo.Controls.Add(nudNamNhapHoc);
            groupBoxInfo.Controls.Add(lblTrangThai);
            groupBoxInfo.Controls.Add(chkTrangThai);
            groupBoxInfo.Font = new Font("Segoe UI", 11F);
            groupBoxInfo.Location = new Point(18, 64);
            groupBoxInfo.Margin = new Padding(3, 2, 3, 2);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(3, 2, 3, 2);
            groupBoxInfo.Size = new Size(490, 270);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin sinh viên";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Location = new Point(18, 341);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(490, 38);
            panelButtons.TabIndex = 3;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblRequiredNote
            // 
            lblRequiredNote.AutoSize = true;
            lblRequiredNote.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblRequiredNote.ForeColor = Color.Red;
            lblRequiredNote.Location = new Point(18, 41);
            lblRequiredNote.Name = "lblRequiredNote";
            lblRequiredNote.Size = new Size(153, 15);
            lblRequiredNote.TabIndex = 1;
            lblRequiredNote.Text = "(*) Thông tin bắt buộc nhập";
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 390);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxInfo);
            Controls.Add(lblRequiredNote);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)nudNamNhapHoc).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}