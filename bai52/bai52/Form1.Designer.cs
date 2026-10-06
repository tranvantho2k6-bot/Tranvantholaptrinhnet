using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai52
{
    partial class Form1
    {
        private Label lblCategory;
        private ComboBox cboCategory;

        private Label lblAvailable;
        private Label lblSelected;

        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;

        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;

        private GroupBox grpPayment;

        private Label lblTotal;
        private Label lblDiscount;
        private Label lblPayment;

        private TextBox txtTotal;
        private TextBox txtDiscount;
        private TextBox txtPayment;

        private void InitializeComponent()
        {
            lblCategory = new Label();
            cboCategory = new ComboBox();

            lblAvailable = new Label();
            lblSelected = new Label();

            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();

            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();

            grpPayment = new GroupBox();

            lblTotal = new Label();
            lblDiscount = new Label();
            lblPayment = new Label();

            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtPayment = new TextBox();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(760, 550);

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Bài 5.2 - Bảng tính tiền dịch vụ";

            // =========================
            // COMBOBOX
            // =========================

            lblCategory.Text = "Loại dịch vụ:";
            lblCategory.Location = new Point(30, 25);
            lblCategory.Size = new Size(100, 25);

            cboCategory.Location = new Point(140, 22);
            cboCategory.Size = new Size(250, 25);

            cboCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboCategory.Items.Add("Khám bệnh");
            cboCategory.Items.Add("Xét nghiệm");
            cboCategory.Items.Add("Chụp X-Quang");
            cboCategory.Items.Add("Vắc-xin");

            cboCategory.SelectedIndexChanged +=
                cboCategory_SelectedIndexChanged;

            // =========================
            // LISTBOX TRÁI
            // =========================

            lblAvailable.Text = "Danh sách dịch vụ:";
            lblAvailable.Location = new Point(30, 75);
            lblAvailable.Size = new Size(220, 25);

            lstAvailableServices.Location =
                new Point(30, 105);

            lstAvailableServices.Size =
                new Size(280, 230);

            lstAvailableServices.DoubleClick +=
                lstAvailableServices_DoubleClick;

            // =========================
            // BUTTON >
            // =========================

            btnSelect.Text = ">";
            btnSelect.Location = new Point(330, 135);
            btnSelect.Size = new Size(70, 40);

            btnSelect.Click += btnSelect_Click;

            // =========================
            // BUTTON <
            // =========================

            btnRemove.Text = "<";
            btnRemove.Location = new Point(330, 190);
            btnRemove.Size = new Size(70, 40);

            btnRemove.Click += btnRemove_Click;

            // =========================
            // BUTTON <<
            // =========================

            btnClearAll.Text = "<<";
            btnClearAll.Location = new Point(330, 245);
            btnClearAll.Size = new Size(70, 40);

            btnClearAll.Click += btnClearAll_Click;

            // =========================
            // LISTBOX PHẢI
            // =========================

            lblSelected.Text = "Dịch vụ đã chọn:";
            lblSelected.Location = new Point(430, 75);
            lblSelected.Size = new Size(220, 25);

            lstSelectedServices.Location =
                new Point(430, 105);

            lstSelectedServices.Size =
                new Size(280, 230);

            // =========================
            // GROUP TÍNH TIỀN
            // =========================

            grpPayment.Text = "Thông tin thanh toán";

            grpPayment.Location =
                new Point(30, 365);

            grpPayment.Size =
                new Size(680, 145);

            // Tổng tiền

            lblTotal.Text = "Tổng tiền chưa giảm:";
            lblTotal.Location =
                new Point(20, 30);

            lblTotal.Size =
                new Size(150, 25);

            txtTotal.Location =
                new Point(180, 27);

            txtTotal.Size =
                new Size(180, 25);

            txtTotal.ReadOnly = true;

            // Chiết khấu

            lblDiscount.Text = "Tỷ lệ chiết khấu (%):";
            lblDiscount.Location =
                new Point(20, 65);

            lblDiscount.Size =
                new Size(150, 25);

            txtDiscount.Location =
                new Point(180, 62);

            txtDiscount.Size =
                new Size(180, 25);

            txtDiscount.Text = "0";

            txtDiscount.TextChanged +=
                txtDiscount_TextChanged;

            // Thành tiền

            lblPayment.Text = "Thành tiền thanh toán:";
            lblPayment.Location =
                new Point(390, 30);

            lblPayment.Size =
                new Size(150, 25);

            txtPayment.Location =
                new Point(540, 27);

            txtPayment.Size =
                new Size(120, 25);

            txtPayment.ReadOnly = true;

            // =========================
            // ADD CONTROLS
            // =========================

            grpPayment.Controls.Add(lblTotal);
            grpPayment.Controls.Add(txtTotal);

            grpPayment.Controls.Add(lblDiscount);
            grpPayment.Controls.Add(txtDiscount);

            grpPayment.Controls.Add(lblPayment);
            grpPayment.Controls.Add(txtPayment);

            Controls.Add(lblCategory);
            Controls.Add(cboCategory);

            Controls.Add(lblAvailable);
            Controls.Add(lstAvailableServices);

            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);

            Controls.Add(lblSelected);
            Controls.Add(lstSelectedServices);

            Controls.Add(grpPayment);

            ResumeLayout(false);
        }
    }
}