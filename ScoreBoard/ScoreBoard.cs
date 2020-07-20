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
    public partial class ScoreBoard : Form
    {
        private string Player1_name;
        public string Passvalue
        {
            get { return this.Player1_name; }
            set { this.Player1_name = value;  }
        }

        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            txtPlayerOneName.Text = Passvalue;
        }
    }
}
