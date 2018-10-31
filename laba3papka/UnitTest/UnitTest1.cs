using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba3papka;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
          
            int a = 5;
            int b = 10;
            int r = 5;

            NOD delit= new NOD();
            int res = delit.ras_NOD(a, b);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod2()
        {

            int a = 5;
            int b = 10;
            int c = 15;
            int r = 5;

            NOD delit = new NOD();
            int res = delit.ras_NOD(a, b,c);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod3()
        {

            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;
            int r = 5;

            NOD delit = new NOD();
            int res = delit.ras_NOD(a, b, c,d);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod4()
        {

            int a = 5;
            int b = 10;
            int c = 15;
            int d = 20;
            int e = 25;
            int r = 5;

            NOD delit = new NOD();
            int res = delit.ras_NOD(a, b, c,d,e);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod1_S()
        {

            int a = 5;
            int b = 10;
            int r = 5;

            NOD delit = new NOD();
            int res = delit.ras_NOD_Stan(a, b);

            Assert.AreEqual(r, res);
        }
    
  
    }
}
