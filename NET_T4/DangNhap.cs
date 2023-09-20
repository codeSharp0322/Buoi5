using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_T4
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtTEN.Text == "") || (txtMATKHAU.Text == ""))
            {
                MessageBox.Show("Nhap lai");
            }
            else if ((txtTEN.Text == "Tan") || (txtMATKHAU.Text == "10"))
            {
                MessageBox.Show("Đang Nhap thanh cong");
            }else
            {
                MessageBox.Show("Đang nhap khong thanh cong");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
