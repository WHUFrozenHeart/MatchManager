namespace MatchManager
{
    partial class CheckChooseForm
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
            this.teamButton = new System.Windows.Forms.Button();
            this.individualButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // teamButton
            // 
            this.teamButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teamButton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamButton.Location = new System.Drawing.Point(44, 40);
            this.teamButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teamButton.Name = "teamButton";
            this.teamButton.Size = new System.Drawing.Size(175, 40);
            this.teamButton.TabIndex = 0;
            this.teamButton.Text = "团体";
            this.teamButton.UseVisualStyleBackColor = true;
            this.teamButton.Click += new System.EventHandler(this.TeamButton_Click);
            // 
            // individualButton
            // 
            this.individualButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.individualButton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualButton.Location = new System.Drawing.Point(44, 100);
            this.individualButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.individualButton.Name = "individualButton";
            this.individualButton.Size = new System.Drawing.Size(175, 40);
            this.individualButton.TabIndex = 1;
            this.individualButton.Text = "个人";
            this.individualButton.UseVisualStyleBackColor = true;
            this.individualButton.Click += new System.EventHandler(this.IndividualButton_Click);
            // 
            // matchButton
            // 
            this.matchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matchButton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchButton.Location = new System.Drawing.Point(44, 160);
            this.matchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(175, 40);
            this.matchButton.TabIndex = 2;
            this.matchButton.Text = "比赛";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.Font = new System.Drawing.Font("微软雅黑 Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(89, 220);
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
            // CheckChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 300);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.individualButton);
            this.Controls.Add(this.teamButton);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CheckChooseForm";
            this.Text = "选择查询成绩的项目";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teamButton;
        private System.Windows.Forms.Button individualButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button backButton;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}