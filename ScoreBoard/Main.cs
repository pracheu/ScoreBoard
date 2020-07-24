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
    public partial class Main : Form
    {
        ScoreBoardLive newScore;
        public Main()
        {
            InitializeComponent();
        }

        private void ShowScore()
        {
            bool fO = false;
            foreach(Form frm in Application.OpenForms)
            {
                if(frm.Name == "ScoreBoardLive")
                {
                    fO = true;
                }
            }
            if (!fO)
            {
                newScore = new ScoreBoardLive();
                newScore.Show();
                newScore.getScore(txtOneName.Text, txtTwoName.Text, txtOneNum.Text, txtTwoNum.Text, txtMain.Text);
            }
            else
            {
                newScore.getScore(txtOneName.Text, txtTwoName.Text, txtOneNum.Text, txtTwoNum.Text, txtMain.Text);
            }
        }

        private void SwitchScore()
        {
            string tempOneName;
            string tempTwoName;
            string tempOneNum;
            string tempTwoNum;

            tempOneName = txtOneName.Text;
            tempTwoName = txtTwoName.Text;
            tempOneNum = txtOneNum.Text;
            tempTwoNum = txtTwoNum.Text;

            txtOneName.Text = tempTwoName;
            txtTwoName.Text = tempOneName;
            txtTwoNum.Text = tempOneNum;
            txtOneNum.Text = tempTwoNum;

            newScore.getScore(txtOneName.Text, txtTwoName.Text, txtOneNum.Text, txtTwoNum.Text, txtMain.Text);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkTextBlank()) {
                ShowScore();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (checkTextBlank())
            {
                bool fO = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "ScoreBoardLive")
                    {
                        fO = true;
                    }
                }
                if (!fO)
                {
                    newScore = new ScoreBoardLive();
                    newScore.Show();
                    newScore.getScore(txtOneName.Text, txtTwoName.Text, txtOneNum.Text, txtTwoNum.Text, txtMain.Text);
                    SwitchScore();
                }
                else
                {
                    SwitchScore();
                }
            }
        }

        private bool checkTextBlank()
        {
            bool result = true;
            if (txtOneName.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("1P의 이름이 입력되지 않았습니다.");
                result = false;
            }
            else if (txtTwoName.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("2P의 이름이 입력되지 않았습니다.");
                result = false;
            }
            else if (txtOneNum.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("1P의 점수가 입력되지 않았습니다.");
                result = false;
            }
            else if (txtTwoNum.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("2P의 점수가 입력되지 않았습니다.");
                result = false;
            }
            else if (txtMain.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("메인타이틀이 입력되지 않았습니다.");
                result = false;
            }
            return result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMain.Text = "";
            txtOneName.Text = "";
            txtTwoName.Text = "";
            txtOneNum.Text = "";
            txtTwoNum.Text = "";
        }
    }
}
