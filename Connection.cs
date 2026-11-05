using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPMessage
{
    public class Connection
    {
        private const int _port = 13000;
        private TcpListener _tcpListener;
        private byte[] _buffer;
        private string _ip;

        public Connection(string ip)
        {
            _ip = ip;
            _tcpListener = new TcpListener(IPAddress.Parse(_ip), _port);
            _buffer = new byte[256];
        }

        public Connection() : this("127.0.0.1")
        { }

        public void Send(string message)
        {
            try
            {
                TcpClient client = new TcpClient(_ip, _port);

                //client.Connect(IPAddress.Any, _port);
                var tcpStream = client.GetStream();

                byte[] response = Encoding.UTF8.GetBytes(message);

                tcpStream.Write(response, 0, response.Length);
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string RecieveMessage()
        {
            try
            {
                _tcpListener.Start();
                string receivedMessage = null;

                if (_tcpListener.Pending())
                {
                    TcpClient client = _tcpListener.AcceptTcpClient();

                    var tcpStream = client.GetStream();
                    int readTotal;

                    while ((readTotal = tcpStream.Read(_buffer, 0, _buffer.Length)) != 0 ||
                        receivedMessage == null)
                    {
                        receivedMessage = Encoding.UTF8.GetString(_buffer, 0, _buffer.Length);
                        //tcpStream.Write(message, 0, message.Length);
                        break;
                    }
                    _buffer = new byte[256];
                    _tcpListener.Stop();
                    client.Dispose();
                }
                return receivedMessage;
            }
            catch
            {
                SetIp("127.0.0.1");
                throw new Exception("Adress not availible in this context" + Environment.NewLine + "Default adress(127.0.0.1)");
            }
        }

        public void SetIp(string newIp)
        {
            if(IPAddress.TryParse(newIp, out _))
            {
                _ip = newIp;
                _tcpListener.Stop();
                _tcpListener = new TcpListener(IPAddress.Parse(_ip), _port);
            } 
            else
            {
                throw (new Exception("Not an ip adress"));
            }
        }
    }
}
