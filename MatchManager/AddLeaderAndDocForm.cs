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

    public partial class AddLeaderAndDocForm : Form
    {
        private TeamServices teamServices = new TeamServices(); //使用数据库
        private string name = null; //保存信息
        private string id = null; //保存信息
        private string phone = null; //保存信息
        private string idteam; //存储传递的队号
        private AddForm addForm;

        public AddLeaderAndDocForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public AddLeaderAndDocForm(string idteam, AddForm addForm)
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

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
        }

        private void ClearAllMessage()
        {
            name = nameField.Text = "";
            id = idField.Text = "";
            phone = phoneField.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp1, temp2, temp3;
            temp1 = nameField.Text;
            temp2 = idField.Text;
            temp3 = phoneField.Text;

            nameField.Text = name;
            idField.Text = id;
            phoneField.Text = phone;

            name = temp1;
            id = temp2;
            phone = temp3;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameField.Text != "" && idField.Text != "" && phoneField.Text != "" && identityCombox.Text != "")
                {
                    if (identityCombox.Text == "领队")
                    {
                        Leader leader = new Leader(idField.Text, nameField.Text, phoneField.Text, idteam);
                        teamServices.AddLeader(leader);
                    }
                    else if (identityCombox.Text == "队医")
                    {
                        Doctor doctor = new Doctor(idField.Text, nameField.Text, phoneField.Text, idteam);
                        teamServices.AddDoctor(doctor);
                    }
                    ClearAllMessage();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void IdentityCombox_TextChanged(object sender, EventArgs e)
        {
            ClearAllMessage();
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
