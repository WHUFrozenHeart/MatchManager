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
    public partial class InputCulturalGradeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        public InputCulturalGradeForm()
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

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PlayerDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (playerBindingSource.Current != null)
            {
                gradeField.Text = "";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new StartForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gradeField.Text != "" && playerBindingSource.Current != null)
                {
                    Player player = (Player)playerBindingSource.Current;
                    player.grade = gradeField.Text;
                    teamServices.ChangePlayer(player);
                    playerBindingSource.DataSource = teamServices.GetAllPlayers();
                    playerBindingSource.ResetBindings(false);
                    MessageBox.Show("录入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void InputCulturalGradeForm_Activated(object sender, EventArgs e)
        {
            playerDataGridView.ClearSelection();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new StartForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
