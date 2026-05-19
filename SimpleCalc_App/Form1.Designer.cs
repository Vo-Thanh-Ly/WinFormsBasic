namespace SimpleCalc_App
{
    partial class Form1
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
            panel1 = new Panel();
            RunButton = new Button();
            ketQua_textBox = new TextBox();
            KetQuaLabel = new Label();
            PhepToan_comboBox = new ComboBox();
            SoBLabel = new Label();
            SoB_textBox = new TextBox();
            SoA_textBox = new TextBox();
            PhepToanLabel = new Label();
            SoALabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(RunButton);
            panel1.Controls.Add(ketQua_textBox);
            panel1.Controls.Add(KetQuaLabel);
            panel1.Controls.Add(PhepToan_comboBox);
            panel1.Controls.Add(SoBLabel);
            panel1.Controls.Add(SoB_textBox);
            panel1.Controls.Add(SoA_textBox);
            panel1.Controls.Add(PhepToanLabel);
            panel1.Controls.Add(SoALabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 240);
            panel1.TabIndex = 0;
            // 
            // RunButton
            // 
            RunButton.BackColor = SystemColors.Highlight;
            RunButton.FlatStyle = FlatStyle.Popup;
            RunButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            RunButton.ForeColor = SystemColors.ButtonFace;
            RunButton.Location = new Point(140, 186);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(105, 31);
            RunButton.TabIndex = 8;
            RunButton.Text = "Thực hiện phép tính";
            RunButton.UseVisualStyleBackColor = false;
            RunButton.Click += RunButton_Click;
            // 
            // ketQua_textBox
            // 
            ketQua_textBox.Location = new Point(154, 133);
            ketQua_textBox.Name = "ketQua_textBox";
            ketQua_textBox.Size = new Size(166, 23);
            ketQua_textBox.TabIndex = 7;
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(56, 141);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(47, 15);
            KetQuaLabel.TabIndex = 6;
            KetQuaLabel.Text = "Kết quả";
            // 
            // PhepToan_comboBox
            // 
            PhepToan_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PhepToan_comboBox.FormattingEnabled = true;
            PhepToan_comboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            PhepToan_comboBox.Location = new Point(154, 49);
            PhepToan_comboBox.Name = "PhepToan_comboBox";
            PhepToan_comboBox.Size = new Size(76, 23);
            PhepToan_comboBox.TabIndex = 5;
            // 
            // SoBLabel
            // 
            SoBLabel.AutoSize = true;
            SoBLabel.Location = new Point(56, 99);
            SoBLabel.Name = "SoBLabel";
            SoBLabel.Size = new Size(33, 15);
            SoBLabel.TabIndex = 4;
            SoBLabel.Text = "Số B:";
            // 
            // SoB_textBox
            // 
            SoB_textBox.Location = new Point(154, 91);
            SoB_textBox.Name = "SoB_textBox";
            SoB_textBox.Size = new Size(166, 23);
            SoB_textBox.TabIndex = 3;
            // 
            // SoA_textBox
            // 
            SoA_textBox.Location = new Point(154, 7);
            SoA_textBox.Name = "SoA_textBox";
            SoA_textBox.Size = new Size(166, 23);
            SoA_textBox.TabIndex = 1;
            // 
            // PhepToanLabel
            // 
            PhepToanLabel.AutoSize = true;
            PhepToanLabel.Location = new Point(56, 57);
            PhepToanLabel.Name = "PhepToanLabel";
            PhepToanLabel.Size = new Size(64, 15);
            PhepToanLabel.TabIndex = 1;
            PhepToanLabel.Text = "Phép toán:";
            // 
            // SoALabel
            // 
            SoALabel.AutoSize = true;
            SoALabel.Location = new Point(56, 15);
            SoALabel.Name = "SoALabel";
            SoALabel.Size = new Size(34, 15);
            SoALabel.TabIndex = 0;
            SoALabel.Text = "Số A:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label PhepToanLabel;
        private Label SoALabel;
        private Button RunButton;
        private TextBox ketQua_textBox;
        private Label KetQuaLabel;
        private ComboBox PhepToan_comboBox;
        private Label SoBLabel;
        private TextBox SoB_textBox;
        private TextBox SoA_textBox;
    }
}
