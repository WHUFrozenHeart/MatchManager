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
    public partial class GroupForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idmatch;
        private string idgroup = "";
        private MajorRefereeForm majorRefereeForm;

        public GroupForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public GroupForm(string name, string sex, string age, MajorRefereeForm majorRefereeForm)
        {
            InitializeComponent();
            try
            {
                this.majorRefereeForm = majorRefereeForm;
                idmatch = teamServices.GetIDOfMatch(name, sex, age);
                groupBindingSource.DataSource = teamServices.GetAllGroupsOfID(idmatch);
                playerBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfNoneGroup(idmatch);
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = new Group(teamServices.GetNumOfAllGroups().ToString(), idmatch);
                teamServices.AddGroup(group);
                groupBindingSource.DataSource = teamServices.GetAllGroupsOfID(idmatch);
                groupBindingSource.ResetBindings(false);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            majorRefereeForm.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            majorRefereeForm.Show();
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (grouperBindingSource.Current != null)
                {
                    if (idgroup != "")
                    {
                        PlayerMatch temp = (PlayerMatch)grouperBindingSource.Current;
                        temp.idgroup = "";
                        teamServices.ChangePlayerMatch(temp);
                        grouperBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup);
                        playerBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfNoneGroup(idmatch);
                        grouperBindingSource.ResetBindings(false);
                        playerBindingSource.ResetBindings(false);
                    }
                    else //提示信息
                    {
                        MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerBindingSource.Current != null)
                {
                    if (idgroup != "")
                    {
                        if (teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup).Count < 5)
                        {
                            PlayerMatch temp = (PlayerMatch)playerBindingSource.Current;
                            temp.idgroup = idgroup;
                            teamServices.ChangePlayerMatch(temp);
                            grouperBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup);
                            playerBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfNoneGroup(idmatch);
                            grouperBindingSource.ResetBindings(false);
                            playerBindingSource.ResetBindings(false);
                        }
                        else //提示信息
                        {
                            MessageBox.Show("所分小组人数已达上限，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else //提示信息
                    {
                        MessageBox.Show("列表当前项为空，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void GroupDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (groupBindingSource.Current != null)
                {
                    idgroup = ((Group)groupBindingSource.Current).idgroup;
                    grouperBindingSource.DataSource = teamServices.GetAllPlayerMatchesOfGroup(idmatch, idgroup);
                    groupBindingSource.ResetBindings(false);
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

        private void GroupForm_Activated(object sender, EventArgs e)
        {
            groupDataGridView.ClearSelection();
        }
    }
}
