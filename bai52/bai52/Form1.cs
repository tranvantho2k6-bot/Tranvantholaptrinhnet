using System;
using System.Windows.Forms;

namespace bai52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            if (cboCategory.SelectedItem == null)
                return;

            string category = cboCategory.SelectedItem.ToString();

            if (category == "Khám bệnh")
            {
                lstAvailableServices.Items.Add("Khám tổng quát - 200000");
                lstAvailableServices.Items.Add("Khám chuyên khoa - 300000");
                lstAvailableServices.Items.Add("Khám sức khỏe - 500000");
            }
            else if (category == "Xét nghiệm")
            {
                lstAvailableServices.Items.Add("Xét nghiệm máu - 150000");
                lstAvailableServices.Items.Add("Xét nghiệm nước tiểu - 100000");
                lstAvailableServices.Items.Add("Xét nghiệm ADN - 1000000");
            }
            else if (category == "Chụp X-Quang")
            {
                lstAvailableServices.Items.Add("X-Quang phổi - 250000");
                lstAvailableServices.Items.Add("X-Quang xương - 300000");
                lstAvailableServices.Items.Add("X-Quang răng - 200000");
            }
            else if (category == "Vắc-xin")
            {
                lstAvailableServices.Items.Add("Vắc-xin cúm - 300000");
                lstAvailableServices.Items.Add("Vắc-xin viêm gan B - 400000");
                lstAvailableServices.Items.Add("Vắc-xin Covid-19 - 500000");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(
                    lstAvailableServices.SelectedItem
                );

                lstAvailableServices.Items.Remove(
                    lstAvailableServices.SelectedItem
                );

                TinhTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstAvailableServices.Items.Add(
                    lstSelectedServices.SelectedItem
                );

                lstSelectedServices.Items.Remove(
                    lstSelectedServices.SelectedItem
                );

                TinhTien();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            while (lstSelectedServices.Items.Count > 0)
            {
                lstAvailableServices.Items.Add(
                    lstSelectedServices.Items[0]
                );

                lstSelectedServices.Items.RemoveAt(0);
            }

            TinhTien();
        }

        private void lstAvailableServices_DoubleClick(
            object sender,
            EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void TinhTien()
        {
            decimal tongTien = 0;

            foreach (object item in lstSelectedServices.Items)
            {
                string text = item.ToString();

                int viTri = text.LastIndexOf("-");

                if (viTri >= 0)
                {
                    string giaText = text.Substring(viTri + 1)
                        .Trim();

                    decimal gia;

                    if (decimal.TryParse(giaText, out gia))
                    {
                        tongTien += gia;
                    }
                }
            }

            decimal phanTram = 0;

            if (decimal.TryParse(
                txtDiscount.Text,
                out phanTram))
            {
                if (phanTram < 0)
                    phanTram = 0;

                if (phanTram > 100)
                    phanTram = 100;
            }

            decimal tienGiam = tongTien * phanTram / 100;
            decimal thanhTien = tongTien - tienGiam;

            txtTotal.Text = tongTien.ToString("N0");
            txtPayment.Text = thanhTien.ToString("N0");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}