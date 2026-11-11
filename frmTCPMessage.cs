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
        private Connection _connection;
        private const string _ipDefault = "127.0.0.1";

        public frmMessagTCP()
        {
            InitializeComponent();
            _connection = new Connection();
            tbxIpAdress.Text = _ipDefault;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _connection.Send(tbxSend.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string message;
            try
            {
                message = _connection.RecieveMessage();
                if (message != null)
                {
                    tbxReceived.Text = message;
                }
            }
            catch (Exception ex)
            {
                tbxIpAdress.Text = _ipDefault;
                tbxLog.Text += ex + Environment.NewLine;
            }
        }

        private void btnSetIp_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.SetIp(tbxIpAdress.Text);
                tbxLog.Text += "Changement d'ip" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                tbxIpAdress.Text = _ipDefault;
                tbxLog.Text += ex.Message + Environment.NewLine;
            }
        }

        private void tbxLog_TextChanged(object sender, EventArgs e)
        {
            tbxLog.SelectionStart = tbxLog.Text.Length;
            tbxLog.ScrollToCaret();
        }
    }
}
