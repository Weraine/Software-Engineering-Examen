using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee1
{
    public partial class Spel : Form
    {
        int aantalTeerlingen = 3;
        private int scores;

        List<TeerlingController> teerlingen = new List<TeerlingController>();

        public Spel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {
                TeerlingController tijdelijkeTeerling = new TeerlingController();

                teerlingen.Add(tijdelijkeTeerling);
            }

            

            for (int teerlingNummer = 0; teerlingNummer < teerlingen.Count; teerlingNummer++)
            {
                TeerlingView teerlingView = teerlingen[teerlingNummer].GetView();

                int horizontalPosition = teerlingNummer * teerlingView.Width;

                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);
            }

            TeerlingController teerling1 = new TeerlingController();

            Controls.Add(teerling1.GetView());
        }

        
        

        public void buttonAll_Click(object sender, EventArgs e)
        {
            
            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; teerlingNummer++)
            {

                teerlingen[teerlingNummer].view.ButtonRoll.PerformClick();

            }
            if (teerlingen[0].view.Aantal_worpen()<3 &&  teerlingen[0].view.Aantal_worpen()> 0)
            {
                updateScore(teerlingen[0].model.getAantalOgen());
            }
            if (teerlingen[1].view.Aantal_worpen() < 3 && teerlingen[0].view.Aantal_worpen() > 0)
            {
                updateScore(teerlingen[1].model.getAantalOgen());
            }
            if (teerlingen[2].view.Aantal_worpen() < 3 && teerlingen[0].view.Aantal_worpen() > 0)
            {
                updateScore(teerlingen[2].model.getAantalOgen());
            }
            score.Text = "Score : " + scores;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void updateScore(int x) { scores += x; }

        
    }
}
