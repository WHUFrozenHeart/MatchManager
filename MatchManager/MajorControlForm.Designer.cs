namespace MatchManager
{
    partial class MajorControlForm
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
            this.gradeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pulishField = new System.Windows.Forms.TextBox();
            this.rewardField = new System.Windows.Forms.TextBox();
            this.handButton = new System.Windows.Forms.Button();
            this.averageGradeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redoButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.nameCombox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(200, 200);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(0, 27);
            this.gradeLabel.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(320, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "惩罚分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(90, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "奖励分";
            // 
            // pulishField
            // 
            this.pulishField.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pulishField.Location = new System.Drawing.Point(425, 306);
            this.pulishField.Margin = new System.Windows.Forms.Padding(7);
            this.pulishField.MaxLength = 2;
            this.pulishField.Name = "pulishField";
            this.pulishField.Size = new System.Drawing.Size(85, 22);
            this.pulishField.TabIndex = 20;
            this.pulishField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PulishField_KeyPress);
            // 
            // rewardField
            // 
            this.rewardField.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rewardField.Location = new System.Drawing.Point(205, 306);
            this.rewardField.Margin = new System.Windows.Forms.Padding(7);
            this.rewardField.MaxLength = 2;
            this.rewardField.Name = "rewardField";
            this.rewardField.Size = new System.Drawing.Size(85, 22);
            this.rewardField.TabIndex = 19;
            this.rewardField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RewardField_KeyPress);
            // 
            // handButton
            // 
            this.handButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.handButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.handButton.Location = new System.Drawing.Point(548, 294);
            this.handButton.Margin = new System.Windows.Forms.Padding(7);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(70, 40);
            this.handButton.TabIndex = 18;
            this.handButton.Text = "提交";
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Click += new System.EventHandler(this.HandButton_Click);
            // 
            // averageGradeLabel
            // 
            this.averageGradeLabel.AutoSize = true;
            this.averageGradeLabel.Location = new System.Drawing.Point(360, 422);
            this.averageGradeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.averageGradeLabel.Name = "averageGradeLabel";
            this.averageGradeLabel.Size = new System.Drawing.Size(0, 27);
            this.averageGradeLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "平均成绩";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "裁判姓名";
            // 
            // redoButton
            // 
            this.redoButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redoButton.Location = new System.Drawing.Point(548, 193);
            this.redoButton.Margin = new System.Windows.Forms.Padding(7);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(70, 40);
            this.redoButton.TabIndex = 14;
            this.redoButton.Text = "重打";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okButton.Location = new System.Drawing.Point(425, 193);
            this.okButton.Margin = new System.Windows.Forms.Padding(7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 40);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "通过";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // nameCombox
            // 
            this.nameCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameCombox.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameCombox.FormattingEnabled = true;
            this.nameCombox.Location = new System.Drawing.Point(205, 156);
            this.nameCombox.Margin = new System.Windows.Forms.Padding(7);
            this.nameCombox.Name = "nameCombox";
            this.nameCombox.Size = new System.Drawing.Size(170, 24);
            this.nameCombox.TabIndex = 12;
            this.nameCombox.TextChanged += new System.EventHandler(this.NameCombox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(200, 100);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 27);
            this.nameLabel.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(50, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "运动员姓名";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(200, 50);
            this.numLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(0, 27);
            this.numLabel.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(50, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "运动员编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(110, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "成绩";
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
            // MajorControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pulishField);
            this.Controls.Add(this.rewardField);
            this.Controls.Add(this.handButton);
            this.Controls.Add(this.averageGradeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameCombox);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "MajorControlForm";
            this.Text = "主裁打分";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pulishField;
        private System.Windows.Forms.TextBox rewardField;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Label averageGradeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox nameCombox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}