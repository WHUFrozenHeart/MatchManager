namespace MatchManager
{
    partial class AddPlayerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.groupCombox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.malePanel = new System.Windows.Forms.Panel();
            this.maleRing = new System.Windows.Forms.CheckBox();
            this.malePommelHorse = new System.Windows.Forms.CheckBox();
            this.maleTrampoline = new System.Windows.Forms.CheckBox();
            this.maleVault = new System.Windows.Forms.CheckBox();
            this.maleFloorExercise = new System.Windows.Forms.CheckBox();
            this.maleParallelBars = new System.Windows.Forms.CheckBox();
            this.maleHorizontalBar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.femalePanel = new System.Windows.Forms.Panel();
            this.femaleUnevenBars = new System.Windows.Forms.CheckBox();
            this.femaleTrampoline = new System.Windows.Forms.CheckBox();
            this.femaleVault = new System.Windows.Forms.CheckBox();
            this.femaleFloorExercise = new System.Windows.Forms.CheckBox();
            this.femaleBalanceBeam = new System.Windows.Forms.CheckBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.malePanel.SuspendLayout();
            this.femalePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(106, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(86, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份证";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(106, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "组别";
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameField.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(182, 84);
            this.nameField.Margin = new System.Windows.Forms.Padding(2);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(170, 22);
            this.nameField.TabIndex = 5;
            // 
            // idField
            // 
            this.idField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idField.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idField.Location = new System.Drawing.Point(182, 184);
            this.idField.Margin = new System.Windows.Forms.Padding(2);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(170, 22);
            this.idField.TabIndex = 6;
            this.idField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdField_KeyPress);
            // 
            // groupCombox
            // 
            this.groupCombox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCombox.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupCombox.FormattingEnabled = true;
            this.groupCombox.Items.AddRange(new object[] {
            "7-8岁",
            "9-10岁",
            "11-12岁"});
            this.groupCombox.Location = new System.Drawing.Point(182, 231);
            this.groupCombox.Margin = new System.Windows.Forms.Padding(2);
            this.groupCombox.Name = "groupCombox";
            this.groupCombox.Size = new System.Drawing.Size(170, 24);
            this.groupCombox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(106, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "性别";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleRadioButton.Location = new System.Drawing.Point(182, 135);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(37, 20);
            this.maleRadioButton.TabIndex = 10;
            this.maleRadioButton.Text = "男";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleRadioButton.Location = new System.Drawing.Point(223, 135);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(37, 20);
            this.femaleRadioButton.TabIndex = 11;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "女";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.Location = new System.Drawing.Point(50, 488);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 40);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "提交";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearButton.Location = new System.Drawing.Point(200, 488);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 40);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "清空";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(350, 488);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 40);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(101, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "请确认性别后再报名比赛项目！";
            // 
            // malePanel
            // 
            this.malePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.malePanel.Controls.Add(this.maleRing);
            this.malePanel.Controls.Add(this.malePommelHorse);
            this.malePanel.Controls.Add(this.maleTrampoline);
            this.malePanel.Controls.Add(this.maleVault);
            this.malePanel.Controls.Add(this.maleFloorExercise);
            this.malePanel.Controls.Add(this.maleParallelBars);
            this.malePanel.Controls.Add(this.maleHorizontalBar);
            this.malePanel.Location = new System.Drawing.Point(50, 320);
            this.malePanel.Margin = new System.Windows.Forms.Padding(2);
            this.malePanel.Name = "malePanel";
            this.malePanel.Size = new System.Drawing.Size(415, 138);
            this.malePanel.TabIndex = 17;
            this.malePanel.Visible = false;
            // 
            // maleRing
            // 
            this.maleRing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleRing.AutoSize = true;
            this.maleRing.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleRing.Location = new System.Drawing.Point(279, 15);
            this.maleRing.Margin = new System.Windows.Forms.Padding(2);
            this.maleRing.Name = "maleRing";
            this.maleRing.Size = new System.Drawing.Size(49, 20);
            this.maleRing.TabIndex = 20;
            this.maleRing.Text = "吊环";
            this.maleRing.UseVisualStyleBackColor = true;
            // 
            // malePommelHorse
            // 
            this.malePommelHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.malePommelHorse.AutoSize = true;
            this.malePommelHorse.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.malePommelHorse.Location = new System.Drawing.Point(279, 62);
            this.malePommelHorse.Margin = new System.Windows.Forms.Padding(2);
            this.malePommelHorse.Name = "malePommelHorse";
            this.malePommelHorse.Size = new System.Drawing.Size(49, 20);
            this.malePommelHorse.TabIndex = 19;
            this.malePommelHorse.Text = "鞍马";
            this.malePommelHorse.UseVisualStyleBackColor = true;
            // 
            // maleTrampoline
            // 
            this.maleTrampoline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleTrampoline.AutoSize = true;
            this.maleTrampoline.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleTrampoline.Location = new System.Drawing.Point(172, 15);
            this.maleTrampoline.Margin = new System.Windows.Forms.Padding(2);
            this.maleTrampoline.Name = "maleTrampoline";
            this.maleTrampoline.Size = new System.Drawing.Size(49, 20);
            this.maleTrampoline.TabIndex = 18;
            this.maleTrampoline.Text = "蹦床";
            this.maleTrampoline.UseVisualStyleBackColor = true;
            // 
            // maleVault
            // 
            this.maleVault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleVault.AutoSize = true;
            this.maleVault.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleVault.Location = new System.Drawing.Point(56, 62);
            this.maleVault.Margin = new System.Windows.Forms.Padding(2);
            this.maleVault.Name = "maleVault";
            this.maleVault.Size = new System.Drawing.Size(49, 20);
            this.maleVault.TabIndex = 17;
            this.maleVault.Text = "跳马";
            this.maleVault.UseVisualStyleBackColor = true;
            // 
            // maleFloorExercise
            // 
            this.maleFloorExercise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleFloorExercise.AutoSize = true;
            this.maleFloorExercise.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleFloorExercise.Location = new System.Drawing.Point(56, 107);
            this.maleFloorExercise.Margin = new System.Windows.Forms.Padding(2);
            this.maleFloorExercise.Name = "maleFloorExercise";
            this.maleFloorExercise.Size = new System.Drawing.Size(71, 20);
            this.maleFloorExercise.TabIndex = 16;
            this.maleFloorExercise.Text = "自由体操";
            this.maleFloorExercise.UseVisualStyleBackColor = true;
            // 
            // maleParallelBars
            // 
            this.maleParallelBars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleParallelBars.AutoSize = true;
            this.maleParallelBars.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleParallelBars.Location = new System.Drawing.Point(172, 62);
            this.maleParallelBars.Margin = new System.Windows.Forms.Padding(2);
            this.maleParallelBars.Name = "maleParallelBars";
            this.maleParallelBars.Size = new System.Drawing.Size(49, 20);
            this.maleParallelBars.TabIndex = 15;
            this.maleParallelBars.Text = "双杠";
            this.maleParallelBars.UseVisualStyleBackColor = true;
            // 
            // maleHorizontalBar
            // 
            this.maleHorizontalBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleHorizontalBar.AutoSize = true;
            this.maleHorizontalBar.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maleHorizontalBar.Location = new System.Drawing.Point(56, 15);
            this.maleHorizontalBar.Margin = new System.Windows.Forms.Padding(2);
            this.maleHorizontalBar.Name = "maleHorizontalBar";
            this.maleHorizontalBar.Size = new System.Drawing.Size(49, 20);
            this.maleHorizontalBar.TabIndex = 14;
            this.maleHorizontalBar.Text = "单杠";
            this.maleHorizontalBar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "参赛项目选择";
            // 
            // femalePanel
            // 
            this.femalePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femalePanel.Controls.Add(this.femaleUnevenBars);
            this.femalePanel.Controls.Add(this.femaleTrampoline);
            this.femalePanel.Controls.Add(this.femaleVault);
            this.femalePanel.Controls.Add(this.femaleFloorExercise);
            this.femalePanel.Controls.Add(this.femaleBalanceBeam);
            this.femalePanel.Location = new System.Drawing.Point(50, 320);
            this.femalePanel.Margin = new System.Windows.Forms.Padding(2);
            this.femalePanel.Name = "femalePanel";
            this.femalePanel.Size = new System.Drawing.Size(416, 138);
            this.femalePanel.TabIndex = 18;
            this.femalePanel.Visible = false;
            // 
            // femaleUnevenBars
            // 
            this.femaleUnevenBars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleUnevenBars.AutoSize = true;
            this.femaleUnevenBars.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleUnevenBars.Location = new System.Drawing.Point(173, 38);
            this.femaleUnevenBars.Margin = new System.Windows.Forms.Padding(2);
            this.femaleUnevenBars.Name = "femaleUnevenBars";
            this.femaleUnevenBars.Size = new System.Drawing.Size(60, 20);
            this.femaleUnevenBars.TabIndex = 27;
            this.femaleUnevenBars.Text = "高低杠";
            this.femaleUnevenBars.UseVisualStyleBackColor = true;
            // 
            // femaleTrampoline
            // 
            this.femaleTrampoline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleTrampoline.AutoSize = true;
            this.femaleTrampoline.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleTrampoline.Location = new System.Drawing.Point(57, 38);
            this.femaleTrampoline.Margin = new System.Windows.Forms.Padding(2);
            this.femaleTrampoline.Name = "femaleTrampoline";
            this.femaleTrampoline.Size = new System.Drawing.Size(49, 20);
            this.femaleTrampoline.TabIndex = 26;
            this.femaleTrampoline.Text = "蹦床";
            this.femaleTrampoline.UseVisualStyleBackColor = true;
            // 
            // femaleVault
            // 
            this.femaleVault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleVault.AutoSize = true;
            this.femaleVault.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleVault.Location = new System.Drawing.Point(280, 38);
            this.femaleVault.Margin = new System.Windows.Forms.Padding(2);
            this.femaleVault.Name = "femaleVault";
            this.femaleVault.Size = new System.Drawing.Size(49, 20);
            this.femaleVault.TabIndex = 25;
            this.femaleVault.Text = "跳马";
            this.femaleVault.UseVisualStyleBackColor = true;
            // 
            // femaleFloorExercise
            // 
            this.femaleFloorExercise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleFloorExercise.AutoSize = true;
            this.femaleFloorExercise.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleFloorExercise.Location = new System.Drawing.Point(57, 86);
            this.femaleFloorExercise.Margin = new System.Windows.Forms.Padding(2);
            this.femaleFloorExercise.Name = "femaleFloorExercise";
            this.femaleFloorExercise.Size = new System.Drawing.Size(71, 20);
            this.femaleFloorExercise.TabIndex = 24;
            this.femaleFloorExercise.Text = "自由体操";
            this.femaleFloorExercise.UseVisualStyleBackColor = true;
            // 
            // femaleBalanceBeam
            // 
            this.femaleBalanceBeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femaleBalanceBeam.AutoSize = true;
            this.femaleBalanceBeam.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.femaleBalanceBeam.Location = new System.Drawing.Point(173, 86);
            this.femaleBalanceBeam.Margin = new System.Windows.Forms.Padding(2);
            this.femaleBalanceBeam.Name = "femaleBalanceBeam";
            this.femaleBalanceBeam.Size = new System.Drawing.Size(60, 20);
            this.femaleBalanceBeam.TabIndex = 23;
            this.femaleBalanceBeam.Text = "平衡木";
            this.femaleBalanceBeam.UseVisualStyleBackColor = true;
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
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 563);
            this.Controls.Add(this.femalePanel);
            this.Controls.Add(this.malePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupCombox);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddPlayerForm";
            this.Text = "添加运动员信息";
            this.malePanel.ResumeLayout(false);
            this.malePanel.PerformLayout();
            this.femalePanel.ResumeLayout(false);
            this.femalePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.ComboBox groupCombox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel malePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox maleRing;
        private System.Windows.Forms.CheckBox malePommelHorse;
        private System.Windows.Forms.CheckBox maleTrampoline;
        private System.Windows.Forms.CheckBox maleVault;
        private System.Windows.Forms.CheckBox maleFloorExercise;
        private System.Windows.Forms.CheckBox maleParallelBars;
        private System.Windows.Forms.CheckBox maleHorizontalBar;
        private System.Windows.Forms.Panel femalePanel;
        private System.Windows.Forms.CheckBox femaleUnevenBars;
        private System.Windows.Forms.CheckBox femaleTrampoline;
        private System.Windows.Forms.CheckBox femaleVault;
        private System.Windows.Forms.CheckBox femaleFloorExercise;
        private System.Windows.Forms.CheckBox femaleBalanceBeam;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}