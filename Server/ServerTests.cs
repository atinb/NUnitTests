using System;
using NUnit.Framework;

namespace ServerTests
{
    [TestFixture]
    public class ServerTests
    {
        [Test]

        public void ServerTest1()
        {
            string str = "Firefox BVT";
            Assert.AreEqual("Firefox BVT", str);
        }

        [Test]
        public void ServerTest2()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void ServerTest3()
        {
            Assert.AreEqual(3, 3);
        }

        [Test]
        public void ServerTest4()
        {
            Assert.AreEqual(4, 4);
        }

        [Test]
        public void ServerTest5()
        {
            Assert.AreEqual(5, 5);
        }
    }
}
