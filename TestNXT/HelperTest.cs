using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ru.Rubinst.NXT;

namespace TestNXT
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void TestIntToBytes()
        {
            var result = ByteHelper.IntToBytes(300);
            var template = new byte[] {0x2C, 0x01};
            Assert.AreEqual(result.GetLength(0), 2);
            Assert.AreEqual(result[0], template[0]);
            Assert.AreEqual(result[1], template[1]);
        }

        [TestMethod]
        public void TestBytesToInt()
        {
            var result = ByteHelper.BytesToInt(new byte[] {0x2C, 0x01});
            Assert.AreEqual(result, 300);
        }
    }
}
