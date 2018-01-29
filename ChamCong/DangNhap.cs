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
        public void KiemTraDangNhap()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTK.Text))
                {
                    if (!string.IsNullOrEmpty(txtMK.Text))
                    {
                        TaiKhoan tk = cnb.ViewTaiKhoan("SELECT *FROM TaiKhoan WHERE TenTaiKhoan='" + txtTK.Text + "'")[0];
                        if (txtMK.Text.Equals(tk.MatKhau))
                        {
                            QLCN = new Form1();
                            QLCN.Show();
                            this.Hide();
                        }
                        else
                        {
                            label4.Text = "Sai Mật Khẩu";
                            txtMK.Clear();
                            txtMK.Focus();
                        }
                    }
                    else
                    {
                        label4.Text = "Lỗi!! Vui lòng nhập mật khẩu";
                        txtMK.Focus();
                    }
                }
                else
                {
                    label4.Text = " Lỗi!! Vui lòng nhập tài khoản của bạn";
                    txtTK.Focus();
                    txtMK.Clear();
                }


            }
            catch (Exception)
            {
                label4.Text = "Lỗi!! Sai tài khoản hoặc mật khẩu";
                txtTK.Clear();
                txtMK.Clear();
                txtTK.Focus();

            }
        }

        public void btDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 KiemTraDangNhap();
             }
        }

        private void txtTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KiemTraDangNhap();
            }
        }
    }
}
