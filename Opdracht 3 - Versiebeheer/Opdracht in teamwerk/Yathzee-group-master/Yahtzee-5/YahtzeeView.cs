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
    public partial class YahtzeeView : UserControl
    {
        // Member die de controller opvangt
        private YahtzeeController controller;
      

        public YahtzeeView(YahtzeeController yahtzeeController)
        {
            // Ken de controller die die werd meegegeven tijdens de instantiatie 
            // toe aan de class member 
            controller = yahtzeeController;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
      
            List<TeerlingView> teerlingen = controller.getTeerlingenView();

            int teerlingWidth = teerlingen.First().Width;
            int teerlingHeight = teerlingen.First().Height;

            foreach (TeerlingView teerling in teerlingen)
            {

                TeerlingView huidigeTeerling = teerling;
               
                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth;
                huidigeTeerling.Location = new Point(xPos, 0);

                Controls.Add(huidigeTeerling);
            }


            List<SpelersView> spelers = controller.getSpelersView();

            int spelerWidth = spelers.First().Width;
            int spelerHeight = spelers.First().Height;

            foreach (SpelersView speler in spelers)
            {
                SpelersView huidigeSpeler = speler;

                int xPos = spelers.IndexOf(speler) * spelerWidth;
                huidigeSpeler.Location = new Point(xPos, 250);

                Controls.Add(huidigeSpeler);
            }


            List<ItemsView> items = controller.getItemsView();

            int itemWidth = items.First().Width; 
            int itemHeight = items.First().Height;

            foreach(ItemsView item in items)
            {
                ItemsView huidigItem = item;

                int xPos = items.IndexOf(item) * itemWidth;
                huidigItem.Location = new Point(xPos+350, 255);

                Controls.Add(huidigItem);

            }


            // De "Smijt alle teerlingen" knop setten op basis van de hoogte van één teerling
            werpAlleTeerlingenButton.Location = new Point(10, teerlingHeight );
        }

        /*
            Event handler die opvangt wat er moet gebeuren wanneer op de "smijt alle teerlingen" wordt geklikt
        */
        private void smijtAlleTeerlingenButton_click(object sender, EventArgs e)
        {
            // Roep de smijtAlleTeerlingen methode aan die in de controller gedefinieerd is
            controller.smijtAlleTeerlingen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            controller.veranderSpeler();
            

            


        }
    }
}
