using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ru.Rubinst.NXT;

namespace TestNXT
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void TestIntToBytes()
        {
            var result = NXTController.IntToBytes(300);
            var template = new byte[] {0x2C, 0x01};
            Assert.AreEqual(result.GetLength(0), 2);
            Assert.AreEqual(result[0], template[0]);
            Assert.AreEqual(result[1], template[1]);
        }

        [TestMethod]
        public void TestBytesToInt()
        {
            var result = NXTController.BytesToInt(new byte[] {0x2C, 0x01});
            Assert.AreEqual(result, 300);
        }
    }
}
