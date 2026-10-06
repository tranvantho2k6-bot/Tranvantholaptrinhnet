using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai54
{
    partial class Form1
    {
        private SplitContainer splitContainer1;

        private TreeView tvDepartments;

        private ListView lsvEmployees;

        private ImageList imageList1;

        private ComboBox cboView;

        private Label lblView;

        private ColumnHeader colMaNV;
        private ColumnHeader colHoTen;
        private ColumnHeader colChucVu;
        private ColumnHeader colNgayVaoLam;

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();

            tvDepartments = new TreeView();

            lsvEmployees = new ListView();

            imageList1 = new ImageList();

            cboView = new ComboBox();

            lblView = new Label();

            colMaNV = new ColumnHeader();
            colHoTen = new ColumnHeader();
            colChucVu = new ColumnHeader();
            colNgayVaoLam = new ColumnHeader();

            ((System.ComponentModel.ISupportInitialize)
                (splitContainer1)).BeginInit();

            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1000, 600);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Bài 5.4 - Quản lý tập tin";

            // =========================
            // SPLIT CONTAINER
            // =========================

            splitContainer1.Dock =
                DockStyle.Fill;

            splitContainer1.Location =
                new Point(0, 0);

            splitContainer1.Size =
                new Size(1000, 600);

            splitContainer1.SplitterDistance =
                280;

            // =========================
            // TREEVIEW
            // =========================

            tvDepartments.Dock =
                DockStyle.Fill;

            tvDepartments.Font =
                new Font("Segoe UI", 10F);

            tvDepartments.HideSelection =
                false;

            tvDepartments.AfterSelect +=
                tvDepartments_AfterSelect;

            splitContainer1.Panel1.Controls.Add(
                tvDepartments);

            // =========================
            // COMBOBOX CHẾ ĐỘ XEM
            // =========================

            lblView.Text =
                "Chế độ xem:";

            lblView.Location =
                new Point(15, 15);

            lblView.Size =
                new Size(90, 25);

            cboView.Location =
                new Point(105, 12);

            cboView.Size =
                new Size(150, 25);

            cboView.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboView.Items.Add("Details");
            cboView.Items.Add("SmallIcon");
            cboView.Items.Add("LargeIcon");
            cboView.Items.Add("Tile");

            cboView.SelectedIndex =
                0;

            cboView.SelectedIndexChanged +=
                cboView_SelectedIndexChanged;

            // =========================
            // IMAGELIST
            // =========================

            imageList1.ImageSize =
                new Size(32, 32);

            imageList1.Images.Add(
                SystemIcons.Application.ToBitmap());

            imageList1.Images.Add(
                SystemIcons.Information.ToBitmap());

            // =========================
            // LISTVIEW
            // =========================

            lsvEmployees.Location =
                new Point(15, 55);

            lsvEmployees.Size =
                new Size(680, 500);

            lsvEmployees.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            lsvEmployees.View =
                View.Details;

            lsvEmployees.FullRowSelect =
                true;

            lsvEmployees.GridLines =
                true;

            lsvEmployees.MultiSelect =
                false;

            lsvEmployees.SmallImageList =
                imageList1;

            lsvEmployees.LargeImageList =
                imageList1;

            lsvEmployees.Columns.AddRange(
                new ColumnHeader[]
                {
                    colMaNV,
                    colHoTen,
                    colChucVu,
                    colNgayVaoLam
                });

            // Cột Mã NV

            colMaNV.Text =
                "Mã NV";

            colMaNV.Width =
                100;

            // Cột Họ tên

            colHoTen.Text =
                "Họ Tên";

            colHoTen.Width =
                200;

            // Cột Chức vụ

            colChucVu.Text =
                "Chức vụ";

            colChucVu.Width =
                160;

            // Cột Ngày vào làm

            colNgayVaoLam.Text =
                "Ngày vào làm";

            colNgayVaoLam.Width =
                150;

            splitContainer1.Panel2.Controls.Add(
                lsvEmployees);

            splitContainer1.Panel2.Controls.Add(
                cboView);

            splitContainer1.Panel2.Controls.Add(
                lblView);

            // =========================
            // ADD SPLIT CONTAINER
            // =========================

            Controls.Add(splitContainer1);

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (splitContainer1)).EndInit();

            splitContainer1.ResumeLayout(false);

            ResumeLayout(false);
        }
    }
}