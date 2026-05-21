//namespace StudentManagementBasic.Forms
//{
//    partial class DeleteStudentForm
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
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "DeleteStudentForm";
//        }

//        #endregion
//    }
//}

namespace StudentManagementBasic.Forms
{
    partial class DeleteStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMaLop;

        private System.Windows.Forms.Label lblMaSVValue;
        private System.Windows.Forms.Label lblHoTenValue;
        private System.Windows.Forms.Label lblNgaySinhValue;
        private System.Windows.Forms.Label lblGioiTinhValue;
        private System.Windows.Forms.Label lblDiaChiValue;
        private System.Windows.Forms.Label lblSoDienThoaiValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblMaLopValue;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
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
            this.components = new System.ComponentModel.Container();

            // Khởi tạo controls
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();

            this.lblMaSVValue = new System.Windows.Forms.Label();
            this.lblHoTenValue = new System.Windows.Forms.Label();
            this.lblNgaySinhValue = new System.Windows.Forms.Label();
            this.lblGioiTinhValue = new System.Windows.Forms.Label();
            this.lblDiaChiValue = new System.Windows.Forms.Label();
            this.lblSoDienThoaiValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblMaLopValue = new System.Windows.Forms.Label();

            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();

            this.panelMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC NHẬN XÓA SINH VIÊN";

            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.Image = System.Drawing.SystemIcons.Warning.ToBitmap();
            this.pictureBoxWarning.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarning.TabIndex = 1;
            this.pictureBoxWarning.TabStop = false;

            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(60, 60);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(503, 23);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "CẢNH BÁO: Hành động này không thể hoàn tác. Dữ liệu sẽ bị xóa vĩnh viễn!";

            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblMaSV);
            this.groupBoxInfo.Controls.Add(this.lblMaSVValue);
            this.groupBoxInfo.Controls.Add(this.lblHoTen);
            this.groupBoxInfo.Controls.Add(this.lblHoTenValue);
            this.groupBoxInfo.Controls.Add(this.lblNgaySinh);
            this.groupBoxInfo.Controls.Add(this.lblNgaySinhValue);
            this.groupBoxInfo.Controls.Add(this.lblGioiTinh);
            this.groupBoxInfo.Controls.Add(this.lblGioiTinhValue);
            this.groupBoxInfo.Controls.Add(this.lblDiaChi);
            this.groupBoxInfo.Controls.Add(this.lblDiaChiValue);
            this.groupBoxInfo.Controls.Add(this.lblSoDienThoai);
            this.groupBoxInfo.Controls.Add(this.lblSoDienThoaiValue);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblEmailValue);
            this.groupBoxInfo.Controls.Add(this.lblMaLop);
            this.groupBoxInfo.Controls.Add(this.lblMaLopValue);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 95);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(560, 280);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin sinh viên sẽ bị xóa";

            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaSV.Location = new System.Drawing.Point(20, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(109, 23);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên:";

            // 
            // lblMaSVValue
            // 
            this.lblMaSVValue.AutoSize = true;
            this.lblMaSVValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblMaSVValue.Location = new System.Drawing.Point(150, 35);
            this.lblMaSVValue.Name = "lblMaSVValue";
            this.lblMaSVValue.Size = new System.Drawing.Size(55, 23);
            this.lblMaSVValue.TabIndex = 1;
            this.lblMaSVValue.Text = "SV001";

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(20, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 23);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";

            // 
            // lblHoTenValue
            // 
            this.lblHoTenValue.AutoSize = true;
            this.lblHoTenValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblHoTenValue.Location = new System.Drawing.Point(150, 70);
            this.lblHoTenValue.Name = "lblHoTenValue";
            this.lblHoTenValue.Size = new System.Drawing.Size(106, 23);
            this.lblHoTenValue.TabIndex = 3;
            this.lblHoTenValue.Text = "Nguyễn Văn A";

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(85, 23);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // lblNgaySinhValue
            // 
            this.lblNgaySinhValue.AutoSize = true;
            this.lblNgaySinhValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblNgaySinhValue.Location = new System.Drawing.Point(150, 105);
            this.lblNgaySinhValue.Name = "lblNgaySinhValue";
            this.lblNgaySinhValue.Size = new System.Drawing.Size(88, 23);
            this.lblNgaySinhValue.TabIndex = 5;
            this.lblNgaySinhValue.Text = "01/01/2000";

            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 140);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(78, 23);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính:";

            // 
            // lblGioiTinhValue
            // 
            this.lblGioiTinhValue.AutoSize = true;
            this.lblGioiTinhValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblGioiTinhValue.Location = new System.Drawing.Point(150, 140);
            this.lblGioiTinhValue.Name = "lblGioiTinhValue";
            this.lblGioiTinhValue.Size = new System.Drawing.Size(43, 23);
            this.lblGioiTinhValue.TabIndex = 7;
            this.lblGioiTinhValue.Text = "Nam";

            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.Location = new System.Drawing.Point(20, 175);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 23);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";

            // 
            // lblDiaChiValue
            // 
            this.lblDiaChiValue.AutoSize = true;
            this.lblDiaChiValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblDiaChiValue.Location = new System.Drawing.Point(150, 175);
            this.lblDiaChiValue.Name = "lblDiaChiValue";
            this.lblDiaChiValue.Size = new System.Drawing.Size(201, 23);
            this.lblDiaChiValue.TabIndex = 9;
            this.lblDiaChiValue.Text = "Hà Nội, Việt Nam";

            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoDienThoai.Location = new System.Drawing.Point(300, 35);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(112, 23);
            this.lblSoDienThoai.TabIndex = 10;
            this.lblSoDienThoai.Text = "Số điện thoại:";

            // 
            // lblSoDienThoaiValue
            // 
            this.lblSoDienThoaiValue.AutoSize = true;
            this.lblSoDienThoaiValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSoDienThoaiValue.Location = new System.Drawing.Point(420, 35);
            this.lblSoDienThoaiValue.Name = "lblSoDienThoaiValue";
            this.lblSoDienThoaiValue.Size = new System.Drawing.Size(104, 23);
            this.lblSoDienThoaiValue.TabIndex = 11;
            this.lblSoDienThoaiValue.Text = "0912345678";

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(300, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";

            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblEmailValue.Location = new System.Drawing.Point(420, 70);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(127, 23);
            this.lblEmailValue.TabIndex = 13;
            this.lblEmailValue.Text = "student@email.com";

            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaLop.Location = new System.Drawing.Point(300, 105);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(66, 23);
            this.lblMaLop.TabIndex = 14;
            this.lblMaLop.Text = "Mã lớp:";

            // 
            // lblMaLopValue
            // 
            this.lblMaLopValue.AutoSize = true;
            this.lblMaLopValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblMaLopValue.Location = new System.Drawing.Point(420, 105);
            this.lblMaLopValue.Name = "lblMaLopValue";
            this.lblMaLopValue.Size = new System.Drawing.Size(55, 23);
            this.lblMaLopValue.TabIndex = 15;
            this.lblMaLopValue.Text = "CTK45";

            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnConfirm);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Location = new System.Drawing.Point(20, 390);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(560, 50);
            this.panelButtons.TabIndex = 4;

            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Red;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(350, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 40);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "XÓA";
            this.btnConfirm.UseVisualStyleBackColor = false;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(460, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.pictureBoxWarning);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xóa sinh viên";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}