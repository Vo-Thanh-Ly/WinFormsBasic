namespace StudentManagementBasic.Forms
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            tenSinhVien_Lable = new Label();
            tenSinhVien_textBox = new TextBox();
            themSinhVien_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 306);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // tenSinhVien_Lable
            // 
            tenSinhVien_Lable.AutoSize = true;
            tenSinhVien_Lable.Location = new Point(106, 59);
            tenSinhVien_Lable.Name = "tenSinhVien_Lable";
            tenSinhVien_Lable.Size = new Size(79, 15);
            tenSinhVien_Lable.TabIndex = 1;
            tenSinhVien_Lable.Text = "Tên sinh viên:";
            // 
            // tenSinhVien_textBox
            // 
            tenSinhVien_textBox.Location = new Point(191, 56);
            tenSinhVien_textBox.Name = "tenSinhVien_textBox";
            tenSinhVien_textBox.Size = new Size(325, 23);
            tenSinhVien_textBox.TabIndex = 2;
            // 
            // themSinhVien_button
            // 
            themSinhVien_button.BackColor = SystemColors.MenuHighlight;
            themSinhVien_button.FlatStyle = FlatStyle.Popup;
            themSinhVien_button.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themSinhVien_button.ForeColor = SystemColors.ButtonHighlight;
            themSinhVien_button.Location = new Point(536, 56);
            themSinhVien_button.Name = "themSinhVien_button";
            themSinhVien_button.Size = new Size(75, 23);
            themSinhVien_button.TabIndex = 3;
            themSinhVien_button.Text = "Thêm";
            themSinhVien_button.UseVisualStyleBackColor = false;
            themSinhVien_button.Click += themSinhVien_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(themSinhVien_button);
            Controls.Add(tenSinhVien_textBox);
            Controls.Add(tenSinhVien_Lable);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Thêm xóa sinh viên";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label tenSinhVien_Lable;
        private TextBox tenSinhVien_textBox;
        private Button themSinhVien_button;
    }
}
