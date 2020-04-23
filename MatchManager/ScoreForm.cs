using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchManager
{
    public partial class ScoreForm : Form
    {
        //创建socket实例
        static string host = "192.168.137.1"; //远程服务器的IP
        static int port = 1024; //远程服务器的端口号
        static IPAddress ip = IPAddress.Parse(host);
        IPEndPoint point = new IPEndPoint(ip, port);
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public ScoreForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public ScoreForm(string id)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                socket.Connect(point);
                Console.WriteLine("连接成功：" + socket.RemoteEndPoint.ToString());
                Thread thread = new Thread(Receive);
                thread.IsBackground = true;
                thread.Start();
                Send(id);
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void Send(string data) //发送给服务器数据
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                socket.Send(buffer);
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void Receive() //接收服务器数据
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int count = socket.Receive(buffer);
                    if (count == 0)
                    {
                        break;
                    }
                    string data = Encoding.UTF8.GetString(buffer, 0, count);
                    Console.WriteLine("接收到服务器消息：" + data);
                    if (data == "NO")
                    {
                        handButton.Enabled = true;
                    }
                    else
                    {
                        string[] datas = data.Split('@');
                        numLabel.Text = datas[1];
                        nameLabel.Text = datas[2];
                    }
                }
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void HandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gradeField.Text != "")
                {
                    Send(gradeField.Text);
                    Console.WriteLine("向服务器发送消息：" + gradeField.Text);
                    handButton.Enabled = false;
                }
                else //提示信息
                {
                    MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void GradeField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new LoginForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new LoginForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
