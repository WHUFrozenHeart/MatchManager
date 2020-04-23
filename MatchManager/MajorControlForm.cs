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
    public partial class MajorControlForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string playerInfo; //传递给小裁判的信息
        private PlayerMatch playerMatch; //选手的数据库实例
        private MajorScoreForm majorScoreForm;
        //创建socket实例
        static string host = "192.168.137.1"; //本机IP
        static int port = 1024; //端口号
        static IPAddress ip = IPAddress.Parse(host);
        IPEndPoint point = new IPEndPoint(ip, port);
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Dictionary<string, string> referees = new Dictionary<string, string>();
        Dictionary<string, Socket> socketClients = new Dictionary<string, Socket>(); //保存客户端的socket
        Dictionary<Socket, string> grades = new Dictionary<Socket, string>(); //保存成绩
        List<string> ids; //保存需要识别的客户端的id

        public MajorControlForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public MajorControlForm(string num, string idgroup, string idmatch, MajorScoreForm majorScoreForm)
        {
            InitializeComponent();
            try
            {
                this.majorScoreForm = majorScoreForm;
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                Control.CheckForIllegalCrossThreadCalls = false;
                numLabel.Text = num;
                nameLabel.Text = teamServices.GetNameOfPlayer(num);
                playerInfo = "@" + num + "@" + nameLabel.Text;
                playerMatch = teamServices.GetPlayerMatch(num, idmatch);
                ids = teamServices.GetAllIDOfRefereeGroup(idgroup);
                foreach (string id in ids)
                {
                    referees.Add(teamServices.GetNameOfReferee(id), id);
                }
                foreach (string name in referees.Keys)
                {
                    nameCombox.Items.Add(name);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                socket.Bind(point);
                StartListen();
                Console.WriteLine("开始监听。");
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void StartListen()
        {
            try
            {
                socket.Listen(5); //同时监听的最大数量
                Thread thread = new Thread(Listen);
                thread.IsBackground = true; //后台运行不打扰主线程
                thread.Start(socket);
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void Listen(object socket) //监听客户端
        {
            Socket socketWatch = socket as Socket;
            while (true)
            {
                try
                {
                    Socket socketListen = socketWatch.Accept();
                    Console.WriteLine("正在监听：" + socketListen.RemoteEndPoint.ToString());
                    Thread thread = new Thread(Receive);
                    thread.IsBackground = true;
                    thread.Start(socketListen);
                }
                catch (SocketException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void Receive(object socket) //接收客户端的信息
        {
            Socket socketReceive = socket as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int count = socketReceive.Receive(buffer);
                    if (count == 0)
                    {
                        break;
                    }
                    string data = Encoding.UTF8.GetString(buffer, 0, count);
                    Console.WriteLine("接收到客户端信息：" + data);
                    if (ids.Contains(data))
                    {
                        if (!socketClients.ContainsKey(data))
                        {
                            socketClients.Add(data, socketReceive);
                            grades.Add(socketReceive, "");
                        }
                    }
                    else if (grades.ContainsKey(socketReceive))
                    {
                        grades[socketReceive] = data;
                        if (nameCombox.Text != "")
                        {
                            gradeLabel.Text = grades[socketClients[referees[nameCombox.Text]]];
                        }
                    }
                    byte[] playerInfoBuffer = Encoding.UTF8.GetBytes(playerInfo);
                    socketReceive.Send(playerInfoBuffer);
                }
                catch (SocketException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void Send(string data, string id) //给客户端发送消息
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                socketClients[id].Send(buffer);
                Console.WriteLine("正在给客户端：" + socketClients[id].RemoteEndPoint.ToString() + "发送信息：" + data);
            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (gradeLabel.Text != "")
            {
                nameCombox.Items.Remove(nameCombox.SelectedItem);
                nameCombox.Text = "";
                gradeLabel.Text = "";
            }
            else //提示信息
            {
                MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (nameCombox.Items.Count == 0)
            {
                CaculateAverageGrade();
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (nameCombox.Text != "")
            {
                Send("NO", referees[nameCombox.Text]);
                grades[socketClients[referees[nameCombox.Text]]] = "";
                gradeLabel.Text = "";
            }
            else //提示信息
            {
                MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CaculateAverageGrade()
        {
            List<string> tempGrades = grades.Values.ToList<string>();
            if (tempGrades.Count <= 2)
            {
                int sum = 0;
                foreach (string grade in tempGrades)
                {
                    sum += int.Parse(grade);
                }
                averageGradeLabel.Text = ((int)(sum / tempGrades.Count)).ToString();
            }
            else
            {
                int sum = 0;
                int max;
                int min;
                max = min = int.Parse(tempGrades[0]);
                foreach (string grade in tempGrades)
                {
                    int temp = int.Parse(grade);
                    sum += temp;
                    if (max < temp)
                    {
                        max = temp;
                    }
                    if (min > temp)
                    {
                        min = temp;
                    }
                }
                averageGradeLabel.Text = ((int)((sum - max - min) / (tempGrades.Count - 2))).ToString();
            }
        }

        private void HandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameCombox.Items.Count == 0)
                {
                    playerMatch.grade = (int.Parse(averageGradeLabel.Text) + int.Parse(rewardField.Text) - int.Parse(pulishField.Text)).ToString();
                    teamServices.ChangePlayerMatch(playerMatch);
                    majorScoreForm.Show();
                    this.Close();
                }
                else //提示信息
                {
                    MessageBox.Show("未通过所有裁判，请先通过所有裁判成绩后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void RewardField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PulishField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void NameCombox_TextChanged(object sender, EventArgs e)
        {
            if (nameCombox.Text != "")
            {
                okButton.Enabled = true;
                redoButton.Enabled = true;
                try
                {
                    gradeLabel.Text = grades[socketClients[referees[nameCombox.Text]]];
                }
                catch
                {
                    MessageBox.Show("该裁判还没有登录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gradeLabel.Text = "";
                }
            }
            else
            {
                okButton.Enabled = false;
                redoButton.Enabled = false;
            }
        }
    }
}
