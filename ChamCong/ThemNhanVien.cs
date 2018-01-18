using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ChamCong;
using DTO;
namespace ChamCong
{
    public partial class ThemNhanVien : Form
    {
        CongnhanBUS cnb = new CongnhanBUS();
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                picCN.Image = Image.FromFile(open.FileName);
                picCN.SizeMode = PictureBoxSizeMode.Zoom;
                //cnb.AddHinh(open.FileName);
            }
        }

        private void btThem_CN_Click(object sender, EventArgs e)
        {
            if (txtHoCN.Text == "" || txtTenCN.Text == "" || cbGioitinh.Text == "" || dtNgaysinh.Value == null || txtNoisinh.Text == "" || txtCMND.Text == "" || txtDantoc.Text == "" || txttongiao.Text == "" || txtQuequan.Text == "" || txtSonha.Text == "" || txtNoiOHien.Text == "" || txtSDTN.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || cbTTHonnhan.Text == "" || dtNgaycap.Value == null ||txtNoiLV.Text == "" || txtTrinhdoVH.Text == "" || txtMaCN.Text == "" || txtMahesoluong.Text == "" || txtPhuCap.Text == "" ||txtTKNganhang.Text == "" || txtNoicap.Text == "" || dtNgaycap.Value == null ||picCN.ImageLocation == "" || txtQuoctich.Text == "" ||txtBHXH.Text == "" || txtBHYT.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            CongNhan cn = new CongNhan(txtMaCN.Text, txtHoCN.Text, txtTenCN.Text, cbGioitinh.Text, dtNgaysinh.Value, txtNoisinh.Text,txtCMND.Text, txtDantoc.Text, txttongiao.Text, txtQuequan.Text, txtSonha.Text, txtNoiOHien.Text, txtSDTN.Text, txtSDT.Text, txtEmail.Text, cbTTHonnhan.Text, dtNgaytuyendung.Value, txtNoiLV.Text, txtTrinhdoVH.Text,cbChucvu.Text, txtMahesoluong.Text, txtPhuCap.Text,txtTKNganhang.Text, txtNoicap.Text, dtNgaycap.Value, picCN.ImageLocation, "1", txtQuoctich.Text,txtBHXH.Text, txtBHYT.Text);
            CongnhanBUS cnb = new CongnhanBUS();
            try
            {
                cnb.AddCongNhan(cn);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }
    }
}
