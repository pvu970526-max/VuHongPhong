namespace Phong1
{
    partial class Form1
    {
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;

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
            labelPrice = new Label();
            txtPrice = new TextBox();
            labelQuantity = new Label();
            txtQuantity = new TextBox();
            labelDiscount = new Label();
            txtDiscount = new TextBox();
            labelTotalText = new Label();
            labelTotalValue = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(24, 20);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(116, 20);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Đơn giá dịch vụ:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 16);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 1;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(24, 60);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(114, 20);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "Số lượng khách:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(150, 56);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 27);
            txtQuantity.TabIndex = 3;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(24, 100);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(101, 20);
            labelDiscount.TabIndex = 4;
            labelDiscount.Text = "Mã giảm (%) :";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(150, 96);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(150, 27);
            txtDiscount.TabIndex = 5;
            // 
            // labelTotalText
            // 
            labelTotalText.AutoSize = true;
            labelTotalText.Location = new Point(24, 140);
            labelTotalText.Name = "labelTotalText";
            labelTotalText.Size = new Size(121, 20);
            labelTotalText.TabIndex = 6;
            labelTotalText.Text = "Tổng thanh toán:";
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Location = new Point(150, 140);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(40, 20);
            labelTotalValue.TabIndex = 7;
            labelTotalValue.Text = "VNĐ";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 180);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 9;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 240);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(labelTotalValue);
            Controls.Add(labelTotalText);
            Controls.Add(txtDiscount);
            Controls.Add(labelDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(txtPrice);
            Controls.Add(labelPrice);
            Name = "Form1";
            Text = "Service Charge Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
