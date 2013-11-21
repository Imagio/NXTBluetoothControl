using System;

namespace Ru.Rubinst.NXT
{
    public class BluetoothConnectionException : Exception
    {
        public BluetoothConnectionException(string message = null, Exception innerException = null)
            : base(message, innerException)
        {
        }
    }
}
