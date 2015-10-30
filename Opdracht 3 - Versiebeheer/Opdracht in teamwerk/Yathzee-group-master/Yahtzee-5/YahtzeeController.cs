using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class YahtzeeController
    {
        private GameController container;
        
        private YahtzeeView view;
        private YahtzeeModel model;

        public YahtzeeController(GameController cont)
        {
            container = cont;
            view = new YahtzeeView(this);
            model = new YahtzeeModel();
        }

        // Extra methode die dient als factory en alle methodes opsomt die uitgevoerd moeten worden
        // nadat de configuratie gebeurd is
        // Zou in de constructor kunnen, maar dan heb je niet meer de kans op bepaalde configuratievariabelen (aantal teerlingen, ...) aan te passen voor het spel wordt opgebouwd
        public void initialize()
        {
            maakTeerlingen();
            maakSpelers();
            maakItem();
        }

        // Voeg aantal teerlingen toe aan het model
        private void maakTeerlingen()
        {
            // Loop over het aantal teerlingen dat er mogen zijn (gedefiniëerd in GameController)
            for (int teerlingNummer = 0; teerlingNummer < AantalTeerlingen; ++teerlingNummer)
            {
                // Maak een nieuwe teerling aan
                TeerlingController teerling = new TeerlingController();

                // Voeg de teerling toe aan het model
                model.addTeerling(teerling);
            }
        }
        private void maakSpelers()
        {
            for(int spelersAantal =0; spelersAantal < AantalSpelers; ++spelersAantal)
            {
                SpelersController speler = new SpelersController();


                if (spelersAantal == 0)
                {
                    speler.getModel().isGeselecteerd = true;
                  
                }

                speler.getView().UpdateView();
                    model.addSpeler(speler);
              
            }

        }
        private void maakItem() 
        {
            ItemController item = new ItemController();

            model.addItem(item);
        }



        public void veranderSpeler()
        {

               foreach( SpelersController speler in model.Spelers)
                
            {
                speler.veranderSelectie();
            }
            
            
        }




        public List<TeerlingView> getTeerlingenView()
        {
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            foreach (TeerlingController teerling in model.Teerlingen)
            {
                TeerlingView teerlingView = teerling.getView();

                teerlingenView.Add(teerlingView);
            }

            return teerlingenView;
        }

        public List<SpelersView> getSpelersView()
        {
            List<SpelersView> spelersView = new List<SpelersView>();

            foreach (SpelersController spelers in model.Spelers)
            {
                SpelersView spelerView = spelers.getView();

                spelersView.Add(spelerView);

            }
            return spelersView;
        }

        public List<ItemsView> getItemsView() 
        {
            List<ItemsView> itemsView = new List<ItemsView>();

            foreach (ItemController items in model.Items)
            {
                ItemsView itemView = items.getView();

                itemsView.Add(itemView);

            }
            return itemsView;
        }

        



        public YahtzeeView getView()
        {
            return view;
        }

        public void veranderbeurt()
        {


        }


        public void smijtAlleTeerlingen()
        {
            // Controleer of het maximum aantal worpen niet is bereikt
            if (model.aantalWorpen < MaximumAantalWorpen)
            {
                // Haal de teerlingen op uit het model
                List<TeerlingController> teerlingen = model.Teerlingen;

                // Loop over de teerlingen
                foreach (TeerlingController teerling in teerlingen)
                {
                    // Voer de werp methode uit op elke teerling
                    teerling.Werp();
                }
                // Tel eentje bij het huidig aantal worpen
                model.voegWorpToe();
            }

            // Breng de container op de hoogte dat er veranderingen hebben plaatsgevonden
            container.modelHasChanged();
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int MaximumAantalWorpen
        {   
            get
            {
                return model.MaximumAantalWorpen;
            }
            set
            {
                model.MaximumAantalWorpen = value;
            }
            
        }

        /*
            getter voor het huidig aantal worpen
        */
        public int HuidigAantalWorpen
        {
            get
            {
                return model.aantalWorpen;
            }
        }

        /*
            getter en setter voor het vastgesteld aantal teerlingen
        */
        public int AantalTeerlingen
        {
            get
            {
                return model.AantalTeerlingen;
            }
            set
            {
                model.AantalTeerlingen = value;
            }
        }

        public int AantalSpelers
        {
            get 
            {
                return model.AantalSpelers;
            }
            set
            {
                model.AantalSpelers = value;
            }

        }
    }
}
