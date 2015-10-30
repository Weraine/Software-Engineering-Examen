using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class ItemController
    {
        private GameController container;
        private ItemModel model;
        private ItemsView view;

        public ItemController()
        {
            
            model = new ItemModel();
            view = new ItemsView(this);
        }

        public ItemsView getView()
        {
            return view;
        }
        
        public void BuyD()   { 
            model.buyDice();
            view.updateUI();
        }
        public void BuyMax() { 
            model.buyMax();
            view.updateUI();
        }
        public void BuyMin() {
            model.buyMin();
            view.updateUI();
        }
        public int getPrice1{get {return model.Price1;}}
        public int getPrice2 { get { return model.Price2; } }
        public int getPrice3 { get { return model.Price3; } }
    }
}
