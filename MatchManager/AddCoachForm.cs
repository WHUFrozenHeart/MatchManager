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
    public partial class AddCoachForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idteam; //接受传递的队伍id
        private string sex = ""; //保存性别信息
        private AddForm addForm;
        public AddCoachForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public AddCoachForm(string idteam, AddForm addForm)
        {
            InitializeComponent();
            this.addForm = addForm;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.idteam = idteam;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameField.Text != "" && idField.Text != "" && phoneField.Text != "" && sex != "")
                {
                    Coach coach = new Coach(idField.Text, nameField.Text, sex, phoneField.Text, idteam);
                    teamServices.AddCoach(coach);
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                sex = "男";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked)
            {
                sex = "女";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
        }

        private void ClearAllMessage()
        {
            nameField.Text = "";
            idField.Text = "";
            phoneField.Text = "";
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
        }

        private void PhoneField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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
