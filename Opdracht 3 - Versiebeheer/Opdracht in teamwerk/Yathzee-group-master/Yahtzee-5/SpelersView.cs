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
    public partial class SpelersView : UserControl
    {
        private SpelersController controller;


        public SpelersView(SpelersController spelersController)
        {
            InitializeComponent();
            controller = spelersController;
            label1.Text += controller.getModel().GetSpelersNummer();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        public void UpdateView()
        {
            label3.Visible = controller.getModel().isGeselecteerd;

        }

        private void SpelersView_Load(object sender, EventArgs e)
        {

        }

        
    }
}
