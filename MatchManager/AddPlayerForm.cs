using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MatchManager
{
    public partial class AddPlayerForm : Form
    {
        private TeamServices teamServices = new TeamServices(); //使用数据库
        private Team team; //代表队
        private string sex = ""; //保存性别信息
        private string idteam; //存储传递的队号
        private string ismajor; //是否为东道主
        private string age; //保存年龄信息
        private int countForPlayer; //代表队某性别某年龄组人数
        private int countForMatch; //添加的队员选择的比赛数目
        private AddForm addForm;

        public AddPlayerForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public AddPlayerForm(string idteam, string ismajor,AddForm addForm)
        {
            InitializeComponent();
            this.idteam = idteam;
            this.ismajor = ismajor;
            this.addForm = addForm;
            this.team = teamServices.GetTeam(idteam);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked == true)
            {
                foreach (CheckBox checkBox in femalePanel.Controls)
                {
                    checkBox.Checked = false;
                }
                malePanel.Visible = true;
                femalePanel.Visible = false;
                sex = "男";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked == true)
            {
                foreach (CheckBox checkBox in malePanel.Controls)
                {
                    checkBox.Checked = false;
                }
                malePanel.Visible = false;
                femalePanel.Visible = true;
                sex = "女";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameField.Text != "" && sex != "" && idField.Text != "" && groupCombox.Text != "")
                {
                    countForMatch = 0;
                    countForPlayer = 0;
                    if (sex == "男")
                    {
                        foreach (CheckBox checkBox in malePanel.Controls) //统计该选手选择的项目数目
                        {
                            if (checkBox.Checked)
                            {
                                countForMatch++;
                            }
                        }
                    }
                    else
                    {
                        foreach (CheckBox checkBox in femalePanel.Controls) //统计该选手选择的项目数目
                        {
                            if (checkBox.Checked)
                            {
                                countForMatch++;
                            }
                        }
                    }
                    if (groupCombox.Text == "7-8岁") //判断各代表队各年龄组参赛选手人数，如果符合规定则更新到数据库
                    {
                        countForPlayer = team.firstage + countForMatch;
                        if (countForPlayer <= 6)
                        {
                            team.firstage = countForPlayer;
                            teamServices.ChangeTeam(team);
                        }
                        age = "78";
                    }
                    else if (groupCombox.Text == "9-10岁")
                    {
                        countForPlayer = team.secondage + countForMatch;
                        if (countForPlayer <= 6)
                        {
                            team.secondage = countForPlayer;
                            teamServices.ChangeTeam(team);
                        }
                        age = "910";
                    }
                    else
                    {
                        countForPlayer = team.thirdage + countForMatch;
                        if (countForPlayer <= 6)
                        {
                            team.thirdage = countForPlayer;
                            teamServices.ChangeTeam(team);
                        }
                        age = "1112";
                    }
                    if (countForPlayer <= 6)
                    {
                        if (ismajor == "YES") //东道主参赛人员排序
                        {
                            if (sex == "男")
                            {
                                Player player = new Player(teamServices.GetNumOfAllPlayers().ToString(), (teamServices.GetNumOfMalePlayer() * 2 + 1).ToString(), nameField.Text, idField.Text, age, sex, "", idteam, ismajor);
                                teamServices.AddPlayer(player);
                                foreach (CheckBox checkBox in malePanel.Controls)
                                {
                                    if (checkBox.Checked)
                                    {
                                        PlayerMatch playerMatch = new PlayerMatch(teamServices.GetNumOfAllPlayerMatches().ToString(), player.num, teamServices.GetIDOfMatch(checkBox.Text, sex, age));
                                        teamServices.AddPlayerMatch(playerMatch);
                                    }
                                }
                            }
                            else if (sex == "女")
                            {
                                Player player = new Player(teamServices.GetNumOfAllPlayers().ToString(), (teamServices.GetNumOfFemalePlayer() * 2 + 2).ToString(), nameField.Text, idField.Text, age, sex, "", idteam, ismajor);
                                teamServices.AddPlayer(player);
                                foreach (CheckBox checkBox in femalePanel.Controls)
                                {
                                    if (checkBox.Checked)
                                    {
                                        PlayerMatch playerMatch = new PlayerMatch(teamServices.GetNumOfAllPlayerMatches().ToString(), player.num, teamServices.GetIDOfMatch(checkBox.Text, sex, age));
                                        teamServices.AddPlayerMatch(playerMatch);
                                    }
                                }
                            }
                        }
                        else //非东道主参赛人员排序
                        {
                            if (sex == "男")
                            {
                                teamServices.ChangeMalePlayerOfMajor();
                                Player player = new Player(teamServices.GetNumOfAllPlayers().ToString(), ((teamServices.GetNumOfMalePlayer() - teamServices.GetNumOfAllMalePlayersOfMajor()) * 2 + 1).ToString(), nameField.Text, idField.Text, age, sex, "", idteam, ismajor);
                                teamServices.AddPlayer(player);
                                foreach (CheckBox checkBox in malePanel.Controls)
                                {
                                    if (checkBox.Checked)
                                    {
                                        PlayerMatch playerMatch = new PlayerMatch(teamServices.GetNumOfAllPlayerMatches().ToString(), player.num, teamServices.GetIDOfMatch(checkBox.Text, sex, age));
                                        teamServices.AddPlayerMatch(playerMatch);
                                    }
                                }
                            }
                            else if (sex == "女")
                            {
                                teamServices.ChangeFemalePlayerOfMajor();
                                teamServices.ChangeMalePlayerOfMajor();
                                Player player = new Player(teamServices.GetNumOfAllPlayers().ToString(), ((teamServices.GetNumOfFemalePlayer() - teamServices.GetNumOfAllFemalePlayersOfMajor()) * 2 + 2).ToString(), nameField.Text, idField.Text, age, sex, "", idteam, ismajor);
                                teamServices.AddPlayer(player);
                                foreach (CheckBox checkBox in femalePanel.Controls)
                                {
                                    if (checkBox.Checked)
                                    {
                                        PlayerMatch playerMatch = new PlayerMatch(teamServices.GetNumOfAllPlayerMatches().ToString(), player.num, teamServices.GetIDOfMatch(checkBox.Text, sex, age));
                                        teamServices.AddPlayerMatch(playerMatch);
                                    }
                                }
                            }
                        }
                        ClearAllMessage();
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //提示信息
                    {
                        MessageBox.Show("此性别此年龄组报名人数超过上限，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else //提示信息
                {
                    MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
        }

        private void ClearAllMessage()
        {
            nameField.Text = "";
            idField.Text = "";
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            foreach (CheckBox checkBox in malePanel.Controls)
            {
                checkBox.Checked = false;
            }
            foreach (CheckBox checkBox in femalePanel.Controls)
            {
                checkBox.Checked = false;
            }
        }

        private void IdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
