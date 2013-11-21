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
    }
}
