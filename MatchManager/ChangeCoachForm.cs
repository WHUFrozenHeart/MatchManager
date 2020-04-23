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
    public partial class ChangeCoachForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string sex;
        private string idteam;
        public ChangeCoachForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public ChangeCoachForm(string name, string sex, string id, string phone, string idteam)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sex = sex;
            this.idteam = idteam;
            nameField.Text = name;
            if (sex == "男")
            {
                maleRadioButton.Checked = true;
                femaleRadioButton.Checked = false;
            }
            else
            {
                maleRadioButton.Checked = true;
                femaleRadioButton.Checked = true;
            }
            idField.Text = id;
            phoneField.Text = phone;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameField.Text != "" && sex != "" && idField.Text != "" && phoneField.Text != "")
                {
                    Coach coach = new Coach(idField.Text, nameField.Text, sex, phoneField.Text, idteam);
                    teamServices.ChangeCoach(coach);
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
            nameField.Text = "";
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            sex = "";
            idField.Text = "";
            phoneField.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                sex = "男";
            }
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked)
            {
                sex = "女";
            }
        }
    }
}
