using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            txtOneNum.Text = "0";
            txtTwoNum.Text = "0";
        }

        private void btnOneScoreUp_Click(object sender, EventArgs e)
        {
            if (checkTextBlank())
            {
                int num = Int32.Parse(txtOneNum.Text);
                txtOneNum.Text = (num + 1).ToString();
                ShowScore();
            }
        }

        private void btnOneScoreDown_Click(object sender, EventArgs e)
        {
            if (checkTextBlank())
            {
                int num = Int32.Parse(txtOneNum.Text);
                if (num > 0)
                {
                    txtOneNum.Text = (num - 1).ToString();
                }
                ShowScore();
            }
        }

        private void btnTwoScoreUp_Click(object sender, EventArgs e)
        {
            if (checkTextBlank())
            {
                int num = Int32.Parse(txtTwoNum.Text);
                txtTwoNum.Text = (num + 1).ToString();
                ShowScore();
            }
        }

        private void btnTwoScoreDown_Click(object sender, EventArgs e)
        {
            if (checkTextBlank())
            {
                int num = Int32.Parse(txtTwoNum.Text);
                if(num > 0) { 
                    txtTwoNum.Text = (num - 1).ToString();
                }
                ShowScore();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, ONENUME_UP, KeyModifiers.Control, Keys.Up);
            RegisterHotKey(this.Handle, ONENUME_DOWN, KeyModifiers.Control, Keys.Down);
            RegisterHotKey(this.Handle, ONENUME_D1, KeyModifiers.Control, Keys.D1);
            RegisterHotKey(this.Handle, ONENUME_D2, KeyModifiers.Control, Keys.D2);
            RegisterHotKey(this.Handle, SWITCH_BUTTON, KeyModifiers.Control | KeyModifiers.Shift, Keys.S);
            RegisterHotKey(this.Handle, SWITCH_BUTTON, KeyModifiers.Control | KeyModifiers.Shift, Keys.R);
        }

        private void Main_Closed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(this.Handle, ONENUME_UP);
            UnregisterHotKey(this.Handle, ONENUME_DOWN);
            UnregisterHotKey(this.Handle, ONENUME_D1);
            UnregisterHotKey(this.Handle, ONENUME_D2);
            UnregisterHotKey(this.Handle, SWITCH_BUTTON);
            UnregisterHotKey(this.Handle, RESET_BUTTON);
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int ONENUME_UP = 31197;
        const int ONENUME_DOWN = 31198;
        const int ONENUME_D1 = 31199; 
        const int ONENUME_D2 = 31196; 
        const int SWITCH_BUTTON = 31200;
        const int RESET_BUTTON = 31201;

        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        bool oneNum = false;
        bool twoNum = false;

        const int WM_HOTKEY = 0x0312;
        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case WM_HOTKEY:
                    Keys key = (Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    KeyModifiers modifier = (KeyModifiers)((int)message.LParam & 0xFFFF);

                    if ((KeyModifiers.Control) == modifier && Keys.Up == key)
                    {
                        if (oneNum)
                        {
                            Console.WriteLine("여기1번");
                            if (checkTextBlank())
                            {
                                int num = Int32.Parse(txtOneNum.Text);
                                txtOneNum.Text = (num + 1).ToString();
                                ShowScore();
                            }
                            oneNum = false;
                        }else if (twoNum)
                        {
                            if (checkTextBlank())
                            {
                                int num = Int32.Parse(txtTwoNum.Text);
                                txtTwoNum.Text = (num + 1).ToString();
                                ShowScore();
                            }
                            twoNum = false;
                        }
                        Console.WriteLine("위눌림");
                    }

                    if ((KeyModifiers.Control) == modifier && Keys.Down == key)
                    {
                        if (oneNum)
                        {
                            if (checkTextBlank())
                            {
                                int num = Int32.Parse(txtOneNum.Text);
                                if (num > 0)
                                {
                                    txtOneNum.Text = (num - 1).ToString();
                                }
                                ShowScore();
                            }
                            oneNum = false;
                        }
                        else if (twoNum)
                        {
                            if (checkTextBlank())
                            {
                                int num = Int32.Parse(txtTwoNum.Text);
                                if (num > 0)
                                {
                                    txtTwoNum.Text = (num - 1).ToString();
                                }
                                ShowScore();
                            }
                            twoNum = false;
                        }
                        Console.WriteLine("아래눌림");
                    }

                    if ((KeyModifiers.Control) == modifier && Keys.D1 == key)
                    {
                        oneNum = true;
                        twoNum = false;
                        Console.WriteLine("1번눌림");
                    }


                    if ((KeyModifiers.Control) == modifier && Keys.D2 == key)
                    {
                        twoNum = true;
                        oneNum = false;
                        Console.WriteLine("2번눌림");
                    }


                    if ((KeyModifiers.Control | KeyModifiers.Shift) == modifier && Keys.S == key){
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

                    break;
            }
            base.WndProc(ref message);
        }

        private void tmInfoUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[OBS]\r1.OBS 소스 추가 - 윈도우 캡쳐\r2.윈도우[ScoreBoard.exe]: ScoreBoardLive\r3.윈도우 일치 우선순위 - 창 제목이 일치해야 합니다\r4.해당 윈도우 캡처 우클릭->필터\r5. + 를 눌러 '크로마 키' 추가\r6.키 색상 형식(녹색) - 그 외에는 기본값\r\r\r[XSplit]\r1.스코어보드 출력 후 해당 창 출력\r2.Add Source->Window capture->ScoreboardLive\r- 방송 및 프로그램 종료 후 다시 킬경우 소스 설정하는 부분에서 다시 ScoreBoardLive 선택해주셔아 합니다\r(해당 소스 우클릭 Window Sorce 셀렉트박스에서 ScoreBoardLive 선택)\r3.해당 Source 우클릭->Color 탭->Chroma Key(Key Color 값 Green)\r","사용법");
        }

        private void tmInfoHotkey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[점수 올리기/내리기]\r1. 1P 점수 올리기/내리기\r    Ctrl + 1 , 방향키위/아래 (순서대로 눌러주세요)\r2. 2P 점수 올리기/내리기\r    Ctrl + 2 , 방향키위/아래 (순서대로 눌러주세요)\r\r[자리바꾸기]\rCtrl + Shift + S", "단축키 정보");
        }
    }
}