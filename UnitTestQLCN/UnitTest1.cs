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
        private ChamCong.Form1 df;
   
        [TestInitialize]
        public void setup()
        {
            dn = new DangNhap();
            df = new Form1();

        }
        [TestMethod]
        public void DangNhapThanhCong()
        {
            Assert.AreEqual(dn.ktdangnhap("admin", "admin"), true);
        }

        [TestMethod]
        public void DangNhapThatBai()
        {
            Assert.AreEqual(dn.ktdangnhap("datdaigia", "sonmatcho"), false);
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
      
        [TestMethod]

    }
}
