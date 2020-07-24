using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoard
{
    public partial class ScoreBoardLive : Form
    {
        private string Player1_name;
        public string Passvalue
        {
            get { return this.Player1_name; }
            set { this.Player1_name = value;  }
        }

        public ScoreBoardLive()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            pbScore.Image = Properties.Resources.score4;
            lblOneScore.BackColor = Color.Transparent;
            lblOneScore.Parent = pbScore;
            lblOneScore.Location = new Point(42, 12);
            lblOneScore.Text = "";
            lblOneScore.Size = new Size(78, 48);
            lblOneScore.AutoSize = false;

            lblTwoScore.BackColor = Color.Transparent;
            lblTwoScore.Parent = pbScore;
            lblTwoScore.Location = new Point(1039, 12);
            lblTwoScore.Text = "";
            lblTwoScore.Size = new Size(78, 48);
            lblTwoScore.AutoSize = false;

            lblOneName.BackColor = Color.Transparent;
            lblOneName.Parent = pbScore;
            lblOneName.Location = new Point(145, 12);
            lblOneName.Size = new Size(264, 48);
            lblOneName.Text = "";
            lblOneName.AutoSize = false;

            lblTwoName.BackColor = Color.Transparent;
            lblTwoName.Parent = pbScore;
            lblTwoName.Location = new Point(746, 12);
            lblTwoName.Size = new Size(264, 48);
            lblTwoName.Text = "";
            lblTwoName.AutoSize = false;

            lblMain.BackColor = Color.Transparent;
            lblMain.Parent = pbScore;
            lblMain.Location = new Point(450, 6);
            lblMain.Size = new Size(264, 48);
            lblMain.AutoSize = false;

        }

        public void getScore(string PlayerOneName, string PlayerTwoName, string PlayerOneNum, string PlayerTowNum, string MainText)
        {
            lblOneScore.Text = PlayerOneNum.Trim();
            lblTwoScore.Text = PlayerTowNum.Trim();
            lblOneName.Text = PlayerOneName.Trim();
            lblTwoName.Text = PlayerTwoName.Trim();
            lblMain.Text = MainText.Trim();

            lblOneName.Font = AutoFontSize(lblOneName, lblOneName.Text);
            lblTwoName.Font = AutoFontSize(lblTwoName, lblTwoName.Text);
            lblMain.Font = AutoFontSize(lblMain, lblMain.Text);
        }

        public Font AutoFontSize(Label label, string Text)
        {
            Font ft;
            Graphics gp;
            SizeF sz;
            Single Faktor, FaktorX, FaktorY;
            gp = label.CreateGraphics();
            sz = gp.MeasureString(Text, label.Font);
            gp.Dispose();

            FaktorX = (label.Width) / sz.Width;
            FaktorY = (label.Height) / sz.Height;

            if(FaktorX > FaktorY)
            {
                Faktor = FaktorY;
            }
            else
            {
                Faktor = FaktorX;
            }
            ft = label.Font;
            
            return new Font(ft.Name, ft.SizeInPoints * (Faktor) - 1);
        }
    }
}
