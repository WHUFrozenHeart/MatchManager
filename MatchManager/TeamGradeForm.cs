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
    public partial class TeamGradeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        public TeamGradeForm()
        {
            InitializeComponent();
            try
            {
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                teamBindingSource.DataSource = teamServices.GetAllTeams();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (teamBindingSource.Current != null)
                {
                    List<Player> players = teamServices.GetPlayerOfTeam(((Team)teamBindingSource.Current).idteam);
                    if (players.Count >= 4)
                    {
                        int teamGrade = 0;
                        foreach (Player player in players)
                        {
                            List<PlayerMatch> playerMatches = teamServices.GetPlayerMatch(player.num);
                            int sum = 0;
                            int count = 0;
                            foreach (PlayerMatch playerMatch in playerMatches)
                            {
                                if (playerMatch.grade != null && playerMatch.grade != "")
                                {
                                    sum += int.Parse(playerMatch.grade);
                                    count++;
                                }
                            }
                            if (count != 0)
                            {
                                teamGrade = teamGrade + sum / count;
                            }
                        }
                        teamGrade = teamGrade / players.Count;
                        MessageBox.Show(teamGrade.ToString(), "团队成绩", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //提示信息
                    {
                        MessageBox.Show("人数不足四人，没有团队成绩", "团队成绩", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else //提示消息
                {
                    MessageBox.Show("列表当前项为空，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new CheckChooseForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void TeamGradeForm_Activated(object sender, EventArgs e)
        {
            teamDataGridView.ClearSelection();
        }
    }
}
