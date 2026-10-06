using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai53
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            products = new List<Product>();
            bindingSource = new BindingSource();

            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal donGia;
            int soLuong;

            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SP!");
                txtProductId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên SP!");
                txtProductName.Focus();
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                txtQuantity.Focus();
                return;
            }

            Product product = new Product();

            product.ProductId = txtProductId.Text;
            product.ProductName = txtProductName.Text;
            product.UnitPrice = donGia;
            product.Quantity = soLuong;
            product.Category = txtCategory.Text;

            products.Add(product);

            bindingSource.ResetBindings(false);

            XoaTrang();

            MessageBox.Show(
                "Thêm sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Product product =
                dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;

            if (product == null)
                return;

            txtProductId.Text = product.ProductId;
            txtProductName.Text = product.ProductName;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            txtCategory.Text = product.Category;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            Product product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            decimal donGia;
            int soLuong;

            if (!decimal.TryParse(txtUnitPrice.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            product.ProductId = txtProductId.Text;
            product.ProductName = txtProductName.Text;
            product.UnitPrice = donGia;
            product.Quantity = soLuong;
            product.Category = txtCategory.Text;

            bindingSource.ResetBindings(false);

            MessageBox.Show("Sửa sản phẩm thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            Product product =
                dgvProducts.CurrentRow.DataBoundItem as Product;

            if (product == null)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                products.Remove(product);

                bindingSource.ResetBindings(false);

                XoaTrang();

                MessageBox.Show("Xóa sản phẩm thành công!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                bindingSource.DataSource = products;
            }
            else
            {
                List<Product> ketQua =
                    new List<Product>();

                foreach (Product product in products)
                {
                    if (product.ProductName
                        .ToLower()
                        .Contains(keyword.ToLower()))
                    {
                        ketQua.Add(product);
                    }
                }

                bindingSource.DataSource = ketQua;
            }

            dgvProducts.DataSource = bindingSource;
            bindingSource.ResetBindings(false);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            bindingSource.DataSource = products;

            dgvProducts.DataSource = bindingSource;

            bindingSource.ResetBindings(false);
        }

        private void XoaTrang()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();

            txtProductId.Focus();
        }
    }
}