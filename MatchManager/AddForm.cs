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
    public partial class AddForm : Form
    {
        private string idteam;
        private string ismajor; //是否为东道主
        public AddForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public AddForm(string name, string idteam, string ismajor)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            teamName.Text = name;
            this.idteam = idteam;
            this.ismajor = ismajor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new LoginForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddLeaderAndDocForm(idteam, this).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPlayerForm(idteam, ismajor, this).ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCoachForm(idteam, this).ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new AddRefereeForm(idteam, this).ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new UploadForm(idteam, this).ShowDialog();
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeamDetailForm(idteam, this).ShowDialog();
        }
    }
}
