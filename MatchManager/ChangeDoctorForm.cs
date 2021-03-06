﻿using System;
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
    public partial class ChangeDoctorForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        private string idteam;
        public ChangeDoctorForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        public ChangeDoctorForm(string name, string id, string phone, string idteam)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.idteam = idteam;
            nameField.Text = name;
            idField.Text = id;
            phoneField.Text = phone;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor doctor = new Doctor(idField.Text, nameField.Text, phoneField.Text, idteam);
                teamServices.ChangeDoctor(doctor);
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameField.Text = "";
            idField.Text = "";
            phoneField.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
