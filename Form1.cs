using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Pipes;
using System.Collections;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading.Tasks;

namespace TCPSever
{
    public partial class TCPSever : Form
    {

        public BinaryReader br;
        public BinaryWriter bw;
        private TcpClient client;
        private string time;
        private Boolean isTcpConnected = false;

        public TCPSever()
        {
            InitializeComponent();
        }

        private void StartTCPListen_Click(object sender, EventArgs e)
        {
            Task.Run(() =>  StartListening());
        }

        public async void StartListening()//开始监听
        {
            int TcpPort = 5000;//TCP端口
            IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipa = null;

            for (Int16 i = 0; i < ip.AddressList.Length; i++)
            {
                if (ip.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    ipa = ip.AddressList[i];
                    break;
                }
            }

            try
            {
                IPEndPoint TcpEndpoint = new IPEndPoint(ipa, TcpPort);
                await WaitForConnectionAsync(TcpEndpoint);//处理该节点
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private Task WaitForConnectionAsync(IPEndPoint iPEnd)//连接一个节点，并开始服务
        {
            TcpListener _TCPListener = new TcpListener(iPEnd);
            _TCPListener.Start();
            byte[] bytes = new byte[1024];
            client = _TCPListener.AcceptTcpClient();
            this.Invoke(new Action(() => State.Text = "连接成功"));
            isTcpConnected = true;
            while (true)
            {
                NetworkStream clientStream = client.GetStream();//利用TcpClient对象GetStream方法得到网络流
                if (clientStream.DataAvailable)
                {
                    br = new BinaryReader(clientStream);
                    string receive = null;
                    receive = br.ReadString();//读取
                    if (receive.Length > 0)
                    {
                        try
                        {
                            time = DateTime.Now.ToString();
                            this.Invoke(new Action(() => ReceiveTextBox.Text +=time + "       " + "客户端说：" + "\r\n" + receive + "\r\n"));
                        }
                        catch (ObjectDisposedException)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        private void SendBotton_Click(object sender, EventArgs e)
        {
            if (isTcpConnected==true)
            {
                NetworkStream clientStream = client.GetStream();
                bw = new BinaryWriter(clientStream);
                bw.Write(SendTextBox.Text);
                time = DateTime.Now.ToString();
                this.Invoke(new Action(() => ReceiveTextBox.Text += time + "       " + "我说：" + "\r\n" + SendTextBox.Text + "\r\n"));
                SendTextBox.Clear();
            }
            else
            {
                MessageBox.Show("请先进行连接");
            }

        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SendBotton_Click(sender, e);
            }
        }
    }
}
