using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ru.Rubinst.NXT
{
    public static class ByteHelper
    {
        public static byte[] IntToBytes(int value)
        {
            var result = new byte[(int)Math.Log(value, 256) + 1];
            var i = 0;
            while (value > 0)
            {
                result[i] = (byte)(value % 256);
                value = value >> 8;
                i++;
            }
            return result;
        }

        public static int BytesToInt(byte[] value)
        {
            var result = 0;
            var length = value.GetLength(0);
            for (var i = length - 1; i >= 0; i--)
            {
                result = result << 8;
                result += value[i];
            }
            return result;
        }
    }
}
