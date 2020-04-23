namespace MatchManager
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.teamName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leaderButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.coachButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.detailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎！";
            // 
            // teamName
            // 
            this.teamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teamName.Location = new System.Drawing.Point(114, 7);
            this.teamName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(132, 27);
            this.teamName.TabIndex = 1;
            this.teamName.Text = "（队伍名称）";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "点击下方按钮进行操作";
            // 
            // leaderButton
            // 
            this.leaderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leaderButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leaderButton.Location = new System.Drawing.Point(59, 110);
            this.leaderButton.Margin = new System.Windows.Forms.Padding(2);
            this.leaderButton.Name = "leaderButton";
            this.leaderButton.Size = new System.Drawing.Size(175, 40);
            this.leaderButton.TabIndex = 3;
            this.leaderButton.Text = "添加领队与队医";
            this.leaderButton.UseVisualStyleBackColor = true;
            this.leaderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerButton
            // 
            this.playerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playerButton.Location = new System.Drawing.Point(59, 170);
            this.playerButton.Margin = new System.Windows.Forms.Padding(2);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(175, 40);
            this.playerButton.TabIndex = 4;
            this.playerButton.Text = "添加运动员";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // coachButton
            // 
            this.coachButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coachButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coachButton.Location = new System.Drawing.Point(59, 230);
            this.coachButton.Margin = new System.Windows.Forms.Padding(2);
            this.coachButton.Name = "coachButton";
            this.coachButton.Size = new System.Drawing.Size(175, 40);
            this.coachButton.TabIndex = 5;
            this.coachButton.Text = "添加教练员";
            this.coachButton.UseVisualStyleBackColor = true;
            this.coachButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(110, 470);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 40);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(59, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加裁判员";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(59, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "上传附件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
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
            // detailButton
            // 
            this.detailButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailButton.Location = new System.Drawing.Point(59, 410);
            this.detailButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(175, 40);
            this.detailButton.TabIndex = 9;
            this.detailButton.Text = "查询";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.DetailButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 545);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.coachButton);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.leaderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "代表队";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button leaderButton;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.Button coachButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button detailButton;
    }
}