namespace Phong2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
            lblTicketID = new Label();
            txtTicketID = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            grpPriority = new GroupBox();
            rbHigh = new RadioButton();
            rbMedium = new RadioButton();
            rbLow = new RadioButton();
            lblType = new Label();
            cbType = new ComboBox();
            lblDevices = new Label();
            chkDesktop = new CheckBox();
            chkLaptop = new CheckBox();
            chkPrinter = new CheckBox();
            chkPhone = new CheckBox();
            pbError = new PictureBox();
            btnLoadImage = new Button();
            btnSubmit = new Button();
            btnReset = new Button();
            openFileDialog1 = new OpenFileDialog();
            grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbError).BeginInit();
            SuspendLayout();
            // 
            // lblTicketID
            // 
            lblTicketID.AutoSize = true;
            lblTicketID.Location = new Point(20, 20);
            lblTicketID.Name = "lblTicketID";
            lblTicketID.Size = new Size(74, 20);
            lblTicketID.TabIndex = 0;
            lblTicketID.Text = "Mã phiếu:";
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(130, 13);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(200, 27);
            txtTicketID.TabIndex = 1;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(20, 55);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(108, 20);
            lblRequester.TabIndex = 2;
            lblRequester.Text = "Người yêu cầu:";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(130, 48);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(200, 27);
            txtRequester.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 90);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(130, 85);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 5;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(rbHigh);
            grpPriority.Controls.Add(rbMedium);
            grpPriority.Controls.Add(rbLow);
            grpPriority.Location = new Point(350, 16);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(200, 100);
            grpPriority.TabIndex = 6;
            grpPriority.TabStop = false;
            grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rbHigh
            // 
            rbHigh.AutoSize = true;
            rbHigh.Location = new Point(10, 70);
            rbHigh.Name = "rbHigh";
            rbHigh.Size = new Size(91, 24);
            rbHigh.TabIndex = 2;
            rbHigh.Text = "Khẩn cấp";
            rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(10, 45);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(100, 24);
            rbMedium.TabIndex = 1;
            rbMedium.Text = "Trung bình";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLow
            // 
            rbLow.AutoSize = true;
            rbLow.Location = new Point(10, 20);
            rbLow.Name = "rbLow";
            rbLow.Size = new Size(63, 24);
            rbLow.TabIndex = 0;
            rbLow.Text = "Thấp";
            rbLow.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 130);
            lblType.Name = "lblType";
            lblType.Size = new Size(79, 20);
            lblType.TabIndex = 7;
            lblType.Text = "Loại sự cố:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cbType.Location = new Point(130, 127);
            cbType.Name = "cbType";
            cbType.Size = new Size(200, 28);
            cbType.TabIndex = 8;
            // 
            // lblDevices
            // 
            lblDevices.AutoSize = true;
            lblDevices.Location = new Point(20, 170);
            lblDevices.Name = "lblDevices";
            lblDevices.Size = new Size(137, 20);
            lblDevices.TabIndex = 9;
            lblDevices.Text = "Thiết bị ảnh hưởng:";
            lblDevices.Click += lblDevices_Click;
            // 
            // chkDesktop
            // 
            chkDesktop.AutoSize = true;
            chkDesktop.Location = new Point(163, 165);
            chkDesktop.Name = "chkDesktop";
            chkDesktop.Size = new Size(117, 24);
            chkDesktop.TabIndex = 10;
            chkDesktop.Text = "Máy tính bàn";
            chkDesktop.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(163, 252);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 11;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            chkPrinter.AutoSize = true;
            chkPrinter.Location = new Point(163, 195);
            chkPrinter.Name = "chkPrinter";
            chkPrinter.Size = new Size(75, 24);
            chkPrinter.TabIndex = 12;
            chkPrinter.Text = "Máy in";
            chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.Location = new Point(163, 225);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(100, 24);
            chkPhone.TabIndex = 13;
            chkPhone.Text = "Điện thoại";
            chkPhone.UseVisualStyleBackColor = true;
            // 
            // pbError
            // 
            pbError.BorderStyle = BorderStyle.FixedSingle;
            pbError.Location = new Point(350, 122);
            pbError.Name = "pbError";
            pbError.Size = new Size(200, 160);
            pbError.SizeMode = PictureBoxSizeMode.StretchImage;
            pbError.TabIndex = 14;
            pbError.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(350, 300);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(200, 25);
            btnLoadImage.TabIndex = 15;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += BtnLoadImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 30);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Gửi yêu cầu";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(190, 300);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 30);
            btnReset.TabIndex = 17;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 350);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(btnLoadImage);
            Controls.Add(pbError);
            Controls.Add(chkPhone);
            Controls.Add(chkPrinter);
            Controls.Add(chkLaptop);
            Controls.Add(chkDesktop);
            Controls.Add(lblDevices);
            Controls.Add(cbType);
            Controls.Add(lblType);
            Controls.Add(grpPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequester);
            Controls.Add(lblRequester);
            Controls.Add(txtTicketID);
            Controls.Add(lblTicketID);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Tiếp nhận & Phân loại sự cố IT";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
