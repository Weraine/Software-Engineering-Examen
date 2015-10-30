using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class ScoreView : UserControl
    {
        private ScoreController controller;

        public ScoreView(ScoreController scoreController)
        {
            InitializeComponent();
            controller = scoreController;
        }

        private void ScoreView_Load(object sender, EventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        public void UpdateLabel(int score)
        {
            labelScore.Text += score + "\n";
        }

        public void UpdateTotalLabel(int score)
        {
            LabelTotalScore.Text = score.ToString();
        }
    }
}
