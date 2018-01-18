using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DTO
{
         public class CaLamViec
        {
            public string MaCaLV { get; set; }
            public string TenCa { get; set; }
            public DateTime GioBatDau { get; set; }
            public DateTime GioKetThuc { get; set; }
            
            public CaLamViec (string MaCaLV, string TenCa, DateTime GioBatDau, DateTime GioKetThuc)
            {
                this.MaCaLV = MaCaLV;
                this.TenCa = TenCa;
                this.GioBatDau = GioBatDau;
                this.GioKetThuc = GioKetThuc;
            }
        }

         public class ChucVu
        {
            public string MaCV { get; set; }
            public string TenChucVu { get; set; }

            public ChucVu (string MaCV, string TenChucVu)
            {
                this.MaCV = MaCV;
                this.TenChucVu = TenChucVu;
            }
        }

         public class CongNhan
    {
        public string MaCN { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string CMND { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QueQuan { get; set; }
        public string DCThuongTru { get; set; }
        public string NoiOHienNay { get; set; }
        public string DienThoaiNha { get; set; }
        public string DienThoaiDD { get; set; }
        public string Email { get; set; }
        public string TTHonNhan { get; set; }
        public DateTime NgayTuyenDung { get; set; }
        public string NoiLamViec { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string MaHeSoLuong { get; set; }
        public string MaCV { get; set; }
        public string MaPhuCap { get; set; }
        public string TaiKhoanNganHang { get; set; }
        public string NoiCapCMND { get; set; }
        public DateTime NgayCapCMND { get; set; }
        public string Hinh { get; set; }
        public string TinhTrang { get; set; }
        public string QuocTich { get; set; }
        public string MaBHYT { get; set; }
        public string MaBHXH { get; set; }

        public CongNhan(string MaCN, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string NoiSinh,
            string CMND, string DanToc, string TonGiao, string QueQuan, string DCThuongTru, string NoiOHienNay,
            string DienThoaiNha, string DienThoaiDD, string Email, string TTHonNhan, DateTime NgayTuyenDung,
            string NoiLamViec, string TrinhDoVanHoa, string MaCV, string MaHeSoLuong,string MaPhuCap, string TaiKhoanNganHang,
            string NoiCapCMND, DateTime NgayCapCMND, string Hinh, string TinhTrang, string QuocTich,
            string MaBHYT, string MaBHXH)
        {
            this.MaCN = MaCN;
            this.Ho = Ho;
            this.Ten = Ten;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.NoiSinh = NoiSinh;
            this.CMND = CMND;
            this.DanToc = DanToc;
            this.TonGiao = TonGiao;
            this.QueQuan = QueQuan;
            this.DCThuongTru = DCThuongTru;
            this.NoiOHienNay = NoiOHienNay;
            this.DienThoaiNha = DienThoaiNha;
            this.DienThoaiDD = DienThoaiDD;
            this.Email = Email;
            this.TTHonNhan = TTHonNhan;
            this.MaCV = MaCV;
            this.NgayTuyenDung = NgayTuyenDung;
            this.NoiLamViec = NoiLamViec;
            this.TrinhDoVanHoa = TrinhDoVanHoa;
            this.MaHeSoLuong = MaHeSoLuong;
            this.MaPhuCap = MaPhuCap;
            this.TaiKhoanNganHang = TaiKhoanNganHang;
            this.NoiCapCMND = NoiCapCMND;
            this.NgayCapCMND = NgayCapCMND;
            this.Hinh = Hinh;
            this.TinhTrang = TinhTrang;
            this.QuocTich = QuocTich;
            this.MaBHYT = MaBHYT;
            this.MaBHXH = MaBHXH;
        }
    }

         public class GioLamViec
            {
                public string MaCaLV { get; set; }
                public string Thu { get; set; }
                public TimeSpan GioToi { get; set; }
                public TimeSpan GioVe { get; set; }
                public bool DiTre { get; set; }
                public TimeSpan Tong { get; set; }
                public DateTime NgayThangNam{ get; set; }
                public string MaCN { get; set; }
                public string MaGioLamViec { get; set; }
                public string Ho { get; set; }
                public string Ten { get; set; }
                public string Hinh { get; set; }

        public GioLamViec (string MaCaLV, string Thu, TimeSpan GioToi, TimeSpan GioVe, bool DiTre,TimeSpan Tong, DateTime NgayThangNam, string MaCN, string MaGioLamViec,string Ho,string Ten,string Hinh)
                {
                    this.MaCaLV = MaCaLV;
                    this.Thu = Thu;
                    this.GioToi = GioToi;
                    this.GioVe = GioVe;
                    this.DiTre = DiTre;
                    this.Tong = Tong;
                    this.NgayThangNam = NgayThangNam;
                    this.MaCN = MaCN;
                    this.MaGioLamViec = MaGioLamViec;
                    this.Ho = Ho;
                    this.Ten = Ten;
                    this.Hinh = Hinh;
                }
               public GioLamViec(string MaCaLV, string Thu, TimeSpan GioToi,TimeSpan GioVe, bool DiTre,TimeSpan Tong, DateTime NgayThangNam, string MaCN, string MaGioLamViec)
                {
                    this.MaCaLV = MaCaLV;
                    this.Thu = Thu;
                    this.GioToi = GioToi;
                    this.DiTre = DiTre;
                    this.NgayThangNam = NgayThangNam;
                    this.MaCN = MaCN;
                    this.MaGioLamViec = MaGioLamViec;
                }
            }

         public class HeSoLuong
            {
                public string MaHSL { get; set; }
                public string TenHeSoLuong { get; set; }
                public string HeSL { get; set; }

                public HeSoLuong (string MaHSL, string TenHeSoLuong, string HeSL)
                {
                    this.MaHSL = MaHSL;
                    this.TenHeSoLuong = TenHeSoLuong;
                    this.HeSL = HeSL;
                }
            }
         public class HopDong
            {
                public string MaHD { get; set; }
                public string LoaiHopDong { get; set; }
                public string KyHan { get; set; }

                public HopDong (string MaHD, string LoaiHopDong, string KyHan)
                {
                    this.MaHD = MaHD;
                    this.LoaiHopDong = LoaiHopDong;
                    this.KyHan = KyHan;
                }
            }

         public class KyHopDong
            {
                public string MaHD { get; set; }
                public DateTime TuNgay { get; set; }
                public DateTime DenNgay { get; set; }
                public DateTime NgayKyHD { get; set; }
                public string DieuKhoan { get; set; }
                public string MaCN { get; set; }

                public KyHopDong (string MaHD, DateTime TuNgay, DateTime DenNgay, DateTime NgayKyHD, string DieuKhoan, string MaCN)
                {
                    this.MaHD = MaHD;
                    this.TuNgay = TuNgay;
                    this.DenNgay = DenNgay;
                    this.NgayKyHD = NgayKyHD;
                    this.DieuKhoan = DieuKhoan;
                    this.MaCN = MaCN;
                }
            }

         public class Lich
            {
                public string MaCN { get; set; }
                public bool n1 { get; set; }
                public bool n2 { get; set; }
                public bool n3 { get; set; }
                public bool n4 { get; set; }
                public bool n5 { get; set; }
                public bool n6 { get; set; }
                public bool n7 { get; set; }
                public bool n8 { get; set; }
                public bool n9 { get; set; }
                public bool n10 { get; set; }
                public bool n11 { get; set; }
                public bool n12 { get; set; }
                public bool n13 { get; set; }
                public bool n14 { get; set; }
                public bool n15 { get; set; }
                public bool n16 { get; set; }
                public bool n17 { get; set; }
                public bool n18 { get; set; }
                public bool n19 { get; set; }
                public bool n20 { get; set; }
                public bool n21 { get; set; }
                public bool n22 { get; set; }
                public bool n23 { get; set; }
                public bool n24 { get; set; }
                public bool n25 { get; set; }
                public bool n26 { get; set; }
                public bool n27 { get; set; }
                public bool n28 { get; set; }
                public bool n29 { get; set; }
                public bool n30 { get; set; }
                public bool n31 { get; set; }
                public int Thang { get; set; }
                public int Nam { get; set; }

                public Lich (string MaCN, bool n1, bool n2, bool n3, bool n4,
                    bool n5, bool n6, bool n7, bool n8, bool n9, bool n10,
                    bool n11, bool n12, bool n13, bool n14, bool n15, bool n16,
                    bool n17, bool n18, bool n19, bool n20, bool n21, bool n22,
                    bool n23, bool n24, bool n25, bool n26, bool n27, bool n28,
                    bool n29, bool n30, bool n31, int Thang, int Nam)
                {
                    this.MaCN = MaCN;
                    this.n1 = n1;
                    this.n2 = n2;
                    this.n3 = n3;
                    this.n4 = n4;
                    this.n5 = n5;
                    this.n6 = n6;
                    this.n7 = n7;
                    this.n8 = n8;
                    this.n9 = n9;
                    this.n10 = n10;
                    this.n11 = n11;
                    this.n12 = n12;
                    this.n13 = n13;
                    this.n14 = n14;
                    this.n15 = n15;
                    this.n16 = n16;
                    this.n17 = n17;
                    this.n18 = n18;
                    this.n19 = n19;
                    this.n20 = n20;
                    this.n21 = n21;
                    this.n22 = n22;
                    this.n23 = n23;
                    this.n24 = n24;
                    this.n25 = n25;
                    this.n26 = n26;
                    this.n27 = n27;
                    this.n28 = n28;
                    this.n29 = n29;
                    this.n30 = n30;
                    this.n31 = n31;
                    this.Thang = Thang;
                    this.Nam = Nam;
               }
            }

         public class LoaiCongViec
            {
                public string MaLoaiCV { get; set; }
                public string TenLCV { get; set; }

                public LoaiCongViec (string MaLoaiCV, string TenLCV)
                {
                    this.MaLoaiCV = MaLoaiCV;
                    this.TenLCV = TenLCV;
                }
            }

         public class Luong
            {
                public string MaCN { get; set; }
                public string MaHSL { get; set; }
                public TimeSpan GioLamViec { get; set; }
                public string MaPhuCap { get; set; }
                public int TienLuong { get; set; }
                public int Thang { get; set; }
                public int Nam { get; set; }

                public Luong (string MaCN, string MaHSL, TimeSpan GioLamViec, string MaPhuCap, int TienLuong, int Thang, int Nam)
                {
                    this.MaCN=MaCN;
                    this.MaHSL = MaHSL;
                    this.GioLamViec = GioLamViec;
                    this.MaPhuCap = MaPhuCap;
                    this.TienLuong = TienLuong;
                    this.Thang = Thang;
                    this.Nam = Nam;
                }
            }

         public class PhuCap
            {
                public string MaPhuCap { get; set; }
                public string TenPhuCap { get; set; }
                public int SoTienPhuCap { get; set; }

                public PhuCap (string MaPhuCap, string TenPhuCap, int SoTienPhuCap)
                {
                    this.MaPhuCap = MaPhuCap;
                    this.TenPhuCap = TenPhuCap;
                    this.SoTienPhuCap = SoTienPhuCap;
                }
            }


         public class TaiKhoan
        {
            public string MaTaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public string PhanQuyen { get; set; }

            public TaiKhoan(string MaTaiKhoan, string MatKhau, string PhanQuyen)
            {
                this.MaTaiKhoan = MaTaiKhoan;
                this.MatKhau = MatKhau;
                this.PhanQuyen = PhanQuyen;
            }
        }
         public class ViewKyHopDong
         {
             public string MaHD { get; set; }
             public string LoaiHopDong { get; set; }
             public String KyHan { get; set; }
             public string MaCN { get; set; }
             public string TenCN { get; set; }
             public DateTime TuNgay { get; set; }
             public DateTime DenNgay { get; set; }
             public DateTime NgayKy { get; set; }
             public string DieuKhoan { get; set; }
             public ViewKyHopDong(string MaHD,string LoaiHopDong,string KyHan,string MaCN,string TenCN,DateTime TuNgay,DateTime DenNgay,DateTime NgayKy,string DieuKhoan)
             {
                    this.MaHD = MaHD;
                    this.LoaiHopDong = LoaiHopDong;
                    this.KyHan = KyHan;
                    this.MaCN = MaCN;
                    this.TenCN = TenCN;
                    this.TuNgay = TuNgay;
                    this.DenNgay = DenNgay;
                    this.NgayKy = NgayKy;
                    this.DieuKhoan = DieuKhoan;
             }
    }
}
