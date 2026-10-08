namespace Phong1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            // Validate price
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !double.TryParse(txtPrice.Text, out double price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            // Validate quantity
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng khách hợp lệ (số nguyên không âm).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Validate discount (can be empty -> treated as 0)
            double discount = 0;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                if (!double.TryParse(txtDiscount.Text, out discount) || discount < 0 || discount > 100)
                {
                    MessageBox.Show("Vui lòng nhập Mã giảm hợp lệ (0-100).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
            }

            double total = (price * quantity) * (100.0 - discount) / 100.0;
            labelTotalValue.Text = total.ToString("C2");
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            labelTotalValue.Text = "0.00";
            txtPrice.Focus();
        }
    }
}
