namespace MatchManager
{
    partial class MatchGradeForm
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
            this.matchDataGridView = new System.Windows.Forms.DataGridView();
            this.rankDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idmatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.matchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matchDataGridView
            // 
            this.matchDataGridView.AllowUserToAddRows = false;
            this.matchDataGridView.AllowUserToDeleteRows = false;
            this.matchDataGridView.AllowUserToResizeColumns = false;
            this.matchDataGridView.AllowUserToResizeRows = false;
            this.matchDataGridView.AutoGenerateColumns = false;
            this.matchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmatchDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.matchDataGridView.DataSource = this.matchBindingSource;
            this.matchDataGridView.Location = new System.Drawing.Point(12, 12);
            this.matchDataGridView.MultiSelect = false;
            this.matchDataGridView.Name = "matchDataGridView";
            this.matchDataGridView.ReadOnly = true;
            this.matchDataGridView.RowHeadersVisible = false;
            this.matchDataGridView.RowTemplate.Height = 23;
            this.matchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matchDataGridView.Size = new System.Drawing.Size(560, 150);
            this.matchDataGridView.TabIndex = 1;
            this.matchDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GroupDataGridView_MouseClick);
            // 
            // rankDataGridView
            // 
            this.rankDataGridView.AllowUserToAddRows = false;
            this.rankDataGridView.AllowUserToDeleteRows = false;
            this.rankDataGridView.AllowUserToResizeColumns = false;
            this.rankDataGridView.AllowUserToResizeRows = false;
            this.rankDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankColumn,
            this.PlayerIDColumn,
            this.GradeColumn});
            this.rankDataGridView.Location = new System.Drawing.Point(12, 168);
            this.rankDataGridView.MultiSelect = false;
            this.rankDataGridView.Name = "rankDataGridView";
            this.rankDataGridView.ReadOnly = true;
            this.rankDataGridView.RowHeadersVisible = false;
            this.rankDataGridView.RowTemplate.Height = 23;
            this.rankDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rankDataGridView.Size = new System.Drawing.Size(560, 150);
            this.rankDataGridView.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(293, 325);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 40);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.okButton.Location = new System.Drawing.Point(176, 325);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 40);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
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
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(MatchManager.Match);
            // 
            // idmatchDataGridViewTextBoxColumn
            // 
            this.idmatchDataGridViewTextBoxColumn.DataPropertyName = "idmatch";
            this.idmatchDataGridViewTextBoxColumn.HeaderText = "比赛号";
            this.idmatchDataGridViewTextBoxColumn.Name = "idmatchDataGridViewTextBoxColumn";
            this.idmatchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "比赛名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "年龄组";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "性别";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RankColumn
            // 
            this.RankColumn.HeaderText = "名次";
            this.RankColumn.Name = "RankColumn";
            this.RankColumn.ReadOnly = true;
            // 
            // PlayerIDColumn
            // 
            this.PlayerIDColumn.HeaderText = "选手编号";
            this.PlayerIDColumn.Name = "PlayerIDColumn";
            this.PlayerIDColumn.ReadOnly = true;
            // 
            // GradeColumn
            // 
            this.GradeColumn.HeaderText = "分数";
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.ReadOnly = true;
            // 
            // MatchGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rankDataGridView);
            this.Controls.Add(this.matchDataGridView);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MatchGradeForm";
            this.Text = "查询比赛成绩";
            this.Activated += new System.EventHandler(this.MatchGradeForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.matchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matchDataGridView;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.DataGridView rankDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button okButton;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
    }
}