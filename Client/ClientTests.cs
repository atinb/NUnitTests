using System;
using NUnit.Framework;

namespace ClientTests
{
    [TestFixture]
    public class ClientTests
    {
        [Test]        

        public void ClientTest1()
        {
            string str = "Firefox BVT";
            Assert.AreEqual("Firefox BVT", str);
        }

        [Test]        
        public void ClientTest2()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]        
        public void ClientTest3()
        {
            Assert.AreEqual(3, 3);
        }

        [Test]        
        public void ClientTest4()
        {
            Assert.AreEqual(4, 4);
        }

        [Test]        
        public void ClientTest5()
        {
                Assert.Equals(5, 5);
        }
    }
}
