using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai53
{
    partial class Form1
    {
        private GroupBox grpProduct;
        private GroupBox grpFunction;

        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblSearch;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtSearch;

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnClearSearch;

        private DataGridView dgvProducts;

        private void InitializeComponent()
        {
            grpProduct = new GroupBox();
            grpFunction = new GroupBox();

            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblSearch = new Label();

            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            txtSearch = new TextBox();

            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnClearSearch = new Button();

            dgvProducts = new DataGridView();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(900, 600);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Bài 5.3 - Quản lý sản phẩm";

            // =========================
            // GROUP SẢN PHẨM
            // =========================

            grpProduct.Text = "Thông tin sản phẩm";

            grpProduct.Location =
                new Point(20, 20);

            grpProduct.Size =
                new Size(860, 150);

            // Mã SP

            lblProductId.Text = "Mã SP:";
            lblProductId.Location =
                new Point(20, 30);

            lblProductId.Size =
                new Size(100, 25);

            txtProductId.Location =
                new Point(120, 27);

            txtProductId.Size =
                new Size(220, 25);

            // Tên SP

            lblProductName.Text = "Tên SP:";
            lblProductName.Location =
                new Point(20, 70);

            lblProductName.Size =
                new Size(100, 25);

            txtProductName.Location =
                new Point(120, 67);

            txtProductName.Size =
                new Size(220, 25);

            // Đơn giá

            lblUnitPrice.Text = "Đơn giá:";
            lblUnitPrice.Location =
                new Point(390, 30);

            lblUnitPrice.Size =
                new Size(100, 25);

            txtUnitPrice.Location =
                new Point(490, 27);

            txtUnitPrice.Size =
                new Size(220, 25);

            // Số lượng

            lblQuantity.Text = "Số lượng:";
            lblQuantity.Location =
                new Point(390, 70);

            lblQuantity.Size =
                new Size(100, 25);

            txtQuantity.Location =
                new Point(490, 67);

            txtQuantity.Size =
                new Size(220, 25);

            // Danh mục

            lblCategory.Text = "Danh mục:";
            lblCategory.Location =
                new Point(20, 110);

            lblCategory.Size =
                new Size(100, 25);

            txtCategory.Location =
                new Point(120, 107);

            txtCategory.Size =
                new Size(220, 25);

            grpProduct.Controls.Add(lblProductId);
            grpProduct.Controls.Add(txtProductId);

            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(txtProductName);

            grpProduct.Controls.Add(lblUnitPrice);
            grpProduct.Controls.Add(txtUnitPrice);

            grpProduct.Controls.Add(lblQuantity);
            grpProduct.Controls.Add(txtQuantity);

            grpProduct.Controls.Add(lblCategory);
            grpProduct.Controls.Add(txtCategory);

            // =========================
            // GROUP CHỨC NĂNG
            // =========================

            grpFunction.Text = "Chức năng";

            grpFunction.Location =
                new Point(20, 185);

            grpFunction.Size =
                new Size(860, 75);

            // Thêm

            btnAdd.Text = "Thêm";

            btnAdd.Location =
                new Point(20, 28);

            btnAdd.Size =
                new Size(100, 30);

            btnAdd.Click += btnAdd_Click;

            // Sửa

            btnEdit.Text = "Sửa";

            btnEdit.Location =
                new Point(135, 28);

            btnEdit.Size =
                new Size(100, 30);

            btnEdit.Click += btnEdit_Click;

            // Xóa

            btnDelete.Text = "Xóa";

            btnDelete.Location =
                new Point(250, 28);

            btnDelete.Size =
                new Size(100, 30);

            btnDelete.Click += btnDelete_Click;

            // Tìm kiếm

            lblSearch.Text = "Tìm tên SP:";

            lblSearch.Location =
                new Point(390, 31);

            lblSearch.Size =
                new Size(80, 25);

            txtSearch.Location =
                new Point(475, 28);

            txtSearch.Size =
                new Size(150, 25);

            btnSearch.Text = "Tìm kiếm";

            btnSearch.Location =
                new Point(635, 28);

            btnSearch.Size =
                new Size(90, 30);

            btnSearch.Click += btnSearch_Click;

            btnClearSearch.Text = "Hiện tất cả";

            btnClearSearch.Location =
                new Point(735, 28);

            btnClearSearch.Size =
                new Size(100, 30);

            btnClearSearch.Click +=
                btnClearSearch_Click;

            grpFunction.Controls.Add(btnAdd);
            grpFunction.Controls.Add(btnEdit);
            grpFunction.Controls.Add(btnDelete);
            grpFunction.Controls.Add(lblSearch);
            grpFunction.Controls.Add(txtSearch);
            grpFunction.Controls.Add(btnSearch);
            grpFunction.Controls.Add(btnClearSearch);

            // =========================
            // DATAGRIDVIEW
            // =========================

            dgvProducts.Location =
                new Point(20, 280);

            dgvProducts.Size =
                new Size(860, 290);

            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ReadOnly = true;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.CellClick +=
                dgvProducts_CellClick;

            // =========================
            // ADD CONTROL
            // =========================

            Controls.Add(grpProduct);
            Controls.Add(grpFunction);
            Controls.Add(dgvProducts);

            ResumeLayout(false);
        }
    }
}