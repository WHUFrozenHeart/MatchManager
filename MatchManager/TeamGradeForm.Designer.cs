namespace MatchManager
{
    partial class TeamGradeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.teamDataGridView = new System.Windows.Forms.DataGridView();
            this.displayButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idteamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teamDataGridView
            // 
            this.teamDataGridView.AllowUserToAddRows = false;
            this.teamDataGridView.AllowUserToDeleteRows = false;
            this.teamDataGridView.AllowUserToResizeColumns = false;
            this.teamDataGridView.AllowUserToResizeRows = false;
            this.teamDataGridView.AutoGenerateColumns = false;
            this.teamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteamDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.teamDataGridView.DataSource = this.teamBindingSource;
            this.teamDataGridView.Location = new System.Drawing.Point(12, 13);
            this.teamDataGridView.MultiSelect = false;
            this.teamDataGridView.Name = "teamDataGridView";
            this.teamDataGridView.ReadOnly = true;
            this.teamDataGridView.RowHeadersVisible = false;
            this.teamDataGridView.RowTemplate.Height = 23;
            this.teamDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teamDataGridView.Size = new System.Drawing.Size(560, 150);
            this.teamDataGridView.TabIndex = 1;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.displayButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.displayButton.Location = new System.Drawing.Point(12, 170);
            this.displayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(175, 40);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "显示团队成绩";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(502, 219);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 40);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(MatchManager.Team);
            // 
            // idteamDataGridViewTextBoxColumn
            // 
            this.idteamDataGridViewTextBoxColumn.DataPropertyName = "idteam";
            this.idteamDataGridViewTextBoxColumn.HeaderText = "代表队号";
            this.idteamDataGridViewTextBoxColumn.Name = "idteamDataGridViewTextBoxColumn";
            this.idteamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "代表队名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TeamGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 266);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.teamDataGridView);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TeamGradeForm";
            this.Text = "查询团体成绩";
            this.Activated += new System.EventHandler(this.TeamGradeForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teamDataGridView;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button backButton;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}