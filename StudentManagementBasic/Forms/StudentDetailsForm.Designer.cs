namespace StudentManagementBasic.Forms
{
    partial class StudentDetailsForm
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

        private System.Windows.Forms.Label lblMaSVValue;
        private System.Windows.Forms.Label lblHoTenValue;
        private System.Windows.Forms.Label lblNgaySinhValue;
        private System.Windows.Forms.Label lblGioiTinhValue;
        private System.Windows.Forms.Label lblDiaChiValue;
        private System.Windows.Forms.Label lblSoDienThoaiValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblMaLopValue;
        private System.Windows.Forms.Label lblNamNhapHocValue;
        private System.Windows.Forms.Label lblTrangThaiValue;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxInfo;

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
            lblMaSVValue = new Label();
            lblHoTenValue = new Label();
            lblNgaySinhValue = new Label();
            lblGioiTinhValue = new Label();
            lblDiaChiValue = new Label();
            lblSoDienThoaiValue = new Label();
            lblEmailValue = new Label();
            lblMaLopValue = new Label();
            lblNamNhapHocValue = new Label();
            lblTrangThaiValue = new Label();
            panelMain = new Panel();
            panelButtons = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            groupBoxInfo = new GroupBox();
            panelButtons.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitle.Location = new Point(18, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHI TIẾT SINH VIÊN";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMaSV.Location = new Point(18, 26);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(101, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHoTen.Location = new Point(18, 52);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(60, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(18, 79);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(83, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGioiTinh.Location = new Point(18, 105);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(73, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDiaChi.Location = new Point(18, 131);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(60, 20);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoDienThoai.Location = new Point(288, 26);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(104, 20);
            lblSoDienThoai.TabIndex = 10;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmail.Location = new Point(288, 52);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMaLop.Location = new Point(288, 79);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(61, 20);
            lblMaLop.TabIndex = 14;
            lblMaLop.Text = "Mã lớp:";
            // 
            // lblNamNhapHoc
            // 
            lblNamNhapHoc.AutoSize = true;
            lblNamNhapHoc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNamNhapHoc.Location = new Point(288, 105);
            lblNamNhapHoc.Name = "lblNamNhapHoc";
            lblNamNhapHoc.Size = new Size(115, 20);
            lblNamNhapHoc.TabIndex = 16;
            lblNamNhapHoc.Text = "Năm nhập học:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTrangThai.Location = new Point(288, 131);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(84, 20);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblMaSVValue
            // 
            lblMaSVValue.AutoSize = true;
            lblMaSVValue.Font = new Font("Segoe UI", 11F);
            lblMaSVValue.Location = new Point(131, 26);
            lblMaSVValue.Name = "lblMaSVValue";
            lblMaSVValue.Size = new Size(50, 20);
            lblMaSVValue.TabIndex = 1;
            lblMaSVValue.Text = "SV001";
            // 
            // lblHoTenValue
            // 
            lblHoTenValue.AutoSize = true;
            lblHoTenValue.Font = new Font("Segoe UI", 11F);
            lblHoTenValue.Location = new Point(131, 52);
            lblHoTenValue.Name = "lblHoTenValue";
            lblHoTenValue.Size = new Size(102, 20);
            lblHoTenValue.TabIndex = 3;
            lblHoTenValue.Text = "Nguyễn Văn A";
            // 
            // lblNgaySinhValue
            // 
            lblNgaySinhValue.AutoSize = true;
            lblNgaySinhValue.Font = new Font("Segoe UI", 11F);
            lblNgaySinhValue.Location = new Point(131, 79);
            lblNgaySinhValue.Name = "lblNgaySinhValue";
            lblNgaySinhValue.Size = new Size(85, 20);
            lblNgaySinhValue.TabIndex = 5;
            lblNgaySinhValue.Text = "01/01/2000";
            // 
            // lblGioiTinhValue
            // 
            lblGioiTinhValue.AutoSize = true;
            lblGioiTinhValue.Font = new Font("Segoe UI", 11F);
            lblGioiTinhValue.Location = new Point(131, 105);
            lblGioiTinhValue.Name = "lblGioiTinhValue";
            lblGioiTinhValue.Size = new Size(41, 20);
            lblGioiTinhValue.TabIndex = 7;
            lblGioiTinhValue.Text = "Nam";
            // 
            // lblDiaChiValue
            // 
            lblDiaChiValue.AutoSize = true;
            lblDiaChiValue.Font = new Font("Segoe UI", 11F);
            lblDiaChiValue.Location = new Point(131, 131);
            lblDiaChiValue.Name = "lblDiaChiValue";
            lblDiaChiValue.Size = new Size(125, 20);
            lblDiaChiValue.TabIndex = 9;
            lblDiaChiValue.Text = "Hà Nội, Việt Nam";
            // 
            // lblSoDienThoaiValue
            // 
            lblSoDienThoaiValue.AutoSize = true;
            lblSoDienThoaiValue.Font = new Font("Segoe UI", 11F);
            lblSoDienThoaiValue.Location = new Point(411, 26);
            lblSoDienThoaiValue.Name = "lblSoDienThoaiValue";
            lblSoDienThoaiValue.Size = new Size(89, 20);
            lblSoDienThoaiValue.TabIndex = 11;
            lblSoDienThoaiValue.Text = "0912345678";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Segoe UI", 11F);
            lblEmailValue.Location = new Point(411, 52);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(141, 20);
            lblEmailValue.TabIndex = 13;
            lblEmailValue.Text = "student@email.com";
            // 
            // lblMaLopValue
            // 
            lblMaLopValue.AutoSize = true;
            lblMaLopValue.Font = new Font("Segoe UI", 11F);
            lblMaLopValue.Location = new Point(411, 79);
            lblMaLopValue.Name = "lblMaLopValue";
            lblMaLopValue.Size = new Size(51, 20);
            lblMaLopValue.TabIndex = 15;
            lblMaLopValue.Text = "CTK45";
            // 
            // lblNamNhapHocValue
            // 
            lblNamNhapHocValue.AutoSize = true;
            lblNamNhapHocValue.Font = new Font("Segoe UI", 11F);
            lblNamNhapHocValue.Location = new Point(411, 105);
            lblNamNhapHocValue.Name = "lblNamNhapHocValue";
            lblNamNhapHocValue.Size = new Size(41, 20);
            lblNamNhapHocValue.TabIndex = 17;
            lblNamNhapHocValue.Text = "2020";
            // 
            // lblTrangThaiValue
            // 
            lblTrangThaiValue.AutoSize = true;
            lblTrangThaiValue.Font = new Font("Segoe UI", 11F);
            lblTrangThaiValue.ForeColor = Color.Green;
            lblTrangThaiValue.Location = new Point(411, 131);
            lblTrangThaiValue.Name = "lblTrangThaiValue";
            lblTrangThaiValue.Size = new Size(73, 20);
            lblTrangThaiValue.TabIndex = 19;
            lblTrangThaiValue.Text = "Đang học";
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(200, 100);
            panelMain.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Location = new Point(18, 300);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(650, 38);
            panelButtons.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 120, 215);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(219, 4);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 30);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "CẬP NHẬT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(315, 4);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(411, 4);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "ĐÓNG";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(lblMaSV);
            groupBoxInfo.Controls.Add(lblMaSVValue);
            groupBoxInfo.Controls.Add(lblHoTen);
            groupBoxInfo.Controls.Add(lblHoTenValue);
            groupBoxInfo.Controls.Add(lblNgaySinh);
            groupBoxInfo.Controls.Add(lblNgaySinhValue);
            groupBoxInfo.Controls.Add(lblGioiTinh);
            groupBoxInfo.Controls.Add(lblGioiTinhValue);
            groupBoxInfo.Controls.Add(lblDiaChi);
            groupBoxInfo.Controls.Add(lblDiaChiValue);
            groupBoxInfo.Controls.Add(lblSoDienThoai);
            groupBoxInfo.Controls.Add(lblSoDienThoaiValue);
            groupBoxInfo.Controls.Add(lblEmail);
            groupBoxInfo.Controls.Add(lblEmailValue);
            groupBoxInfo.Controls.Add(lblMaLop);
            groupBoxInfo.Controls.Add(lblMaLopValue);
            groupBoxInfo.Controls.Add(lblNamNhapHoc);
            groupBoxInfo.Controls.Add(lblNamNhapHocValue);
            groupBoxInfo.Controls.Add(lblTrangThai);
            groupBoxInfo.Controls.Add(lblTrangThaiValue);
            groupBoxInfo.Font = new Font("Segoe UI", 11F);
            groupBoxInfo.Location = new Point(18, 52);
            groupBoxInfo.Margin = new Padding(3, 2, 3, 2);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Padding = new Padding(3, 2, 3, 2);
            groupBoxInfo.Size = new Size(650, 240);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin chi tiết";
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 352);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxInfo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết sinh viên";
            panelButtons.ResumeLayout(false);
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}