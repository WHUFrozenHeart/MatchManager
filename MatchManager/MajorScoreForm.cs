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
    public partial class MajorScoreForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idmatch;
        private string idgroup = "";
        private MajorRefereeForm majorRefereeForm;
        public MajorScoreForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public MajorScoreForm(string name, string sex, string age, MajorRefereeForm majorRefereeForm)
        {
            InitializeComponent();
            try
            {
                this.majorRefereeForm = majorRefereeForm;
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                idmatch = teamServices.GetIDOfMatch(name, sex, age);
                groupBindingSource.DataSource = teamServices.GetAllGroupsOfID(idmatch);
                groupDataGridView.ClearSelection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void GroupDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (groupBindingSource.Current != null)
                {
                    idgroup = ((Group)groupBindingSource.Current).idgroup;
                    if (idgroup != null)
                    {
                        playerBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup);
                        playerBindingSource.ResetBindings(false);
                    }
                    else //提示信息
                    {
                        MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //提示信息
                {
                    MessageBox.Show("列表当前项为空，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerBindingSource.Current != null)
                {
                    if (((PlayerMatch)playerBindingSource.Current).grade == null) //只能给还没打过分的参赛选手打分
                    {
                        string num = ((PlayerMatch)playerBindingSource.Current).idplayer;
                        this.Hide();
                        new MajorControlForm(num, idgroup, idmatch, this).ShowDialog();
                        if (groupBindingSource.Current != null)
                        {
                            idgroup = ((Group)groupBindingSource.Current).idgroup;
                            if (idgroup != null)
                            {
                                playerBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup);
                                playerBindingSource.ResetBindings(false);
                            }
                        }
                    }
                    else //提示信息
                    {
                        MessageBox.Show("选手已打分，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            majorRefereeForm.Show();
            this.Close();
        }

        private void MajorScoreForm_Activated(object sender, EventArgs e)
        {
            groupDataGridView.ClearSelection();
        }
    }
}
