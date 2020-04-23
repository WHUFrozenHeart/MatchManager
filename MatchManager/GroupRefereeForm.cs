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
    public partial class GroupRefereeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idmatch;
        private string idgroup = "";
        private MajorRefereeForm majorRefereeForm;
        public GroupRefereeForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public GroupRefereeForm(string name, string sex, string age, MajorRefereeForm majorRefereeForm)
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
                refereeBindingSource.DataSource = teamServices.GetAllRefereesOfNotMajor();
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
                    teamServices.RemoveRefereeGroup((RefereeGroup)grouperBindingSource.Current);
                    grouperBindingSource.DataSource = teamServices.GetAllRefereeGroupsOfID(idgroup);
                    grouperBindingSource.ResetBindings(false);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (refereeBindingSource.Current != null)
                {
                    if (idgroup != "")
                    {
                        if (teamServices.GetAllRefereeGroupsOfID(idgroup).Count < 5)
                        {
                            Referee referee = (Referee)refereeBindingSource.Current;
                            if (!teamServices.IsRefereeGroupExist(idgroup, referee.id))
                            {
                                RefereeGroup refereeGroup = new RefereeGroup(teamServices.GetNumOfAllRefereeGroup().ToString(), idgroup, referee.id);
                                teamServices.AddRefereeGroup(refereeGroup);
                                grouperBindingSource.DataSource = teamServices.GetAllRefereeGroupsOfID(idgroup);
                                grouperBindingSource.ResetBindings(false);
                            }
                            else //提示信息
                            {
                                MessageBox.Show("该小组已经含有该裁判，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else //提示信息
                        {
                            MessageBox.Show("所选小组裁判人数已达上限，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else //提示信息
                    {
                        MessageBox.Show("列表当前项为空，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GroupDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (groupBindingSource.Current != null)
                {
                    idgroup = ((Group)groupBindingSource.Current).idgroup;
                    grouperBindingSource.DataSource = teamServices.GetAllRefereeGroupsOfID(idgroup);
                    groupBindingSource.ResetBindings(false);
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

        private void GroupRefereeForm_Activated(object sender, EventArgs e)
        {
            groupDataGridView.ClearSelection();
        }
    }
}
