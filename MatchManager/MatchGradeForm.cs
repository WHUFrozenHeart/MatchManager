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
    public partial class MatchGradeForm : Form
    {
        private TeamServices teamServices = new TeamServices();
        public MatchGradeForm()
        {
            InitializeComponent();
            try
            {
                this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
                this.skinEngine1.SkinFile = Application.StartupPath + "//MacOS.ssk";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                matchBindingSource.DataSource = teamServices.GetAllMatches();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new CheckChooseForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(func => { new CheckChooseForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void GroupDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (matchBindingSource.Current != null)
                {
                    rankDataGridView.Rows.Clear();
                    int rank = 1;
                    List<PlayerMatch> playerMatches = teamServices.GetPlayerMatchOfMatch(((Match)matchBindingSource.Current).idmatch);
                    playerMatches.Sort((a, b) =>
                    {
                        if (a.grade == null)
                        {
                            return 1;
                        }
                        else if (b.grade == null)
                        {
                            return -1;
                        }
                        else
                        {
                            return b.grade.CompareTo(a.grade);
                        }
                    });
                    for (int i = 0; i < playerMatches.Count; i++)
                    {
                        if (i != 0)
                        {
                            if (playerMatches[i].grade != playerMatches[i - 1].grade)
                            {
                                rank = i + 1;
                            }
                        }
                        rankDataGridView.Rows.Add();
                        rankDataGridView.Rows[i].Cells[0].Value = rank.ToString();
                        rankDataGridView.Rows[i].Cells[1].Value = playerMatches[i].idplayer;
                        rankDataGridView.Rows[i].Cells[2].Value = playerMatches[i].grade;
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void MatchGradeForm_Activated(object sender, EventArgs e)
        {
            matchDataGridView.ClearSelection();
        }
    }
}
