namespace Phong3
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var code = textCode.Text.Trim();
            var name = textName.Text.Trim();
            var unit = comboUnit.SelectedItem as string ?? string.Empty;
            var priceText = textPrice.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã vật tư không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (items.Any(x => x.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out var price))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var it = new Item { Code = code, Name = name, Unit = unit, Price = price };
            items.Add(it);
            AddListViewItem(it);
            ClearInput();
        }

        private void AddListViewItem(Item it)
        {
            var lvi = new ListViewItem(it.Code);
            lvi.SubItems.Add(it.Name);
            lvi.SubItems.Add(it.Unit);
            lvi.SubItems.Add(it.Price.ToString("N2"));
            lvi.Tag = it;
            listViewItems.Items.Add(lvi);
        }

        private void ClearInput()
        {
            textCode.Text = string.Empty;
            textName.Text = string.Empty;
            comboUnit.SelectedIndex = -1;
            textPrice.Text = string.Empty;
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
                return;
            var lvi = listViewItems.SelectedItems[0];
            if (lvi.Tag is Item it)
            {
                textCode.Text = it.Code;
                textName.Text = it.Name;
                comboUnit.SelectedItem = it.Unit;
                textPrice.Text = it.Price.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = listViewItems.SelectedItems[0];
            if (!(selected.Tag is Item it))
                return;

            var newCode = textCode.Text.Trim();
            var newName = textName.Text.Trim();
            var newUnit = comboUnit.SelectedItem as string ?? string.Empty;
            if (!decimal.TryParse(textPrice.Text.Trim(), out var newPrice))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If code changed, ensure uniqueness
            if (!it.Code.Equals(newCode, StringComparison.OrdinalIgnoreCase) && items.Any(x => x.Code.Equals(newCode, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư mới đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            it.Code = newCode;
            it.Name = newName;
            it.Unit = newUnit;
            it.Price = newPrice;

            // update listview
            selected.Text = it.Code;
            selected.SubItems[1].Text = it.Name;
            selected.SubItems[2].Text = it.Unit;
            selected.SubItems[3].Text = it.Price.ToString("N2");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            var lvi = listViewItems.SelectedItems[0];
            if (lvi.Tag is Item it)
            {
                items.Remove(it);
            }
            listViewItems.Items.Remove(lvi);
            ClearInput();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            items.Clear();
            listViewItems.Items.Clear();
            ClearInput();
        }

        private class Item
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Unit { get; set; }
            public decimal Price { get; set; }
        }
    }
}
