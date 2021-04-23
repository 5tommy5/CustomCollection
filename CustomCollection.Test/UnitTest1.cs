using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomCollection.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(3);
            cc.Add(4);
            cc.Add(5);
            cc.Add(6);
            Assert.AreEqual(3, cc[2]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(3);
            cc.Add(4);
            cc.Add(5);
            cc.Add(6);
            int[] mas = new int[6];
            int counter = 0;
            foreach(var c in cc)
            {
                mas[counter] = Int32.Parse(c.ToString()); // )))
                counter++;
            }
            Assert.AreEqual(3, mas[2]);
        }
        [TestMethod]
        public void TestMethod3()
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(3);
            cc.Add(4);
            cc.Add(5);
            cc.Add(6);
            int[] mas = new int[7];
            int counter = 0;
            cc.Insert(0, 255);
            foreach (var c in cc)
            {
                mas[counter] = Int32.Parse(c.ToString()); // )))
                counter++;
            }
            Assert.AreEqual(255, mas[0]);
        }
        [TestMethod]
        public void TestMethod4()
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(3);
            cc.Add(4);
            cc.Add(5);
            cc.Add(6);
            int[] mas = new int[6];
            int counter = 0;
            cc.Insert(0, 255);
            cc.Remove(255);
            foreach (var c in cc)
            {
                mas[counter] = Int32.Parse(c.ToString()); // )))
                counter++;
            }
            Assert.AreEqual(1, mas[0]);
        }
        [TestMethod]
        public void TestMethod5()
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(3);
            cc.Add(4);
            cc.Add(5);
            cc.Add(6);
            int[] mas = new int[5];
            int counter = 0;
            cc.Insert(0, 255);
            cc.Remove(255);
            cc.RemoveAt(0);
            foreach (var c in cc)
            {
                mas[counter] = Int32.Parse(c.ToString()); // )))
                counter++;
            }
            Assert.AreEqual(2, mas[0]);
        }
    }
}
