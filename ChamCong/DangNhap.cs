using System;
using System.Windows.Forms;
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
            //cnb;
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
                            label4.Text = "Đăng nhập thành công";
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
        public bool ktdangnhap(string user, string pass)
        {
            if (user == "admin" && pass == "admin")
            {
                return true;
            }
            else
                return false;
        }
        #region TESTCASE
        public int _KiemTraDangNhapTEST(string TK, string MK)
        {
            if (string.IsNullOrEmpty(TK) && string.IsNullOrEmpty(MK))
            {
                //chua nhap tai khoan va mat khau
                return 0;
            }
            else if (!string.IsNullOrEmpty(TK))
            {
                if (!string.IsNullOrEmpty(MK))
                {

                    if (MK.Equals("admin") && TK.Equals("admin"))
                    {
                        //Đăng nhập thành công";
                        return 1;
                    }
                    else if (TK.Equals("admin") && MK != "admin") 
                        //Sai Mật Khẩu
                        return 2;
                    else
                        // Nhap sai ca 2;
                        return 3;
                }
                //Lỗi!! Vui lòng nhập mật khẩu
                else
                    return 4;
            }
            // Lỗi!! Vui lòng nhập tài khoản";
            else
                return 5;
        }
        
    }
   
        #endregion
}

