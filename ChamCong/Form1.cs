using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace ChamCong
{
    public partial class Form1 : Form
    {
        CongnhanBUS cnb;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView datagridView = new DataGridView();
            datagridView.Dock = DockStyle.Fill;
            panelDataGridView.Controls.Add(datagridView);
        }

        private void btLoadCongnhan_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLoadcn.DataSource = cnb.ViewCongNhan("SELECT *FROM CongNhan,ChucVu WHERE CongNhan.MaCV=ChucVu.MaCV").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cnb = new CongnhanBUS();
        }

        private void dgvLoadcn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN_CN.Text = dgvLoadcn.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvLoadcn.CurrentRow.Cells[1].Value.ToString();
            txtHo.Text = dgvLoadcn.CurrentRow.Cells[2].Value.ToString();
            dtTuyendung.Value = (DateTime)dgvLoadcn.CurrentRow.Cells[16].Value;
            cbChucvu.Text= dgvLoadcn.CurrentRow.Cells[20].Value.ToString();
            txtSDT.Text = dgvLoadcn.CurrentRow.Cells[13].Value.ToString();
            cbGioitinh.Text = dgvLoadcn.CurrentRow.Cells[3].Value.ToString();
            txtNoilamviec.Text = dgvLoadcn.CurrentRow.Cells[17].Value.ToString();
            txtEmail.Text = dgvLoadcn.CurrentRow.Cells[14].Value.ToString();
            dtNgaysinh.Value = (DateTime)dgvLoadcn.CurrentRow.Cells[4].Value;
            txtTrinhdoVH.Text = dgvLoadcn.CurrentRow.Cells[18].Value.ToString();
            txtDantoc.Text = dgvLoadcn.CurrentRow.Cells[7].Value.ToString();
            txtNoisinh.Text = dgvLoadcn.CurrentRow.Cells[5].Value.ToString();
            txtQuoctich.Text = dgvLoadcn.CurrentRow.Cells[28].Value.ToString();
            txttongiao.Text = dgvLoadcn.CurrentRow.Cells[8].Value.ToString();
            txtQuequan.Text = dgvLoadcn.CurrentRow.Cells[9].Value.ToString();
            cbhonnhan.Text = dgvLoadcn.CurrentRow.Cells[15].Value.ToString();
            txtCmnd.Text = dgvLoadcn.CurrentRow.Cells[6].Value.ToString();
            dtNgaycap.Value = (DateTime)dgvLoadcn.CurrentRow.Cells[24].Value;
            txtNoicap.Text = dgvLoadcn.CurrentRow.Cells[23].Value.ToString();
            txtSonha.Text = dgvLoadcn.CurrentRow.Cells[10].Value.ToString();
            txtTKnganhang.Text = dgvLoadcn.CurrentRow.Cells[22].Value.ToString();
            textBox58.Text = dgvLoadcn.CurrentRow.Cells[29].Value.ToString();
            textBox1.Text =dgvLoadcn.CurrentRow.Cells[29].Value.ToString();
            if(dgvLoadcn.CurrentRow.Cells[26].Value.ToString()!="1")
                //picCongnhan.Image = Image.FromFile(dgvLoadcn.CurrentRow.Cells[26].Value.ToString());
            picCongnhan.ImageLocation = dgvLoadcn.CurrentRow.Cells[26].Value.ToString();
            txtMahesoluong.Text = dgvLoadcn.CurrentRow.Cells[19].Value.ToString();
            txtNoiOHien.Text = dgvLoadcn.CurrentRow.Cells[11].Value.ToString();
            txtSDTN.Text = dgvLoadcn.CurrentRow.Cells[12].Value.ToString();
            txtPhuCap.Text = dgvLoadcn.CurrentRow.Cells[21].Value.ToString();
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            if(txtMaCN_tkCC.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            string day = DateTime.Now.DayOfWeek.ToString();
            TimeSpan giotoi = DateTime.Now.TimeOfDay;
            if (giotoi.Hours <= 11)
            {
                bool ditre = false;
                if (giotoi.Hours > 7)
                    ditre = true;
                GioLamViec glv = new GioLamViec("CALV1", day, giotoi, new TimeSpan(0, 0, 0),ditre, new TimeSpan(0), DateTime.Now, txtMaCN_tkCC.Text, txtMaCN_tkCC.Text);
                try
                {
                    cnb.AddGioLamViec(glv);
                }
                catch (Exception p)
                {

                    MessageBox.Show(p.ToString());
                }
            }
            if (giotoi.Hours>=11&&giotoi.Hours <= 18)
            {
                bool ditre = false;
                if (giotoi.Hours > 11)
                    ditre = true;
                GioLamViec glv = new GioLamViec("CALV2", day, giotoi, new TimeSpan(0, 0, 0),ditre,new TimeSpan(0), DateTime.Now, txtMaCN_tkCC.Text, txtMaCN_tkCC.Text);
                try
                {
                    cnb.AddGioLamViec(glv);
                }
                catch (Exception p)
                {

                    MessageBox.Show(p.ToString());
                }
            }
            if (giotoi.Hours>18)
            {
                bool ditre = false;
                if (giotoi.Hours>18)
                    ditre = true;
                GioLamViec glv = new GioLamViec("CALV3", day, giotoi, new TimeSpan(0, 0, 0),ditre,new TimeSpan(0), DateTime.Now, txtMaCN_tkCC.Text, txtMaCN_tkCC.Text);
                try
                {
                    cnb.AddGioLamViec(glv);
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
            }
            try
            {
                dgvCheck.DataSource = cnb.ViewGioLamViec("SELECT MaCaLV,Thu,GioToi,GioVe,DiTre,Tong,[Ngay/Thang/Nam],GioLamViec.MaNV,MaGioLamViec,Ho,Ten,Hinh FROM GioLamViec,CongNhan WHERE GioLamViec.MaNV=CongNhan.MaNV AND Thu='" + day + "'").ToList();
                cnb.AddLich(txtMaCN_CC.Text, DateTime.Now);
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btThemCN_newForm_Click(object sender, EventArgs e)
        {
            ThemNhanVien themnhanvien = new ThemNhanVien();
            themnhanvien.Show();
        }

        private void btThem_CN_Click(object sender, EventArgs e)
        {
            if(txtHo.Text==""|| txtTen.Text==""|| cbGioitinh.Text==""|| dtNgaysinh.Value==null|| txtNoisinh.Text==""|| txtCmnd.Text==""|| txtDantoc.Text==""|| txttongiao.Text==""|| txtQuequan.Text==""||txtSonha.Text==""||txtNoiOHien.Text==""|| txtSDTN.Text==""|| txtSDT.Text==""||txtEmail.Text==""|| cbhonnhan.Text==""|| dtNgay.Value==null|| txtNoilamviec.Text==""|| txtTrinhdoVH.Text==""|| txtMaCN_CC.Text==""|| txtMahesoluong.Text==""|| txtPhuCap.Text==""|| txtTKnganhang.Text==""|| txtNoicap.Text==""|| dtNgaycap.Value==null|| picCongnhan.ImageLocation==""||txtQuoctich.Text==""||textBox58.Text==""|| textBox1.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            CongNhan cn = new CongNhan(txtMaCN_CN.Text, txtHo.Text, txtTen.Text, cbGioitinh.Text, dtNgaysinh.Value, txtNoisinh.Text, txtCmnd.Text, txtDantoc.Text, txttongiao.Text, txtQuequan.Text, txtSonha.Text, txtNoiOHien.Text, txtSDTN.Text, txtSDT.Text, txtEmail.Text, cbhonnhan.Text, dtNgay.Value, txtNoilamviec.Text, txtTrinhdoVH.Text, txtMaCN_CC.Text, txtMahesoluong.Text, txtPhuCap.Text, txtTKnganhang.Text, txtNoicap.Text, dtNgaycap.Value, picCongnhan.ImageLocation, "1", txtQuoctich.Text, textBox58.Text, textBox1.Text);
            try
            {
                cnb.AddCongNhan(cn);
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btSua_CN_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || cbGioitinh.Text == "" || dtNgaysinh.Value == null || txtNoisinh.Text == "" || txtCmnd.Text == "" || txtDantoc.Text == "" || txttongiao.Text == "" || txtQuequan.Text == "" || txtSonha.Text == "" || txtNoiOHien.Text == "" || txtSDTN.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || cbhonnhan.Text == "" || dtNgay.Value == null || txtNoilamviec.Text == "" || txtTrinhdoVH.Text == "" || txtMaCN_CC.Text == "" || txtMahesoluong.Text == "" || txtPhuCap.Text == "" || txtTKnganhang.Text == "" || txtNoicap.Text == "" || dtNgaycap.Value == null || picCongnhan.ImageLocation == "" || txtQuoctich.Text == "" || textBox58.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            CongNhan cn = new CongNhan(txtMaCN_CN.Text, txtHo.Text, txtTen.Text, cbGioitinh.Text, dtNgaysinh.Value, txtNoisinh.Text, txtCmnd.Text, txtDantoc.Text, txttongiao.Text, txtQuequan.Text, txtSonha.Text, txtNoiOHien.Text, txtSDTN.Text, txtSDT.Text, txtEmail.Text, cbhonnhan.Text, dtNgay.Value, txtNoilamviec.Text, txtTrinhdoVH.Text, txtMaCN_CC.Text, txtMahesoluong.Text, txtPhuCap.Text, txtTKnganhang.Text, txtNoicap.Text, dtNgaycap.Value, picCongnhan.ImageLocation, "1", txtQuoctich.Text, textBox58.Text, textBox1.Text);
            try
            {
                cnb.UpdateCongNhan(cn);
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btXoa_CN_Click(object sender, EventArgs e)
        {
            if(txtMaCN_CN.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            if (cnb.DeleteCongNhan(txtMaCN_CN.Text) != 0)
                MessageBox.Show("Delete cong nhan");
        }
        private void btCheckout_Click(object sender, EventArgs e)
        {
            if(txtMaCN_tkCC.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.UpdateGioLamViec(txtMaCN_tkCC.Text, DateTime.Now.TimeOfDay, "CALV1", DateTime.Now);
                string day = DateTime.Now.DayOfWeek.ToString();
                dgvCheck.DataSource = cnb.ViewGioLamViec("SELECT MaCaLV,Thu,GioToi,GioVe,DiTre,Tong,[Ngay/Thang/Nam],GioLamViec.MaNV,MaGioLamViec,Ho,Ten,Hinh FROM GioLamViec,CongNhan WHERE GioLamViec.MaNV=CongNhan.MaNV AND Thu = '" + day + "'").ToList();
                cnb.AddLuong(txtMaCN_tkCC.Text, DateTime.Now);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoa_CC_Click(object sender, EventArgs e)
        {
            if(txtMaCN_CC.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteGioLamViec(txtMaCN_CC.Text, dtNgay.Value);
                dgvCheck.DataSource = new CongnhanBUS().ViewGioLamViec("SELECT *FROM GioLamViec").ToList();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btLoadlich_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLich.DataSource = new CongnhanBUS().ViewLich("SELECT * FROM Lich").ToList();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void dgvLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN_QLCC.Text = dgvLich.CurrentRow.Cells[0].Value.ToString();
            dgvGiolam.DataSource = cnb.ViewGioLamViec("SELECT MaCaLV,Thu,GioToi,GioVe,DiTre,Tong,[Ngay/Thang/Nam],GioLamViec.MaNV,MaGioLamViec,Ho,Ten,Hinh FROM GioLamViec,CongNhan WHERE GioLamViec.MaNV=CongNhan.MaNV AND GioLamViec.MaNV='" + dgvLich.CurrentRow.Cells[0].Value.ToString()+ "' AND DATEPART(MONTH,[Ngay/Thang/Nam])=" + dgvLich.CurrentRow.Cells[32].Value.ToString()+" AND YEAR([Ngay/Thang/Nam])="+dgvLich.CurrentRow.Cells[33].Value.ToString()).ToList();
            txtHo_QLCC.Text = dgvGiolam.CurrentRow.Cells[9].Value.ToString();
            txtTen_QLCC.Text = dgvGiolam.CurrentRow.Cells[10].Value.ToString();
            //picCN_QLCC.Image = Image.FromFile(dgvGiolam.CurrentRow.Cells[11].Value.ToString());
            lbThang.Text = dgvLich.CurrentRow.Cells[32].Value.ToString();
            lbNam.Text = dgvLich.CurrentRow.Cells[33].Value.ToString();
            int j = 0;
            for (int i =1; i<=31; i++)
            {
                if ((bool)dgvLich.CurrentRow.Cells[i].Value)
                    j++;
                lbTongngay.Text = j.ToString();
            }
            try
            {
                lbTonggio.Text = cnb.ViewLuong("SELECT *FROM Luong WHERE MaNV='" + txtMaCN_QLCC.Text + "'")[0].GioLamViec.ToString();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btTimlich_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNam_QLCC.Text == "" && txtThang_QLCC.Text != "")
                {
                    dgvLich.DataSource = new CongnhanBUS().ViewLich("SELECT * FROM Lich WHERE Thang=" + txtThang_QLCC.Text).ToList();
                }
                if (txtThang_QLCC.Text == "" && txtNam_QLCC.Text != "")
                {
                    dgvLich.DataSource = new CongnhanBUS().ViewLich("SELECT * FROM Lich WHERE Nam=" + txtNam_QLCC.Text).ToList();
                }
                if (txtThang_QLCC.Text != "" && txtNam_QLCC.Text != "")
                {
                    dgvLich.DataSource = new CongnhanBUS().ViewLich("SELECT * FROM Lich WHERE Thang=" + txtThang_QLCC.Text + "AND Nam" + txtNam_QLCC.Text).ToList();
                }
                if (txtThang_QLCC.Text == "" && txtNam_QLCC.Text == "")
                {
                    dgvLich.DataSource = new CongnhanBUS().ViewLich("SELECT * FROM Lich").ToList();
                }
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btLoadluong_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLuong.DataSource = new CongnhanBUS().ViewLuong("SELECT * FROM Luong").ToList();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN_QLBL.Text = dgvLuong.CurrentRow.Cells[0].Value.ToString();
            txtLuongcoban.Text = dgvLuong.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dgvLuong.CurrentRow.Cells[3].Value.ToString();
            txtThuclanh.Text = dgvLuong.CurrentRow.Cells[4].Value.ToString();
            txtTongh_ngay.Text = dgvLuong.CurrentRow.Cells[2].Value.ToString();
        }

        private void btLoadHD_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHD.DataSource = cnb.ViewKyHopDong("SELECT KyHopDong.MaHD,KyHopDong.TuNgay,KyHopDong.DenNgay,Kyhopdong.NgayKyHD,KyHopDong.DieuKhoan,KyHopDong.MaNV,HopDong.LoaiHopDong,HopDong.KyHan,CongNhan.Ten FROM KyHopDong,HopDong,CongNhan WHERE KyHopDong.MaHD=HopDong.MaHD AND KyHopDong.MaNV=CongNhan.MaNV").ToList();
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD_HD.Text = dgvHD.CurrentRow.Cells[0].Value.ToString();
            txtMaCN_HD.Text = dgvHD.CurrentRow.Cells[5].Value.ToString();
            txtTenHD_HD.Text = dgvHD.CurrentRow.Cells[6].Value.ToString();
            txtTenCN_HD.Text = dgvHD.CurrentRow.Cells[8].Value.ToString();
            txtKyhan_HD.Text = dgvHD.CurrentRow.Cells[7].Value.ToString();
            dtTungay_HD.Value = (DateTime)dgvHD.CurrentRow.Cells[1].Value;
            dtDenngay_HD.Value = (DateTime)dgvHD.CurrentRow.Cells[2].Value;
            dtNgayky_HD.Value = (DateTime)dgvHD.CurrentRow.Cells[3].Value;
            txtDieukhoan_HD.Text = dgvHD.CurrentRow.Cells[4].Value.ToString();
        }

        private void btThem_HD_Click(object sender, EventArgs e)
        {
            if (txtMaHD_HD.Text == "" || dtTungay_HD.Value == null || dtDenngay_HD.Value == null || dtNgayky_HD.Value == null || txtDieukhoan_HD.Text == "" || txtMaCN_HD.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                KyHopDong khd = new KyHopDong(txtMaHD_HD.Text, dtTungay_HD.Value, dtDenngay_HD.Value, dtNgayky_HD.Value, txtDieukhoan_HD.Text, txtMaCN_HD.Text);
                cnb.AddKyHopDong(khd);
            }
            catch (Exception p)
            {

                MessageBox.Show(p.ToString());
            }
        }

        private void btSua_HD_Click(object sender, EventArgs e)
        {
            if (txtMaHD_HD.Text == "" || dtTungay_HD.Value == null || dtDenngay_HD.Value == null || dtNgayky_HD.Value == null || txtDieukhoan_HD.Text == "" || txtMaCN_HD.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                KyHopDong khd = new KyHopDong(txtMaHD_HD.Text, dtTungay_HD.Value, dtDenngay_HD.Value, dtNgayky_HD.Value, txtDieukhoan_HD.Text, txtMaCN_HD.Text);
                cnb.UpdateKyHopDong(khd);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoa_HD_Click(object sender, EventArgs e)
        {
            if(txtMaHD_HD.Text==""&&txtMaCN_HD.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteKyHopDong(txtMaHD_HD.Text, txtMaCN_HD.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btTimHD_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaHD_tk.Text == "" && txtMaCN_tkHD.Text != "")
                {
                    dgvHD.DataSource = cnb.ViewKyHopDong("SELECT KyHopDong.MaHD,KyHopDong.TuNgay,KyHopDong.DenNgay,Kyhopdong.NgayKyHD,KyHopDong.DieuKhoan,KyHopDong.MaNV,HopDong.LoaiHopDong,HopDong.KyHan,CongNhan.Ten FROM KyHopDong,HopDong,CongNhan WHERE KyHopDong.MaHD=HopDong.MaHD AND KyHopDong.MaNV=CongNhan.MaNV AND KyHopDong.MaHD='" + txtMaCN_tkHD.Text + "'").ToList();
                }
                if (txtMaHD_tk.Text != "" && txtMaCN_tkHD.Text == "")
                {
                    dgvHD.DataSource = cnb.ViewKyHopDong("SELECT KyHopDong.MaHD,KyHopDong.TuNgay,KyHopDong.DenNgay,Kyhopdong.NgayKyHD,KyHopDong.DieuKhoan,KyHopDong.MaNV,HopDong.LoaiHopDong,HopDong.KyHan,CongNhan.Ten FROM KyHopDong,HopDong,CongNhan WHERE KyHopDong.MaHD=HopDong.MaHD AND KyHopDong.MaNV=CongNhan.MaNV AND CongNhan.MaNV='" + txtMaCN_tkHD.Text + "'").ToList();
                }
                if (txtMaHD_tk.Text == "" && txtMaCN_tkHD.Text == "")
                {
                    MessageBox.Show("Khong co du lieu");
                    return;
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btLoadTK_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_TaiKhoan.DataSource = cnb.ViewTaiKhoan("SELECT *FROM TaiKhoan").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTK.Text = dgv_TaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMaukhau.Text = dgv_TaiKhoan.CurrentRow.Cells[1].Value.ToString();
            cbNhomquyen.Text = dgv_TaiKhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text==""||txtMaukhau.Text==""&&cbNhomquyen.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            TaiKhoan tk = new TaiKhoan(txtTenTK.Text, txtMaukhau.Text, cbNhomquyen.Text);
            try
            {
                cnb.AddTaiKhoan(tk);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "" || txtMaukhau.Text == "" && cbNhomquyen.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            TaiKhoan tk = new TaiKhoan(txtTenTK.Text, txtMaukhau.Text, cbNhomquyen.Text);
            try
            {
                cnb.UpdataTaiKhoan(tk);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteTaiKhoan(txtTenTK.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btLoadPC_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPhucap.DataSource = cnb.ViewPhuCap("SELECT *FROM PhuCap").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgvPhucap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPC.Text = dgvPhucap.CurrentRow.Cells[0].Value.ToString();
            txtTenPC.Text = dgvPhucap.CurrentRow.Cells[1].Value.ToString();
            txtTienPC.Text = dgvPhucap.CurrentRow.Cells[2].Value.ToString();
        }

        private void btThemPC_Click(object sender, EventArgs e)
        {
            if(txtMaPC.Text==""||txtTenPC.Text==""||txtTienPC.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            PhuCap pc = new PhuCap(txtMaPC.Text, txtTenPC.Text, int.Parse(txtTienPC.Text));
            try
            {
                cnb.AddPhuCap(pc);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btSuaPC_Click(object sender, EventArgs e)
        {
            if (txtMaPC.Text == "" || txtTenPC.Text == "" || txtTienPC.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            PhuCap pc = new PhuCap(txtMaPC.Text, txtTenPC.Text, int.Parse(txtTienPC.Text));
            try
            {
                cnb.UpdatePhuCap(pc);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoaPC_Click(object sender, EventArgs e)
        {
            if (txtTenPC.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeletePhuCap(txtTenPC.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btLoadHD_CD_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHD_CD.DataSource = cnb.ViewPhuCap("SELECT *FROM HopDong").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btThemHD_CD_Click(object sender, EventArgs e)
        {
            if(txtMaHD_CD.Text==""||txtLoaiHD_CD.Text==""||txtKyHanHD_CD.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            HopDong hd= new HopDong(txtMaHD_CD.Text, txtLoaiHD_CD.Text, txtKyHanHD_CD.Text);
            try
            {
                cnb.AddHopDong(hd);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btSuaHD_CD_Click(object sender, EventArgs e)
        {
            if (txtMaHD_CD.Text == "" || txtLoaiHD_CD.Text == "" || txtKyHanHD_CD.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            HopDong hd = new HopDong(txtMaHD_CD.Text, txtLoaiHD_CD.Text, txtKyHanHD_CD.Text);
            try
            {
                cnb.UpdateHopDong(hd);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoaHD_CD_Click(object sender, EventArgs e)
        {
            if(txtMaHD_CD.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteHopDong(txtMaHD_CD.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgvHD_CD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD_CD.Text = dgvHD_CD.CurrentRow.Cells[0].Value.ToString();
            txtLoaiHD_CD.Text = dgvHD_CD.CurrentRow.Cells[1].Value.ToString();
            txtKyHanHD_CD.Text = dgvHD_CD.CurrentRow.Cells[2].Value.ToString();
        }

        private void btLoadCV_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLoaiCV_CD.DataSource = cnb.ViewChucVu("SELECT *FROM ChucVu").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgvLoaiCV_CD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV_CD.Text = dgvLoaiCV_CD.CurrentRow.Cells[0].Value.ToString();
            txtTenCV_CD.Text = dgvLoaiCV_CD.CurrentRow.Cells[1].Value.ToString();
        }

        private void btThemCV_CD_Click(object sender, EventArgs e)
        {
            if(txtMaCV_CD.Text==""&&txtTenCV_CD.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            ChucVu cv = new ChucVu(txtMaCV_CD.Text, txtTenCV_CD.Text);
            try
            {
                cnb.AddChucVu(cv);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btSuaCV_CD_Click(object sender, EventArgs e)
        {
            if (txtMaCV_CD.Text == "" && txtTenCV_CD.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            ChucVu cv = new ChucVu(txtMaCV_CD.Text, txtTenCV_CD.Text);
            try
            {
                cnb.UpdateChucVu(cv);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoaCV_CD_Click(object sender, EventArgs e)
        {
            if (txtMaCV_CD.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteChucVu(txtMaCV_CD.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btHSL_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHSL.DataSource = cnb.ViewHeSoLuong("SELECT *FROM HeSoLuong").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgvHSL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHSL.Text = dgvHSL.CurrentRow.Cells[0].Value.ToString();
            txtTenHSL.Text = dgvHSL.CurrentRow.Cells[1].Value.ToString();
            txtHSL.Text = dgvHSL.CurrentRow.Cells[2].Value.ToString();
        }

        private void btThemHSL_Click(object sender, EventArgs e)
        {
            if (MaHSL.Text == "" || txtTenHSL.Text == "" || txtHSL.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            HeSoLuong hsl = new HeSoLuong(MaHSL.Text, txtTenHSL.Text, txtHSL.Text);
            try
            {
                cnb.AddHeSoLuong(hsl);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btSuaHSL_Click(object sender, EventArgs e)
        {
            if (MaHSL.Text == "" || txtTenHSL.Text == "" || txtHSL.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            HeSoLuong hsl = new HeSoLuong(MaHSL.Text, txtTenHSL.Text, txtHSL.Text);
            try
            {
                cnb.UpdateHeSoLuong(hsl);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void btXoaHSL_Click(object sender, EventArgs e)
        {
            if(MaHSL.Text=="")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                cnb.DeleteHeSoLuong(MaHSL.Text);
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }    
        }

        private void btTimLuong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCN_tkQLBL.Text != "" && txtThang_QLBL.Text == "" && txtNam_QLBL.Text == "")
                {
                    dgvLuong.DataSource = new CongnhanBUS().ViewLuong("SELECT * FROM Luong WHERE MaVN='" + txtMaCN_tkQLBL.Text + "'").ToList();
                }
                if (txtMaCN_tkQLBL.Text != "" && txtThang_QLBL.Text != "" && txtNam_QLBL.Text == "")
                {
                    dgvLuong.DataSource = new CongnhanBUS().ViewLuong("SELECT * FROM Luong WHERE MaVN='" + txtMaCN_tkQLBL.Text + "' AND Thang=" + txtThang_QLBL.Text).ToList();
                }
                if (txtMaCN_tkQLBL.Text != "" && txtThang_QLBL.Text != "" && txtNam_QLBL.Text != "")
                {
                    dgvLuong.DataSource = new CongnhanBUS().ViewLuong("SELECT * FROM Luong WHERE MaVN='" + txtMaCN_tkQLBL.Text + "' AND Thang=" + txtThang_QLBL.Text + "AND Nam=" + txtNam_QLBL.Text).ToList();
                }
                if (txtMaCN_tkQLBL.Text == "" && txtThang_QLBL.Text != "" && txtNam_QLBL.Text != "")
                {
                    dgvLuong.DataSource = new CongnhanBUS().ViewLuong("SELECT * FROM Luong WHERE Thang=" + txtThang_QLBL.Text + "AND Nam=" + txtNam_QLBL.Text).ToList();
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }

        }

        private void btBCNhansu_Click(object sender, EventArgs e)
        {
            ReportDataSource rpdt = new ReportDataSource("DataSet1",cnb.ViewCongNhan("SELECT * FROM CongNhan, ChucVu WHERE CongNhan.MaCV = ChucVu.MaCV"));
            reportViewer1.LocalReport.ReportPath = @"..\..\ChamCongReport1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpdt);
            reportViewer1.RefreshReport();
        }

        public void btTimtenCN_Click(object sender, EventArgs e)
        {
            if (txtTenCN.Text == "")
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            try
            {
                dgvLoadcn.DataSource = cnb.ViewCongNhan("SELECT *FROM CongNhan,ChucVu WHERE CongNhan.MaCV=ChucVu.MaCV AND (Ten='" + txtTenCN.Text + "' OR MaNV='" + txtTenCN.Text + "')").ToList();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
        }

        private void dgvCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN_CC.Text = dgvCheck.CurrentRow.Cells[7].Value.ToString();
            txtHo_CC.Text = dgvCheck.CurrentRow.Cells[9].Value.ToString();
            txtTen_CC.Text = dgvCheck.CurrentRow.Cells[10].Value.ToString();
            dtGiotoi.Text = dgvCheck.CurrentRow.Cells[2].Value.ToString();
            dtGiove.Text = dgvCheck.CurrentRow.Cells[3].Value.ToString();
            txtCalv.Text = dgvCheck.CurrentRow.Cells[0].Value.ToString();
            dtNgay.Value =(DateTime)dgvCheck.CurrentRow.Cells[6].Value;
            checkDitre.Checked =(bool)dgvCheck.CurrentRow.Cells[4].Value;
            //picCN_CC.Image = Image.FromFile(dgvCheck.CurrentRow.Cells[11].Value.ToString());
        }

        private void btBCLuong_Click(object sender, EventArgs e)
        {
            ReportDataSource rpdt = new ReportDataSource("DataSet1",cnb.ViewLuong("SELECT * FROM Luong"));
            ReportDataSource rpdt1 = new ReportDataSource("DataSet2",cnb.ViewCongNhan("SELECT * FROM CongNhan,ChucVu WHERE CongNhan.MaCV=ChucVu.MaCV"));
            reportViewer1.LocalReport.ReportPath = @"..\..\Luongreport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpdt);
            reportViewer1.LocalReport.DataSources.Add(rpdt1);
            reportViewer1.RefreshReport();
        }

        private void btBCHD_Click(object sender, EventArgs e)
        {
            ReportDataSource rpdt = new ReportDataSource("DataSet1", cnb.ViewKyHopDong("SELECT KyHopDong.MaHD,KyHopDong.TuNgay,KyHopDong.DenNgay,Kyhopdong.NgayKyHD,KyHopDong.DieuKhoan,KyHopDong.MaNV,HopDong.LoaiHopDong,HopDong.KyHan,CongNhan.Ten FROM KyHopDong,HopDong,CongNhan WHERE KyHopDong.MaHD=HopDong.MaHD AND KyHopDong.MaNV=CongNhan.MaNV"));
            reportViewer1.LocalReport.ReportPath = @"..\..\Hopdongreport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpdt);
            reportViewer1.RefreshReport();
        }
        public void timnhanvien()
        {

                if (txtTenCN.Text == "")
                {
                    MessageBox.Show("Khong co du lieu");
                    return;
                }
                try
                {
                    dgvLoadcn.DataSource = cnb.ViewCongNhan("SELECT *FROM CongNhan,ChucVu WHERE CongNhan.MaCV=ChucVu.MaCV AND (Ten='" + txtTenCN.Text + "' OR MaNV='" + txtTenCN.Text + "'  )").ToList();
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
        }
        private void txtTenCN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                timnhanvien();
            }
        }
    }
}