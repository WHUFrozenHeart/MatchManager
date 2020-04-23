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
    public partial class MajorRefereeForm : Form
    {
        private List<string> male = new List<string> { "单杠", "双杠", "吊环", "跳马", "自由体操", "鞍马", "蹦床" };
        private List<string> female = new List<string> { "跳马", "高低杠", "平衡木", "自由体操", "蹦床" };
        private string name;
        private string age;
        private string sex;

        public MajorRefereeForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sex = "男";
                matchCombox.Items.Clear();
                foreach (string matchName in male)
                {
                    matchCombox.Items.Add(matchName);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sex = "女";
                matchCombox.Items.Clear();
                foreach (string matchName in female)
                {
                    matchCombox.Items.Add(matchName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (workCombox.Text != "" && ageCombox.Text != "" && matchCombox.Text != "")
                {
                    name = matchCombox.Text;
                    if (ageCombox.Text == "7-8岁")
                    {
                        age = "78";
                    }
                    else if (ageCombox.Text == "9-10岁")
                    {
                        age = "910";
                    }
                    else
                    {
                        age = "1112";
                    }
                    if (workCombox.Text == "分组")
                    {
                        this.Hide();
                        new GroupForm(name, sex, age, this).ShowDialog();
                    }
                    else if (workCombox.Text == "打分")
                    {
                        this.Hide();
                        new MajorScoreForm(name, sex, age, this).ShowDialog();
                    }
                    else //分裁判
                    {
                        this.Hide();
                        new GroupRefereeForm(name, sex, age, this).ShowDialog();
                    }
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new LoginForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
