using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool hopLe = true;

            epCheck.Clear();

            // Kiểm tra tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống");
                hopLe = false;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống");
                hopLe = false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                epCheck.SetError(
                    txtConfirmPassword,
                    "Mật khẩu xác nhận không khớp"
                );

                hopLe = false;
            }

            // Kiểm tra tuổi
            DateTime ngaySinh = dtpBirthDate.Value;
            int tuoi = DateTime.Now.Year - ngaySinh.Year;

            if (ngaySinh.Date > DateTime.Now.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                epCheck.SetError(
                    dtpBirthDate,
                    "Người đăng ký phải đủ 18 tuổi"
                );

                hopLe = false;
            }

            // Kiểm tra điều khoản
            if (!chkTerms.Checked)
            {
                epCheck.SetError(
                    chkTerms,
                    "Bạn phải đồng ý với điều khoản dịch vụ"
                );

                hopLe = false;
            }

            // Nếu tất cả hợp lệ
            if (hopLe)
            {
                MessageBox.Show(
                    "Đăng ký tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            dtpBirthDate.Value = DateTime.Now.AddYears(-18);

            rdoMale.Checked = true;
            rdoFemale.Checked = false;

            chkTerms.Checked = false;

            epCheck.Clear();

            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpMore_Enter(object sender, EventArgs e)
        {

        }
    }
}