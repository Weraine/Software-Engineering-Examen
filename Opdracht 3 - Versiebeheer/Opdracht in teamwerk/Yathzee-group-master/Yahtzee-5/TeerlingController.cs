using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class TeerlingController
    {
        private TeerlingModel model;
        private TeerlingView view;

        // Constructor
        public TeerlingController()
        {
         
            model = new TeerlingModel();
            view = new TeerlingView(this);
        }

        public TeerlingView getView()
        {
            return view;
        }

        /*
            Methode die opvangt wanneer er op een individuele teerling "smijt" knop wordt gedrukt
        */
        public void Werp()
        {
            // Controleer of de teerling niet is vastgezet
            if (!model.Vast)
            {
                // Voer de random generator methode in het model uit
                model.Werp();

                // Update de view met de nieuwe waarde die de teerling heeft gekregen
                view.updateUI();
            }
        }

        // Draai de 'isVast' waarde om wanneer er op de teerling wordt geklikt
        public void toggleVast()
        {
            // Zeg tegen het model dat de teerling isVast waarde moet omgedraaid worden
            model.toggleVast();

            // Update de view met de nieuwe waarde die de teerling heeft gekregen
            view.updateUI();
        }

        /*
            Return de waarde die onthoudt of de teerling vast staat of niet
        */
        public bool Vast
        {
            get
            {
                return model.Vast;
            }
        }

        /*
           Return de waarde met de waarde van de teerling (= aantal ogen)
       */
        public int AantalOgen
        {
            get
            {
                return model.AantalOgen;
            }
        }
    }
}
