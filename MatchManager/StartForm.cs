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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new LoginForm().ShowDialog(); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new CheckChooseForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new InputCulturalGradeForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
