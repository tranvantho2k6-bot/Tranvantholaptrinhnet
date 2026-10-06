using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai54
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();

            employees = new List<Employee>();

            TaoDuLieuNhanVien();
            TaoCayThuMuc();
        }

        private void TaoDuLieuNhanVien()
        {
            employees.Add(
                new Employee(
                    "NV001",
                    "Nguyễn Văn An",
                    "Trưởng phòng",
                    new DateTime(2020, 1, 10)));

            employees.Add(
                new Employee(
                    "NV002",
                    "Trần Thị Bình",
                    "Nhân viên",
                    new DateTime(2021, 3, 15)));

            employees.Add(
                new Employee(
                    "NV003",
                    "Lê Văn Cường",
                    "Nhân viên",
                    new DateTime(2022, 5, 20)));

            employees.Add(
                new Employee(
                    "NV004",
                    "Phạm Thị Dung",
                    "Trưởng nhóm",
                    new DateTime(2019, 8, 12)));

            employees.Add(
                new Employee(
                    "NV005",
                    "Hoàng Văn Em",
                    "Nhân viên",
                    new DateTime(2023, 2, 5)));

            employees.Add(
                new Employee(
                    "NV006",
                    "Vũ Thị Hoa",
                    "Nhân viên",
                    new DateTime(2022, 9, 10)));

            employees.Add(
                new Employee(
                    "NV007",
                    "Đỗ Văn Khánh",
                    "Trưởng phòng",
                    new DateTime(2018, 6, 18)));

            employees.Add(
                new Employee(
                    "NV008",
                    "Nguyễn Thị Lan",
                    "Nhân viên",
                    new DateTime(2021, 11, 25)));
        }

        private void TaoCayThuMuc()
        {
            tvDepartments.Nodes.Clear();

            TreeNode company =
                new TreeNode("Công ty");

            TreeNode kinhDoanh =
                new TreeNode("Phòng Kinh doanh");

            TreeNode nhomKinhDoanh =
                new TreeNode("Nhóm Kinh doanh 1");

            TreeNode nhomKinhDoanh2 =
                new TreeNode("Nhóm Kinh doanh 2");

            kinhDoanh.Nodes.Add(nhomKinhDoanh);
            kinhDoanh.Nodes.Add(nhomKinhDoanh2);

            TreeNode kyThuat =
                new TreeNode("Phòng Kỹ thuật");

            TreeNode nhomKyThuat =
                new TreeNode("Nhóm Kỹ thuật 1");

            TreeNode nhomKyThuat2 =
                new TreeNode("Nhóm Kỹ thuật 2");

            kyThuat.Nodes.Add(nhomKyThuat);
            kyThuat.Nodes.Add(nhomKyThuat2);

            TreeNode nhanSu =
                new TreeNode("Phòng Nhân sự");

            TreeNode nhomNhanSu =
                new TreeNode("Nhóm Nhân sự");

            nhanSu.Nodes.Add(nhomNhanSu);

            company.Nodes.Add(kinhDoanh);
            company.Nodes.Add(kyThuat);
            company.Nodes.Add(nhanSu);

            tvDepartments.Nodes.Add(company);

            company.Expand();
            kinhDoanh.Expand();
            kyThuat.Expand();
            nhanSu.Expand();

            tvDepartments.SelectedNode = company;

            HienThiNhanVien("Công ty");
        }

        private void tvDepartments_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            HienThiNhanVien(e.Node.Text);
        }

        private void HienThiNhanVien(string tenNode)
        {
            lsvEmployees.Items.Clear();

            List<Employee> danhSach =
                new List<Employee>();

            if (tenNode == "Công ty")
            {
                danhSach.AddRange(employees);
            }
            else if (tenNode == "Phòng Kinh doanh")
            {
                danhSach.Add(employees[0]);
                danhSach.Add(employees[1]);
                danhSach.Add(employees[2]);
            }
            else if (tenNode == "Nhóm Kinh doanh 1")
            {
                danhSach.Add(employees[0]);
                danhSach.Add(employees[1]);
            }
            else if (tenNode == "Nhóm Kinh doanh 2")
            {
                danhSach.Add(employees[2]);
            }
            else if (tenNode == "Phòng Kỹ thuật")
            {
                danhSach.Add(employees[3]);
                danhSach.Add(employees[4]);
                danhSach.Add(employees[5]);
            }
            else if (tenNode == "Nhóm Kỹ thuật 1")
            {
                danhSach.Add(employees[3]);
                danhSach.Add(employees[4]);
            }
            else if (tenNode == "Nhóm Kỹ thuật 2")
            {
                danhSach.Add(employees[5]);
            }
            else if (tenNode == "Phòng Nhân sự")
            {
                danhSach.Add(employees[6]);
                danhSach.Add(employees[7]);
            }
            else if (tenNode == "Nhóm Nhân sự")
            {
                danhSach.Add(employees[6]);
                danhSach.Add(employees[7]);
            }

            foreach (Employee employee in danhSach)
            {
                ListViewItem item =
                    new ListViewItem(employee.MaNV);

                item.SubItems.Add(employee.HoTen);
                item.SubItems.Add(employee.ChucVu);
                item.SubItems.Add(
                    employee.NgayVaoLam.ToString("dd/MM/yyyy"));

                item.ImageIndex = 0;

                lsvEmployees.Items.Add(item);
            }
        }

        private void cboView_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboView.SelectedItem == null)
                return;

            string view =
                cboView.SelectedItem.ToString();

            if (view == "Details")
            {
                lsvEmployees.View =
                    View.Details;
            }
            else if (view == "SmallIcon")
            {
                lsvEmployees.View =
                    View.SmallIcon;
            }
            else if (view == "LargeIcon")
            {
                lsvEmployees.View =
                    View.LargeIcon;
            }
            else if (view == "Tile")
            {
                lsvEmployees.View =
                    View.Tile;
            }
        }
    }
}