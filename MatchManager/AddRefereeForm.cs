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
    public partial class AddRefereeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idteam;
        private AddForm addForm;

        public AddRefereeForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public AddRefereeForm(string idteam,AddForm addForm)
        {
            InitializeComponent();
            this.addForm = addForm;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.idteam = idteam;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameField.Text != "" & idField.Text != "" & phoneField.Text != "")
                {
                    Referee referee = new Referee(idField.Text, nameField.Text, phoneField.Text, "NO", idteam);
                    teamServices.AddReferee(referee);
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //提示信息
                {
                    MessageBox.Show("信息错误，请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearAllMessage();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
        }

        private void ClearAllMessage()
        {
            idField.Text = "";
            nameField.Text = "";
            phoneField.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void IdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PhoneField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
