using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PortScaner
{
    public partial class main_win_form : Form
    {
        public main_win_form()
        {
            InitializeComponent();
        }
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                //connectDone.Set();
            }
            catch(Exception e)
            {

            }
        }
        private void btn_scan_Click(object sender, EventArgs e)
        {
            begin_port.Maximum = 65536;
            end_port.Maximum = 65536;
            begin_port.Minimum = 0;
            end_port.Minimum = 0;
            int BeginPort = Convert.ToInt32(begin_port.Value),EndPort = Convert.ToInt32(end_port.Value),i;
            progressBar.Maximum = EndPort = BeginPort + 1;
            progressBar.Value = 0;
            listView.Items.Clear();
            IPAddress addr = IPAddress.Parse(tIPAddress.Text);
            for(i= BeginPort; i<= EndPort; i++)
            {//creat and initiate socket
                IPEndPoint ep = new IPEndPoint(addr, i);
                Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IAsyncResult asyncResult = soc.BeginConnect(ep, new AsyncCallback(ConnectCallback), soc);
                if(!asyncResult.AsyncWaitHandle.WaitOne(30,false))
                {
                    soc.Close();
                    listView.Items.Add("Порт " + i.ToString());
                    listView.Items[i - BeginPort].SubItems.Add("закрыт");
                    listView.Refresh();
                    progressBar.Value += 1;
                }
                else
                {
                    soc.Close();
                    listView.Items.Add("Порт " + i.ToString());
                    listView.Items[i - BeginPort].SubItems.Add("открыт");
                    listView.Refresh();
                    progressBar.Value += 1;
                }
            }
        }
    }
}
