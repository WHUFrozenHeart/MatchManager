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
    public partial class IndividualGradeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        public IndividualGradeForm()
        {
            InitializeComponent();
            try
            {
                playerBindingSource.DataSource = teamServices.GetAllPlayers();
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerBindingSource.Current != null)
                {
                    List<PlayerMatch> playerMatches = teamServices.GetPlayerMatch(((Player)playerBindingSource.Current).num);
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
                        sum = sum / count;
                        MessageBox.Show(sum.ToString(), "个人成绩", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //提示信息
                    {
                        MessageBox.Show("成绩信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else //提示信息
                {
                    MessageBox.Show("列表当前项为空，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void IndividualGradeForm_Activated(object sender, EventArgs e)
        {
            playerDataGridView.ClearSelection();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new CheckChooseForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
