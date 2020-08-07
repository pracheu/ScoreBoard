namespace ScoreBoard
{
    partial class ScoreBoardLive
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbScore = new System.Windows.Forms.PictureBox();
            this.lblOneScore = new System.Windows.Forms.Label();
            this.lblTwoScore = new System.Windows.Forms.Label();
            this.lblOneName = new System.Windows.Forms.Label();
            this.lblTwoName = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScore
            // 
            this.pbScore.Image = global::ScoreBoard.Properties.Resources.score4;
            this.pbScore.Location = new System.Drawing.Point(12, 35);
            this.pbScore.Name = "pbScore";
            this.pbScore.Size = new System.Drawing.Size(1160, 77);
            this.pbScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScore.TabIndex = 2;
            this.pbScore.TabStop = false;
            // 
            // lblOneScore
            // 
            this.lblOneScore.BackColor = System.Drawing.Color.Black;
            this.lblOneScore.Font = new System.Drawing.Font("한컴 백제 M", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOneScore.ForeColor = System.Drawing.Color.White;
            this.lblOneScore.Location = new System.Drawing.Point(56, 52);
            this.lblOneScore.Name = "lblOneScore";
            this.lblOneScore.Size = new System.Drawing.Size(78, 48);
            this.lblOneScore.TabIndex = 3;
            this.lblOneScore.Text = "0";
            this.lblOneScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoScore
            // 
            this.lblTwoScore.BackColor = System.Drawing.Color.Black;
            this.lblTwoScore.Font = new System.Drawing.Font("한컴 백제 M", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTwoScore.ForeColor = System.Drawing.Color.White;
            this.lblTwoScore.Location = new System.Drawing.Point(1053, 52);
            this.lblTwoScore.Name = "lblTwoScore";
            this.lblTwoScore.Size = new System.Drawing.Size(78, 48);
            this.lblTwoScore.TabIndex = 4;
            this.lblTwoScore.Text = "0";
            this.lblTwoScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneName
            // 
            this.lblOneName.BackColor = System.Drawing.Color.Black;
            this.lblOneName.Font = new System.Drawing.Font("한컴 백제 M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOneName.ForeColor = System.Drawing.Color.White;
            this.lblOneName.Location = new System.Drawing.Point(159, 52);
            this.lblOneName.Name = "lblOneName";
            this.lblOneName.Size = new System.Drawing.Size(264, 48);
            this.lblOneName.TabIndex = 5;
            this.lblOneName.Text = "0";
            this.lblOneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoName
            // 
            this.lblTwoName.BackColor = System.Drawing.Color.Black;
            this.lblTwoName.Font = new System.Drawing.Font("한컴 백제 M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTwoName.ForeColor = System.Drawing.Color.White;
            this.lblTwoName.Location = new System.Drawing.Point(760, 52);
            this.lblTwoName.Name = "lblTwoName";
            this.lblTwoName.Size = new System.Drawing.Size(264, 48);
            this.lblTwoName.TabIndex = 6;
            this.lblTwoName.Text = "0";
            this.lblTwoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Black;
            this.lblMain.Font = new System.Drawing.Font("한컴 백제 M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(479, 52);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(226, 36);
            this.lblMain.TabIndex = 7;
            this.lblMain.Text = "0";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreBoardLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1189, 156);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblTwoName);
            this.Controls.Add(this.lblOneName);
            this.Controls.Add(this.lblTwoScore);
            this.Controls.Add(this.lblOneScore);
            this.Controls.Add(this.pbScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ScoreBoardLive";
            this.Text = "ScoreBoardLive";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            this.DoubleClick += new System.EventHandler(this.Function_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Function_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Function_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbScore;
        private System.Windows.Forms.Label lblOneScore;
        private System.Windows.Forms.Label lblTwoScore;
        private System.Windows.Forms.Label lblOneName;
        private System.Windows.Forms.Label lblTwoName;
        private System.Windows.Forms.Label lblMain;
    }
}

