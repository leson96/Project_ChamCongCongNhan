using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BUS;
using DTO;
namespace ChamCong
{
    public partial class DangNhap : Form
    {

        Form1 QLCN;
        CongnhanBUS cnb;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cnb = new CongnhanBUS();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = cnb.ViewTaiKhoan("SELECT *FROM TaiKhoan WHERE TenTaiKhoan='" + txtTK.Text + "'")[0];
                if (txtMK.Text.Equals(tk.MatKhau))
                {
                    QLCN = new Form1();
                    QLCN.Show();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Username hoặc password lỗi");
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPass.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else txtMK.UseSystemPasswordChar = true;
        }
    }
}
