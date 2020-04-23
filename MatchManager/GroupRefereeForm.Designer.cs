namespace MatchManager
{
    partial class GroupRefereeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.grouperDataGridView = new System.Windows.Forms.DataGridView();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.refereeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grouperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idgroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrefereeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeBindingSource)).BeginInit();
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
            this.groupDataGridView.Location = new System.Drawing.Point(12, 12);
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
            this.idgroupDataGridViewTextBoxColumn1,
            this.idrefereeDataGridViewTextBoxColumn});
            this.grouperDataGridView.DataSource = this.grouperBindingSource;
            this.grouperDataGridView.Location = new System.Drawing.Point(12, 168);
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
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.playerDataGridView.DataSource = this.refereeBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(12, 370);
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
            this.removeButton.Location = new System.Drawing.Point(283, 324);
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
            this.addButton.Location = new System.Drawing.Point(127, 324);
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
            this.backButton.Location = new System.Drawing.Point(283, 526);
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
            this.okButton.Location = new System.Drawing.Point(197, 526);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 40);
            this.okButton.TabIndex = 12;
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
            // refereeBindingSource
            // 
            this.refereeBindingSource.DataSource = typeof(MatchManager.Referee);
            // 
            // grouperBindingSource
            // 
            this.grouperBindingSource.DataSource = typeof(MatchManager.RefereeGroup);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(MatchManager.Group);
            // 
            // idgroupDataGridViewTextBoxColumn1
            // 
            this.idgroupDataGridViewTextBoxColumn1.DataPropertyName = "idgroup";
            this.idgroupDataGridViewTextBoxColumn1.HeaderText = "组别号";
            this.idgroupDataGridViewTextBoxColumn1.Name = "idgroupDataGridViewTextBoxColumn1";
            this.idgroupDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idrefereeDataGridViewTextBoxColumn
            // 
            this.idrefereeDataGridViewTextBoxColumn.DataPropertyName = "idreferee";
            this.idrefereeDataGridViewTextBoxColumn.HeaderText = "裁判编号";
            this.idrefereeDataGridViewTextBoxColumn.Name = "idrefereeDataGridViewTextBoxColumn";
            this.idrefereeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "裁判编号";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "裁判姓名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idgroupDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "组别号";
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GroupRefereeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 579);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.playerDataGridView);
            this.Controls.Add(this.grouperDataGridView);
            this.Controls.Add(this.groupDataGridView);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GroupRefereeForm";
            this.Text = "分裁判";
            this.Activated += new System.EventHandler(this.GroupRefereeForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouperDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereeBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource grouperBindingSource;
        private System.Windows.Forms.BindingSource refereeBindingSource;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrefereeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}