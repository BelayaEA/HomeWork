using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba4papka;
namespace UnitTestTR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             int a = 2;
            int b = 3;
            int c = 4;
            int r = 1;

            
            Treugolnik tr = new Treugolnik();
            int res = tr.Sushchest(a, b, c);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            float r = 9;


            Treugolnik tr = new Treugolnik();
            float res = tr.PP(a, b, c);

            Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            double r = 2.12;
            Treugolnik tr = new Treugolnik();
            double res = tr.Pl(a, b, c);

            Assert.AreEqual(r, res);
        }
        }
    }

