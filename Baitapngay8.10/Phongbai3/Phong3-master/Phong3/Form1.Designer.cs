namespace Phong3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ComboBox comboUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.GroupBox groupRight;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colPrice;

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
            groupLeft = new GroupBox();
            labelCode = new Label();
            textCode = new TextBox();
            labelName = new Label();
            textName = new TextBox();
            labelUnit = new Label();
            comboUnit = new ComboBox();
            labelPrice = new Label();
            textPrice = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClearAll = new Button();
            groupRight = new GroupBox();
            listViewItems = new ListView();
            colCode = new ColumnHeader();
            colName = new ColumnHeader();
            colUnit = new ColumnHeader();
            colPrice = new ColumnHeader();
            groupLeft.SuspendLayout();
            groupRight.SuspendLayout();
            SuspendLayout();
            // 
            // groupLeft
            // 
            groupLeft.Controls.Add(labelCode);
            groupLeft.Controls.Add(textCode);
            groupLeft.Controls.Add(labelName);
            groupLeft.Controls.Add(textName);
            groupLeft.Controls.Add(labelUnit);
            groupLeft.Controls.Add(comboUnit);
            groupLeft.Controls.Add(labelPrice);
            groupLeft.Controls.Add(textPrice);
            groupLeft.Controls.Add(buttonAdd);
            groupLeft.Controls.Add(buttonUpdate);
            groupLeft.Controls.Add(buttonDelete);
            groupLeft.Controls.Add(buttonClearAll);
            groupLeft.Location = new Point(12, 12);
            groupLeft.Name = "groupLeft";
            groupLeft.Size = new Size(320, 426);
            groupLeft.TabIndex = 0;
            groupLeft.TabStop = false;
            groupLeft.Text = "Input";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(12, 28);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(72, 20);
            labelCode.TabIndex = 0;
            labelCode.Text = "Mã vật tư";
            // 
            // textCode
            // 
            textCode.Location = new Point(110, 25);
            textCode.Name = "textCode";
            textCode.Size = new Size(190, 27);
            textCode.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(74, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Tên vật tư";
            // 
            // textName
            // 
            textName.Location = new Point(110, 65);
            textName.Name = "textName";
            textName.Size = new Size(190, 27);
            textName.TabIndex = 3;
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(12, 108);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(81, 20);
            labelUnit.TabIndex = 4;
            labelUnit.Text = "Đơn vị tính";
            // 
            // comboUnit
            // 
            comboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUnit.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            comboUnit.Location = new Point(110, 105);
            comboUnit.Name = "comboUnit";
            comboUnit.Size = new Size(190, 28);
            comboUnit.TabIndex = 5;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 148);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(62, 20);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Đơn giá";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(110, 145);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(190, 27);
            textPrice.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(15, 190);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 30);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Thêm mới";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(180, 190);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 30);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(15, 230);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 30);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Xóa dòng";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.Location = new Point(180, 230);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(120, 30);
            buttonClearAll.TabIndex = 11;
            buttonClearAll.Text = "Xóa toàn bộ";
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // groupRight
            // 
            groupRight.Controls.Add(listViewItems);
            groupRight.Location = new Point(344, 12);
            groupRight.Name = "groupRight";
            groupRight.Size = new Size(444, 426);
            groupRight.TabIndex = 1;
            groupRight.TabStop = false;
            groupRight.Text = "Danh sách";
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { colCode, colName, colUnit, colPrice });
            listViewItems.FullRowSelect = true;
            listViewItems.Location = new Point(12, 22);
            listViewItems.MultiSelect = false;
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(420, 390);
            listViewItems.TabIndex = 0;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            listViewItems.SelectedIndexChanged += listViewItems_SelectedIndexChanged;
            // 
            // colCode
            // 
            colCode.Text = "Mã VT";
            colCode.Width = 80;
            // 
            // colName
            // 
            colName.Text = "Tên VT";
            colName.Width = 160;
            // 
            // colUnit
            // 
            colUnit.Text = "Đơn vị";
            colUnit.Width = 80;
            // 
            // colPrice
            // 
            colPrice.Text = "Đơn giá";
            colPrice.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupLeft);
            Controls.Add(groupRight);
            Name = "Form1";
            Text = "Quản lý Vật tư / Linh kiện";
            groupLeft.ResumeLayout(false);
            groupLeft.PerformLayout();
            groupRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
