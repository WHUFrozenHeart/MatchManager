using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchManager
{
    public partial class UploadForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idteam;
        private byte[] file;
        private AddForm addForm;
        public UploadForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public UploadForm(string idteam, AddForm addForm)
        {
            InitializeComponent();
            this.addForm = addForm;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.idteam = idteam;
            DisplayPic();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = false;
                open.Title = "请选择图片";
                open.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filePath = open.FileName;
                    FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] buffer = binaryReader.ReadBytes(Convert.ToInt32(fileStream.Length));
                    File temp = new File(idteam, buffer);
                    teamServices.ChangeFile(temp);
                    DisplayPic();
                    binaryReader.Close();
                    fileStream.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void DisplayPic()
        {
            try
            {
                file = teamServices.GetPicOfTeam(idteam);
                if (file != null)
                {
                    MemoryStream memoryStream = new MemoryStream(file);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    memoryStream.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }
    }
}
