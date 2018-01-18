using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class CongnhanBUS
    {
        public List<CongNhan> ViewCongNhan(string sql)
        {
            try
            {
                return (new Congnhan().ViewCongNhan(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddGioLamViec(GioLamViec glv)
        {
            try
            {
                return (new Congnhan().AddGioLamViec(glv));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddCongNhan(CongNhan cn)
        {
            switch(cn.MaCV)
            {
                case "Giám đốc":
                    cn.MaCV = "CV01";
                    break;
                case "Phó Giám Đốc":
                    cn.MaCV = "CV02";
                    break;
                case "Tổ Trưởng":
                    cn.MaCV = "CV03";
                    break;
                case "Tổ Phó":
                    cn.MaCV = "CV04";
                    break;
                case "Công Nhân":
                    cn.MaCV = "CV05";
                    break;
                case "Công Nhân Thời Vụ":
                    cn.MaCV = "CV06";
                    break;
            }
            try
            {
                return (new Congnhan().AddCongNhan(cn));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateCongNhan(CongNhan cn)
        {
            try
            {
                return (new Congnhan().UpdateCongNhan(cn));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteCongNhan(string macn)
        {
            try
            {
                return (new Congnhan().DeleteCongNhan(macn));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateGioLamViec(string maglv,TimeSpan giove,string maclv,DateTime dt)
        {
            try
            {
                return (new Congnhan().UpdateGioLamViec(maglv, giove, maclv, dt));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateGioLamViec1(GioLamViec glv)
        {
            try
            {
                return (new Congnhan().UpdateGioLamViec1(glv));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteGioLamViec(string maglv, DateTime ngay)
        {
            try
            {
                return (new Congnhan().DeleteGioLamViec(maglv, ngay));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<Lich> ViewLich(string sql)
        {
            try
            {
                return (new Congnhan().ViewLich(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<GioLamViec> ViewGioLamViec(string sql)
        {
            try
            {
                return (new Congnhan().ViewGioLamViec(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<ViewKyHopDong> ViewKyHopDong(string sql)
        {
            try
            {
                return (new Congnhan().ViewKyHopDong(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddKyHopDong(KyHopDong khd)
        {
            try
            {
                return (new Congnhan().AddKyHopDong(khd));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateKyHopDong(KyHopDong khd)
        {
            try
            {
                return (new Congnhan().UpdateKyHopDong(khd));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteKyHopDong(string makhd,string macn)
        {
            try
            {
                return (new Congnhan().DeleteKyHopDong(makhd, macn));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<TaiKhoan> ViewTaiKhoan(string sql)
        {
            try
            {
                return (new Congnhan().ViewTaiKhoan(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddTaiKhoan(TaiKhoan tk)
        {
            try
            {
                return (new Congnhan().AddTaiKhoan(tk));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdataTaiKhoan(TaiKhoan tk)
        {
            try
            {
                return (new Congnhan().UpdateTaiKhoan(tk));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteTaiKhoan(string matk)
        {
            try
            {
                return (new Congnhan().DeleteTaiKhoan(matk));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<PhuCap> ViewPhuCap(string sql)
        {
            try
            {
                return (new Congnhan().ViewPhuCap(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddPhuCap(PhuCap pc)
        {
            try
            {
                return (new Congnhan().AddPhuCap(pc));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdatePhuCap(PhuCap pc)
        {
            try
            {
                return (new Congnhan().UpdatePhuCap(pc));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeletePhuCap(string mapc)
        {
            try
            {
                return (new Congnhan().DeletePhuCap(mapc));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddHopDong(HopDong hd)
        {
            try
            {
                return (new Congnhan().AddHopDong(hd));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateHopDong(HopDong hd)
        {
            try
            {
                return (new Congnhan().UpdateHopDong(hd));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteHopDong(string mahd)
        {
            try
            {
                return (new Congnhan().DeleteHopDong(mahd));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<ChucVu> ViewChucVu(string sql)
        {
            try
            {
                return (new Congnhan().ViewChucVu(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddChucVu(ChucVu cv)
        {
            try
            {
                return (new Congnhan().AddChucVu(cv));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateChucVu(ChucVu cv)
        {
            try
            {
                return (new Congnhan().UpdateChucVu(cv));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteChucVu(string macv)
        {
            try
            {
                return (new Congnhan().DeleteChucVu(macv));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<HeSoLuong> ViewHeSoLuong(string sql)
        {
            try
            {
                return (new Congnhan().ViewHeSoLuong(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddHeSoLuong(HeSoLuong hsl)
        {
            try
            {
                return (new Congnhan().AddHeSoLuong(hsl));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int UpdateHeSoLuong(HeSoLuong hsl)
        {
            try
            {
                return (new Congnhan().UpdateHeSoLuong(hsl));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int DeleteHeSoLuong(string mahsl)
        {
            try
            {
                return (new Congnhan().DeleteHeSoLuong(mahsl));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddLuong(string macn, DateTime dt)
        {
            try
            {
                return (new Congnhan().AddLuong(macn, dt));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public List<Luong> ViewLuong(string sql)
        {
            try
            {
                return (new Congnhan().ViewLuong(sql));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddHinh(string hinh)
        {
            try
            {
                return (new Congnhan().AddHinh(hinh));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
        public int AddLich(string macn,DateTime dt)
        {
            try
            {
                return (new Congnhan().AddLich(macn, dt));
            }
            catch (Exception p)
            {

                throw p;
            }
        }
    }
}
