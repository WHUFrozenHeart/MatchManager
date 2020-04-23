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
    public partial class CheckChooseForm : Form
    {
        public CheckChooseForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new TeamGradeForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void IndividualButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new IndividualGradeForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void MatchButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new MatchGradeForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new StartForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
