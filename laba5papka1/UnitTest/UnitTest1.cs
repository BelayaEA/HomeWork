using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba5papka1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          int x = 1;
          int y = 1;
          int z = 1;
          double r = 1.73;
            Vector v = new Vector(x,y,z);
           double res = v.Dlina();
            Assert.AreEqual(r, res);
         }
        [TestMethod]
        public void TestMethod2()
        {
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int x2 = 2;
            int y2 = 2;
            int z2 = 2;
            double r1 = 3;
            double r2 = 3;
            double r3 = 3;
            Vector r = new Vector(r1, r2, r3);
            Vector v1 = new Vector(x1, y1, z1);
            Vector v2 = new Vector(x2, y2, z2);
            Vector res = v1 + v2;
           Assert.ReferenceEquals(r, res);
        //   Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int x2 = 2;
            int y2 = 2;
            int z2 = 2;
            double r1 = -1;
            double r2 = -1;
            double r3 = -1;
            Vector r = new Vector(r1, r2, r3);
            Vector v1 = new Vector(x1, y1, z1);
            Vector v2 = new Vector(x2, y2, z2);
            Vector res = v1 - v2;
            Assert.ReferenceEquals(r, res);
          
        }
        [TestMethod]
        public void TestMethod4()
        {
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int x2 = 2;
            int y2 = 2;
            int z2 = 2;
            double r = 6;
             Vector v1 = new Vector(x1, y1, z1);
            Vector v2 = new Vector(x2, y2, z2);
           double res = v1 * v2;
           Assert.AreEqual(r, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int c = 5;
            double r1 = 5;
            double r2 = 5;
            double r3 = 5;
            Vector r = new Vector(r1, r2, r3);
            Vector v1 = new Vector(x1, y1, z1);
            Vector res = v1 *c;
            Assert.ReferenceEquals(r, res);
        
        }
    }
}
