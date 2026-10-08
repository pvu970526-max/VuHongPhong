namespace Phong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(openFileDialog1.FileName);
                    pbError.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var id = txtTicketID.Text.Trim();
            var requester = txtRequester.Text.Trim();
            var date = dtpDate.Value.ToString("yyyy-MM-dd");

            string priority = "";
            if (rbLow.Checked) priority = "Thấp";
            else if (rbMedium.Checked) priority = "Trung bình";
            else if (rbHigh.Checked) priority = "Khẩn cấp";

            var type = cbType.SelectedItem?.ToString() ?? "(Chưa chọn)";

            var devices = new List<string>();
            if (chkDesktop.Checked) devices.Add("Máy tính bàn");
            if (chkLaptop.Checked) devices.Add("Laptop");
            if (chkPrinter.Checked) devices.Add("Máy in");
            if (chkPhone.Checked) devices.Add("Điện thoại");
            var devicesText = devices.Count > 0 ? string.Join(", ", devices) : "(Chưa chọn)";

            var hasImage = pbError.Image != null ? "Có" : "Không";

            var summary = $"Mã phiếu: {id}\nNgười yêu cầu: {requester}\nNgày: {date}\nMức độ: {priority}\nLoại: {type}\nThiết bị: {devicesText}\nẢnh đính kèm: {hasImage}";

            MessageBox.Show(summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            txtRequester.Clear();
            dtpDate.Value = DateTime.Today;
            rbLow.Checked = false;
            rbMedium.Checked = false;
            rbHigh.Checked = false;
            cbType.SelectedIndex = -1;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;
            if (pbError.Image != null)
            {
                pbError.Image.Dispose();
                pbError.Image = null;
            }
        }

        private void lblDevices_Click(object sender, EventArgs e)
        {

        }
    }
}
