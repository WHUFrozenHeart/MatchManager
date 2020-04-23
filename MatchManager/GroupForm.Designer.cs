namespace MatchManager
{
    partial class GroupForm
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
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.grouperDataGridView = new System.Windows.Forms.DataGridView();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grouperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idmatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idplayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AllowUserToDeleteRows = false;
            this.groupDataGridView.AllowUserToResizeColumns = false;
            this.groupDataGridView.AllowUserToResizeRows = false;
            this.groupDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupDataGridView.AutoGenerateColumns = false;
            this.groupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmatchDataGridViewTextBoxColumn,
            this.idgroupDataGridViewTextBoxColumn});
            this.groupDataGridView.DataSource = this.groupBindingSource;
            this.groupDataGridView.Location = new System.Drawing.Point(12, 23);
            this.groupDataGridView.MultiSelect = false;
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.RowHeadersVisible = false;
            this.groupDataGridView.RowTemplate.Height = 23;
            this.groupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupDataGridView.Size = new System.Drawing.Size(560, 150);
            this.groupDataGridView.TabIndex = 0;
            this.groupDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GroupDataGridView_MouseClick);
            // 
            // grouperDataGridView
            // 
            this.grouperDataGridView.AllowUserToAddRows = false;
            this.grouperDataGridView.AllowUserToDeleteRows = false;
            this.grouperDataGridView.AllowUserToResizeColumns = false;
            this.grouperDataGridView.AllowUserToResizeRows = false;
            this.grouperDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grouperDataGridView.AutoGenerateColumns = false;
            this.grouperDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grouperDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grouperDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplayer,
            this.gradeDataGridViewTextBoxColumn});
            this.grouperDataGridView.DataSource = this.grouperBindingSource;
            this.grouperDataGridView.Location = new System.Drawing.Point(12, 225);
            this.grouperDataGridView.MultiSelect = false;
            this.grouperDataGridView.Name = "grouperDataGridView";
            this.grouperDataGridView.ReadOnly = true;
            this.grouperDataGridView.RowHeadersVisible = false;
            this.grouperDataGridView.RowTemplate.Height = 23;
            this.grouperDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grouperDataGridView.Size = new System.Drawing.Size(560, 150);
            this.grouperDataGridView.TabIndex = 1;
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.AllowUserToAddRows = false;
            this.playerDataGridView.AllowUserToDeleteRows = false;
            this.playerDataGridView.AllowUserToResizeColumns = false;
            this.playerDataGridView.AllowUserToResizeRows = false;
            this.playerDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.gradeDataGridViewTextBoxColumn1});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(12, 427);
            this.playerDataGridView.MultiSelect = false;
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.ReadOnly = true;
            this.playerDataGridView.RowHeadersVisible = false;
            this.playerDataGridView.RowTemplate.Height = 23;
            this.playerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playerDataGridView.Size = new System.Drawing.Size(560, 150);
            this.playerDataGridView.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeButton.Location = new System.Drawing.Point(292, 381);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(140, 40);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "删除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addButton.Location = new System.Drawing.Point(137, 381);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(292, 583);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 40);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.okButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.okButton.Location = new System.Drawing.Point(207, 583);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 40);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createButton.Location = new System.Drawing.Point(207, 179);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(140, 40);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "创建小组";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
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
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(MatchManager.PlayerMatch);
            // 
            // grouperBindingSource
            // 
            this.grouperBindingSource.DataSource = typeof(MatchManager.PlayerMatch);
            // 
            // idmatchDataGridViewTextBoxColumn
            // 
            this.idmatchDataGridViewTextBoxColumn.DataPropertyName = "idmatch";
            this.idmatchDataGridViewTextBoxColumn.HeaderText = "比赛号";
            this.idmatchDataGridViewTextBoxColumn.Name = "idmatchDataGridViewTextBoxColumn";
            this.idmatchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idgroupDataGridViewTextBoxColumn
            // 
            this.idgroupDataGridViewTextBoxColumn.DataPropertyName = "idgroup";
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "组别号";
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(MatchManager.Group);
            // 
            // idplayer
            // 
            this.idplayer.DataPropertyName = "idplayer";
            this.idplayer.HeaderText = "选手编号";
            this.idplayer.Name = "idplayer";
            this.idplayer.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "成绩";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idplayer";
            this.dataGridViewTextBoxColumn1.HeaderText = "选手编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn1
            // 
            this.gradeDataGridViewTextBoxColumn1.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn1.HeaderText = "成绩";
            this.gradeDataGridViewTextBoxColumn1.Name = "gradeDataGridViewTextBoxColumn1";
            this.gradeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 637);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.playerDataGridView);
            this.Controls.Add(this.grouperDataGridView);
            this.Controls.Add(this.groupDataGridView);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GroupForm";
            this.Text = "分组";
            this.Activated += new System.EventHandler(this.GroupForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.DataGridView grouperDataGridView;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource grouperBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn1;
    }
}