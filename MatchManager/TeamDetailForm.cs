using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchManager
{
    public partial class TeamDetailForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private AddForm addForm;
        private string idteam;
        public TeamDetailForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public TeamDetailForm(string idteam, AddForm addForm)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.idteam = idteam;
            this.addForm = addForm;
            leaderBindingSource.DataSource = teamServices.GetLeaderOfTeam(idteam);
            doctorBindingSource.DataSource = teamServices.GetDoctorOfTeam(idteam);
            coachBindingSource.DataSource = teamServices.GetCoachOfTeam(idteam);
            refereeBindingSource.DataSource = teamServices.GetRefereeOfTeam(idteam);
            playerBindingSource.DataSource = teamServices.GetPlayerOfTeam(idteam);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void TeamDetailForm_Activated(object sender, EventArgs e)
        {
            leaderDataGridView.ClearSelection();
            doctorDataGridView.ClearSelection();
            coachDataGridView.ClearSelection();
            refereeDataGridView.ClearSelection();
            playerDataGridView.ClearSelection();
        }

        private void LeaderDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (leaderBindingSource.Current != null)
                {
                    Leader leader = (Leader)leaderBindingSource.Current;
                    new ChangeLeaderForm(leader.name, leader.id, leader.phone, leader.idteam).ShowDialog();
                    leaderBindingSource.DataSource = teamServices.GetLeaderOfTeam(idteam);
                    leaderBindingSource.ResetBindings(false);
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

        private void DoctorDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (doctorBindingSource.Current != null)
                {
                    Doctor doctor = (Doctor)doctorBindingSource.Current;
                    new ChangeDoctorForm(doctor.name, doctor.id, doctor.phone, doctor.idteam).ShowDialog();
                    doctorBindingSource.DataSource = teamServices.GetDoctorOfTeam(idteam);
                    doctorBindingSource.ResetBindings(false);
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

        private void CoachDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (coachBindingSource.Current != null)
                {
                    Coach coach = (Coach)coachBindingSource.Current;
                    new ChangeCoachForm(coach.name, coach.sex, coach.id, coach.phone, coach.idteam).ShowDialog();
                    coachBindingSource.DataSource = teamServices.GetCoachOfTeam(idteam);
                    coachBindingSource.ResetBindings(false);
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

        private void RefereeDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (refereeBindingSource.Current != null)
                {
                    Referee referee = (Referee)refereeBindingSource.Current;
                    new ChangeRefereeForm(referee.name, referee.id, referee.phone, referee.ismajor, referee.idteam).ShowDialog();
                    refereeBindingSource.DataSource = teamServices.GetRefereeOfTeam(idteam);
                    refereeBindingSource.ResetBindings(false);
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

        private void PlayerDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (playerBindingSource.Current != null)
                {
                    Player player = (Player)playerBindingSource.Current;
                    new PlayerDetailForm(player.num).ShowDialog();
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
    }
}
