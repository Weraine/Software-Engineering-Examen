using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class YahtzeeModel
    {
        // List die alle teerlingen zal bewaren
        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        private List<SpelersController> spelers = new List<SpelersController>();
        private List<ItemController> items = new List<ItemController>();

        /*
            De members die de configuratie voor het Yahtzeespel zullen onthouden
        */
        private int aantalTeerlingen = 0;
        private int huidigAantalWorpen = 0;
        private int maximumAantalWorpen = 0;
        private int aantalSpelers = 2; //-------

        /*
            Voeg een teerling toe aan de lijst met teerlingen
        */
        internal void addTeerling(TeerlingController teerling)
        {
            teerlingen.Add(teerling);
        }

        internal void addSpeler(SpelersController speler)
        {
            spelers.Add(speler);
        }
        internal void  addItem(ItemController item)
        {

            items.Add(item);

        }



        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
            }
        }

        public List<SpelersController> Spelers
        {
            get
            {
                return spelers;
            }
        }

        public List<ItemController> Items
        {
            get 
            {
                return items;
            }
        }


        public int aantalWorpen
        {
            get
            {
                return huidigAantalWorpen;
            }
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int MaximumAantalWorpen
        {
            get
            {
                return maximumAantalWorpen;
            }
            set
            {
                maximumAantalWorpen = value;
            }
        }

        /*
            getter en setter voor het aantal teerlingen
        */
        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }
            set
            {
                aantalTeerlingen = value;
            }
        }


        public int AantalSpelers
        {
            get
            {
                return aantalSpelers;
            }
            set
            {
                aantalSpelers = value;
            }
        }

        /*
            tel eentje bij het huidig aantal worpen
        */
        public int voegWorpToe()
        {
            return ++huidigAantalWorpen;
        }



        /*public int zetWorpenOpNul()
        {
            

        }*/

    }
}
