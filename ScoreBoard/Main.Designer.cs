namespace ScoreBoard
{
    partial class Main
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOneName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOneNum = new System.Windows.Forms.TextBox();
            this.txtTwoName = new System.Windows.Forms.TextBox();
            this.txtTwoNum = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOneScoreUp = new System.Windows.Forms.Button();
            this.btnOneScoreDown = new System.Windows.Forms.Button();
            this.btnTwoScoreUp = new System.Windows.Forms.Button();
            this.btnTwoScoreDown = new System.Windows.Forms.Button();
            this.menuInfo = new System.Windows.Forms.MenuStrip();
            this.tmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmInfoUse = new System.Windows.Forms.ToolStripMenuItem();
            this.tmInfoHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(377, 234);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "출력";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "1P 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "2P 이름";
            // 
            // txtOneName
            // 
            this.txtOneName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOneName.Location = new System.Drawing.Point(24, 145);
            this.txtOneName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOneName.Name = "txtOneName";
            this.txtOneName.Size = new System.Drawing.Size(170, 33);
            this.txtOneName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(199, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "1P 점수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(199, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "2P 점수";
            // 
            // txtOneNum
            // 
            this.txtOneNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOneNum.Location = new System.Drawing.Point(202, 145);
            this.txtOneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtOneNum.Name = "txtOneNum";
            this.txtOneNum.Size = new System.Drawing.Size(109, 33);
            this.txtOneNum.TabIndex = 2;
            this.txtOneNum.Text = "0";
            // 
            // txtTwoName
            // 
            this.txtTwoName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTwoName.Location = new System.Drawing.Point(24, 226);
            this.txtTwoName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTwoName.Name = "txtTwoName";
            this.txtTwoName.Size = new System.Drawing.Size(170, 33);
            this.txtTwoName.TabIndex = 3;
            // 
            // txtTwoNum
            // 
            this.txtTwoNum.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTwoNum.Location = new System.Drawing.Point(202, 226);
            this.txtTwoNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtTwoNum.Name = "txtTwoNum";
            this.txtTwoNum.Size = new System.Drawing.Size(109, 33);
            this.txtTwoNum.TabIndex = 4;
            this.txtTwoNum.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(377, 129);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 45);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "텍스트 리셋\r\n(출력아님)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSwitch.Location = new System.Drawing.Point(377, 181);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(126, 45);
            this.btnSwitch.TabIndex = 10;
            this.btnSwitch.Text = "자리바꾸기";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // txtMain
            // 
            this.txtMain.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMain.Location = new System.Drawing.Point(24, 69);
            this.txtMain.Margin = new System.Windows.Forms.Padding(2);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(479, 33);
            this.txtMain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(190, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "메인 타이틀";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(127, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Copyright 2020. 삐라츄. All rights reserved";
            // 
            // btnOneScoreUp
            // 
            this.btnOneScoreUp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOneScoreUp.Location = new System.Drawing.Point(328, 129);
            this.btnOneScoreUp.Name = "btnOneScoreUp";
            this.btnOneScoreUp.Size = new System.Drawing.Size(34, 32);
            this.btnOneScoreUp.TabIndex = 13;
            this.btnOneScoreUp.Text = "▲";
            this.btnOneScoreUp.UseVisualStyleBackColor = true;
            this.btnOneScoreUp.Click += new System.EventHandler(this.btnOneScoreUp_Click);
            // 
            // btnOneScoreDown
            // 
            this.btnOneScoreDown.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOneScoreDown.Location = new System.Drawing.Point(328, 158);
            this.btnOneScoreDown.Name = "btnOneScoreDown";
            this.btnOneScoreDown.Size = new System.Drawing.Size(34, 32);
            this.btnOneScoreDown.TabIndex = 14;
            this.btnOneScoreDown.Text = "▼";
            this.btnOneScoreDown.UseVisualStyleBackColor = true;
            this.btnOneScoreDown.Click += new System.EventHandler(this.btnOneScoreDown_Click);
            // 
            // btnTwoScoreUp
            // 
            this.btnTwoScoreUp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwoScoreUp.Location = new System.Drawing.Point(328, 212);
            this.btnTwoScoreUp.Name = "btnTwoScoreUp";
            this.btnTwoScoreUp.Size = new System.Drawing.Size(34, 32);
            this.btnTwoScoreUp.TabIndex = 13;
            this.btnTwoScoreUp.Text = "▲";
            this.btnTwoScoreUp.UseVisualStyleBackColor = true;
            this.btnTwoScoreUp.Click += new System.EventHandler(this.btnTwoScoreUp_Click);
            // 
            // btnTwoScoreDown
            // 
            this.btnTwoScoreDown.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwoScoreDown.Location = new System.Drawing.Point(328, 242);
            this.btnTwoScoreDown.Name = "btnTwoScoreDown";
            this.btnTwoScoreDown.Size = new System.Drawing.Size(34, 32);
            this.btnTwoScoreDown.TabIndex = 14;
            this.btnTwoScoreDown.Text = "▼";
            this.btnTwoScoreDown.UseVisualStyleBackColor = true;
            this.btnTwoScoreDown.Click += new System.EventHandler(this.btnTwoScoreDown_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmInfo});
            this.menuInfo.Location = new System.Drawing.Point(0, 0);
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(529, 24);
            this.menuInfo.TabIndex = 15;
            this.menuInfo.Text = "정보";
            // 
            // tmInfo
            // 
            this.tmInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmInfoUse,
            this.tmInfoHotkey});
            this.tmInfo.Name = "tmInfo";
            this.tmInfo.Size = new System.Drawing.Size(43, 20);
            this.tmInfo.Text = "정보";
            // 
            // tmInfoUse
            // 
            this.tmInfoUse.Name = "tmInfoUse";
            this.tmInfoUse.Size = new System.Drawing.Size(180, 22);
            this.tmInfoUse.Text = "사용법";
            this.tmInfoUse.Click += new System.EventHandler(this.tmInfoUse_Click);
            // 
            // tmInfoHotkey
            // 
            this.tmInfoHotkey.Name = "tmInfoHotkey";
            this.tmInfoHotkey.Size = new System.Drawing.Size(180, 22);
            this.tmInfoHotkey.Text = "단축키정보";
            this.tmInfoHotkey.Click += new System.EventHandler(this.tmInfoHotkey_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 319);
            this.Controls.Add(this.btnTwoScoreDown);
            this.Controls.Add(this.btnTwoScoreUp);
            this.Controls.Add(this.btnOneScoreDown);
            this.Controls.Add(this.btnOneScoreUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTwoNum);
            this.Controls.Add(this.txtTwoName);
            this.Controls.Add(this.txtOneNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOneName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.menuInfo);
            this.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuInfo;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "스코어보드프로그램 v2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Closed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuInfo.ResumeLayout(false);
            this.menuInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOneName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOneNum;
        private System.Windows.Forms.TextBox txtTwoName;
        private System.Windows.Forms.TextBox txtTwoNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOneScoreUp;
        private System.Windows.Forms.Button btnOneScoreDown;
        private System.Windows.Forms.Button btnTwoScoreUp;
        private System.Windows.Forms.Button btnTwoScoreDown;
        private System.Windows.Forms.MenuStrip menuInfo;
        private System.Windows.Forms.ToolStripMenuItem tmInfo;
        private System.Windows.Forms.ToolStripMenuItem tmInfoUse;
        private System.Windows.Forms.ToolStripMenuItem tmInfoHotkey;
    }
}