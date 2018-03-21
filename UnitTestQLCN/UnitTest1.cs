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
        public void KiemTraTimKiemCNTC()
        {
            Assert.AreEqual(frm1.KiemTraTimKiemCN("CN002"), 1);
        }
        [TestMethod]
        public void KiemTraTimKiemCNThatBai()
        {
            Assert.AreEqual(frm1.KiemTraTimKiemCN("12345"), 0);
        }
        [TestMethod]
        public void KiemTraTimKiemCNRong()
        {
            Assert.AreEqual(frm1.KiemTraTimKiemCN(""), 2);
        }
        [TestMethod]
        public void TimKiemHopDongHopLe()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("HD01", "CN001"), 1);
        }
        [TestMethod]
        public void TimKiemHopDongMaCNSai()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("HD01", "CN120"), 0);
        }
        [TestMethod]
        public void TimKiemHopDongMaHDSai()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("HD120", "CN001"), 0);
        }
        [TestMethod]
        public void TimKiemHopDongMaHDMaCNSai()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("HD120", "CN120"), 0);
        }

        [TestMethod]
        public void TimKiemHopDongMaHDMaCNRong()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("", ""), 2);
        }
        [TestMethod]
        public void TimKiemHopDongMaHDRong()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("", "CN001"), 3);
        }
        public void TimKiemHopDongMaCNRong()
        {
            Assert.AreEqual(frm1.TimKiemHopDong("HD01", ""), 3);
        }
    }
}
