using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp4
{
    partial class Form1
    {
        private GroupBox grpPersonal;
        private GroupBox grpMore;

        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblBirthDate;
        private Label lblGender;

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private DateTimePicker dtpBirthDate;

        private RadioButton rdoMale;
        private RadioButton rdoFemale;

        private CheckBox chkTerms;

        private Button btnRegister;
        private Button btnReset;

        private ErrorProvider epCheck;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpPersonal = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            grpMore = new GroupBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpPersonal.SuspendLayout();
            grpMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // grpPersonal
            // 
            grpPersonal.Controls.Add(lblUsername);
            grpPersonal.Controls.Add(txtUsername);
            grpPersonal.Controls.Add(lblPassword);
            grpPersonal.Controls.Add(txtPassword);
            grpPersonal.Controls.Add(lblConfirmPassword);
            grpPersonal.Controls.Add(txtConfirmPassword);
            grpPersonal.Location = new Point(23, 27);
            grpPersonal.Margin = new Padding(3, 4, 3, 4);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Padding = new Padding(3, 4, 3, 4);
            grpPersonal.Size = new Size(571, 233);
            grpPersonal.TabIndex = 0;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Thông tin tài khoản";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(23, 47);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(137, 33);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 43);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(23, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(137, 33);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 96);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Location = new Point(23, 153);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(143, 33);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(177, 149);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(319, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // grpMore
            // 
            grpMore.Controls.Add(lblBirthDate);
            grpMore.Controls.Add(dtpBirthDate);
            grpMore.Controls.Add(lblGender);
            grpMore.Controls.Add(rdoMale);
            grpMore.Controls.Add(rdoFemale);
            grpMore.Controls.Add(chkTerms);
            grpMore.Location = new Point(23, 280);
            grpMore.Margin = new Padding(3, 4, 3, 4);
            grpMore.Name = "grpMore";
            grpMore.Padding = new Padding(3, 4, 3, 4);
            grpMore.Size = new Size(571, 193);
            grpMore.TabIndex = 1;
            grpMore.TabStop = false;
            grpMore.Text = "Thông tin bổ sung";
            grpMore.Enter += grpMore_Enter;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Location = new Point(23, 40);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(137, 33);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(177, 36);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(228, 27);
            dtpBirthDate.TabIndex = 1;
            dtpBirthDate.Value = new DateTime(2008, 10, 6, 14, 50, 7, 804);
            // 
            // lblGender
            // 
            lblGender.Location = new Point(23, 87);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(137, 33);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // rdoMale
            // 
            rdoMale.Checked = true;
            rdoMale.Location = new Point(177, 84);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(69, 33);
            rdoMale.TabIndex = 3;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            // 
            // rdoFemale
            // 
            rdoFemale.Location = new Point(257, 84);
            rdoFemale.Margin = new Padding(3, 4, 3, 4);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(69, 33);
            rdoFemale.TabIndex = 4;
            rdoFemale.Text = "Nữ";
            // 
            // chkTerms
            // 
            chkTerms.Location = new Point(177, 131);
            chkTerms.Margin = new Padding(3, 4, 3, 4);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(320, 33);
            chkTerms.TabIndex = 5;
            chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
            chkTerms.CheckedChanged += chkTerms_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(177, 500);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(126, 47);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Đăng Ký";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(326, 500);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(126, 47);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm Mới";
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 573);
            Controls.Add(grpPersonal);
            Controls.Add(grpMore);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng ký tài khoản";
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpMore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        private System.ComponentModel.IContainer components;
    }
}