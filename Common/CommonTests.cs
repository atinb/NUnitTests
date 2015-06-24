using System;
using NUnit.Framework;

namespace CommonTests
{
    [TestFixture]
    public class CommonTests
    {
        [Test]

        public void CommonTest1()
        {
            string str = "Firefox BVT";
            Assert.AreEqual("Firefox BVT", str);
        }

        [Test]
        public void CommonTest2()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void CommonTest3()
        {
            Assert.AreEqual(3, 3);
        }

        [Test]
        public void CommonTest4()
        {
            Assert.AreEqual(4, 4);
        }

        [Test]
        public void CommonTest5()
        {
            Assert.Equals(5, 5);
        }
    }
}
