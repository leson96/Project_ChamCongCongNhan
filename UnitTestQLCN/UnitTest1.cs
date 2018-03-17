using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChamCong;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UnitTestQLCN
{
    [TestClass]
    public class UnitTest1
    {
        private ChamCong.DangNhap dn;
        [TestInitialize]
        public void setup()
        {
            dn = new DangNhap();
        }
        [TestMethod]
        public void DangNhapThanhCong()
        {
            Assert.AreEqual(dn.ktdangnhap("admin", "admin"), true);
        }

        [TestMethod]
        public void DangNhapThatBai()
        {
            Assert.AreEqual(dn.ktdangnhap("leson", "leson"), false);
        }
        [TestMethod]
        public void DangNhapBoTrongTK()
        {
            Assert.AreEqual(dn.ktdangnhap("", "admin"), false);
        }
        [TestMethod]
        public void DangNhapBoTrongMK()
        {
            Assert.AreEqual(dn.ktdangnhap("admin", ""), false);
        }
        [TestMethod]
        public void DangNhapBoTrongTKMK()
        {
            Assert.AreEqual(dn.ktdangnhap("", ""), false);
        }
    }
}
