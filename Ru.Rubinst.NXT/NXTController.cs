using System;
using System.IO.Ports;
using System.Reflection;

namespace Ru.Rubinst.NXT
{
    public class NXTController : INXTController
    {
        private readonly SerialPort _serialPort;

        public bool IsConnected { get { return _serialPort != null && _serialPort.IsOpen; } }

        public NXTController(string portName)
        {
            try
            {
                _serialPort = new SerialPort(portName);
            }
            catch (Exception exception)
            {
                throw new BluetoothConnectionException(String.Format("Could not create SerialPort with name \"{0}\"", portName), exception);
            }
            try
            {
                _serialPort.Open();
                _serialPort.ReadTimeout = 1500;
            }
            catch (Exception exception)
            {
                throw new BluetoothConnectionException(String.Format("Could not open SerialPort with name \"{0}\"", portName), exception);
            }
        }

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
