using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchManager
{
    public partial class LoginForm : Form
    {
        private TeamServices teamServices = new TeamServices(); //使用数据库
        private bool flag = false; //判断密码是否正确
        private List<Team> teams;
        private List<Referee> referees;
        private string name; //传递队伍名称
        private string idteam; //传递队伍id
        private string ismajor; //是否为东道主
        public LoginForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "代表队")
                {
                    teams = teamServices.GetAllTeams();
                    foreach (Team team in teams)
                    {
                        if (team.idteam == acountNumber.Text)
                        {
                            if (team.password == passWord.Text)
                            {
                                flag = true;
                                name = team.name;
                                idteam = team.idteam;
                                ismajor = team.ismajor;
                            }
                            else
                            {
                                flag = false;
                            }
                            break;
                        }
                    }
                    if (flag)
                    {
                        Thread thread = new Thread(func => { new AddForm(name, idteam, ismajor).ShowDialog(); });
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        this.Close();
                    }
                }
                else if (comboBox1.Text == "裁判员")
                {
                    string tempMajor = "NO";
                    string idreferee = "";
                    referees = teamServices.GetAllReferees();
                    foreach (Referee referee in referees)
                    {
                        if (referee.name == acountNumber.Text)
                        {
                            if (referee.id == passWord.Text)
                            {
                                flag = true;
                                tempMajor = referee.ismajor;
                                idreferee = referee.id;
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                    }
                    if (flag)
                    {
                        if (tempMajor == "YES")
                        {
                            Thread thread = new Thread(func => { new MajorRefereeForm().ShowDialog(); });
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                            this.Close();
                        }
                        else
                        {
                            Thread thread = new Thread(func => { new ScoreForm(idreferee).ShowDialog(); });
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                            this.Close();
                        }
                    }
                }
                if (!flag) //提示错误
                {
                    MessageBox.Show("用户名或者密码错误", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new StartForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
