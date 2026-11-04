using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPMessage
{
    public partial class frmMessagTCP : Form
    {
        private const int _port = 13000;
        private TcpListener _tcpListener;
        private byte[] _buffer = new byte[256];

        public frmMessagTCP()
        {
            InitializeComponent();
            var ipAdress = IPAddress.Parse("127.0.0.1");
            _tcpListener = new TcpListener(ipAdress, _port);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string receivedMessage = string.Empty;
            try
            {
                var client = new TcpClient("127.0.0.1", _port);

                //client.Connect(IPAddress.Any, _port);
                var tcpStream = client.GetStream();

                var response = Encoding.UTF8.GetBytes(tbxSend.Text);

                tcpStream.Write(response, 0, response.Length);
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RecieveMessage();
        }

        private async void RecieveMessage()
        {
            _tcpListener.Start();
            string receivedMessage = string.Empty;

            if (_tcpListener.Pending())
            {
                TcpClient client = _tcpListener.AcceptTcpClient();

                var tcpStream = client.GetStream();

                int readTotal;

                while ((readTotal = tcpStream.Read(_buffer, 0, _buffer.Length)) != 0 ||
                    receivedMessage == string.Empty)
                {
                    receivedMessage = Encoding.UTF8.GetString(_buffer, 0, _buffer.Length);
                    //tcpStream.Write(message, 0, message.Length);
                    break;
                }

                tbxReceived.Text = receivedMessage;
                _tcpListener.Stop();
                client.Dispose();
            }
        }
    }
}
