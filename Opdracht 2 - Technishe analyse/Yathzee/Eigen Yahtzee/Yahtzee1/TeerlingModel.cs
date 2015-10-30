using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee1
{
    public class TeerlingModel
    {

        private int aantalOgen;
        private bool vast;
        private Random random;
        private List<TeerlingView> observers = new List<TeerlingView>();

        public TeerlingModel()
        {
            random = new Random();
        }

        public int AantalOgen
        {
            get
            {
                return aantalOgen;
            }

            set
            {
                aantalOgen = value;
            }
        }
        public int getAantalOgen() { return aantalOgen; }
        public void werp()
        {          

            aantalOgen = random.Next(1, 7);

        }
        public bool IsVast()
        {
            return vast;
        }
        public void Werp()
        {
            if (!vast)
            {
                aantalOgen = random.Next(1, 7);
            }
            NotifyObservers();
        }

        public void MaakLos()
        {
            vast = false;
            NotifyObservers();
        }

        public void ZetVast()
        {
            vast = true;
            NotifyObservers();
        }
        public void AddObserver(TeerlingView observer)
        {
            observers.Add(observer);
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (TeerlingView tUI in observers)
            {
                tUI.UpdateUI();
                NotifyObservers();
            }
        }

    }
}
