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
        ScoreBoard newScore = new ScoreBoard();
        public Main()
        {
            InitializeComponent();
        }

        private void ShowScore()
        {
            newScore.Passvalue = txtPlayerOneName.Text;
            newScore.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowScore();
        }
    }
}
