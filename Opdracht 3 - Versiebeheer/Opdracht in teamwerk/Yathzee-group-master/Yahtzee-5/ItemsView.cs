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
    public partial class ItemsView : UserControl
    {
        private ItemController controller;
        


        public ItemsView(ItemController ItemController)
        {
            InitializeComponent();
            controller = ItemController;
        }

        public void updateUI()
        {
            Price1.Text = "price: " + controller.getPrice1;
            Price2.Text = "price: " + controller.getPrice2;
            Price3.Text = "price: " + controller.getPrice2;
        }

        private void ItemName_Click(object sender, EventArgs e)
        {
            
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            controller.BuyD();
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            controller.BuyMax();
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            controller.BuyMin();
        }

        private void ItemsView_Load(object sender, EventArgs e)
        {

        }
    }
}
