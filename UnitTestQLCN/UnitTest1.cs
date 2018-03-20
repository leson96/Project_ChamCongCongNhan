using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChamCong;
using BUS;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace UnitTestQLCN
{
    [TestClass]
    public class UnitTest1
    {
        private ChamCong.DangNhap dn;
        private ChamCong.Form1 df, frm1;

        [TestInitialize]
        public void setup()
        {

            dn = new DangNhap();
            frm1 = new Form1();
            df = new Form1();

        }

        [TestMethod]
        public void LoginPassed_()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("admin", "admin"), 1);
        }

        [TestMethod]
        public void LoginFail_()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("leson", "leson"), 3);
        }
        [TestMethod]
        public void LoginWithoutUsername_()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("", "admin"), 5);
        }
        [TestMethod]
        public void LoginWithoutPassword()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("admin", ""), 4);
        }
        [TestMethod]
        public void LoginWithoutUsernamePassword_()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("", ""), 0);
        }
        [TestMethod]
        public void LoginUsernameCorrect_PassIncorrect_()
        {
            Assert.AreEqual(dn._KiemTraDangNhapTEST("admin", "1111"), 2);
        }

        [TestMethod]
        public void KiemTra_NhapKHRong()
        {
            Assert.AreEqual(frm1.KiemTraCN("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""), false);
        }
        [TestMethod]
        public void KiemTra_NhapDayDu()
        {
            Assert.AreEqual(frm1.KiemTraCN("CN01", "Le", "Son", "Nam", "30/10/1996", "TPHCM", "012345", "Kinh", "Khong", "Long An", "Long An", "BenLuc", "122455", "1222", "1@gmail.com", "Khong", "12/2017", "Quan12", "DaiHoc", "HSL1", "CV01", "MPC1", "TKNG", "2017", "BenLuc", "PIC", "DangLam", "VN", "BHYT1", "BHXH"), true);
        }
        [TestMethod]
        public void KiemTra_NhapThieu()
        {
            Assert.AreEqual(frm1.KiemTraCN("CN01", "", null, "Nam", "30/10/1996", "TPHCM", "012345", "Kinh", "Khong", "Long An", "Long An", "BenLuc", "122455", "1222", "1@gmail.com", "Khong", "12/2017", "Quan12", "DaiHoc", "HSL1", "CV01", "MPC1", "TKNG", "2017", "BenLuc", "PIC", "DangLam", "VN", "BHYT1", "BHXH"), false);

        }
        [TestMethod]
        public void KiemTraTimKiemTC()
        {
            Assert.AreEqual(df.kttimkiem("CN002"), true);
        }
        [TestMethod]
        public void KiemTraTKThatBai()
        {
            Assert.AreEqual(df.kttimkiem("12345"), false);
        }
        [TestMethod]
        public void KiemTraRong()
        {
            Assert.AreEqual(df.kttimkiem(""), true);
        }
        [TestMethod]
        public void TimHDThanhcong()
        {
            Assert.AreEqual(df.kthopdong("HD01", "CN002"), true);
        }
        public void TimHDthatbai()
        {
            Assert.AreEqual(df.kthopdong("", ""), false);
        }
        [TestMethod]
        public void BoTrongMaHD()
        {
            Assert.AreEqual(df.kthopdong("", "CN002"), false);
        }
    }
}
