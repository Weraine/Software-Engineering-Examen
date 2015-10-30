using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class ItemModel
    {
        private YahtzeeModel model;
        private TeerlingModel tModel;
        private int price1;

        public int Price1
        {
            get { return price1; }
            set { price1 = value; }
        }
        private int price2;

        public int Price2
        {
            get { return price2; }
            set { price2 = value; }
        }
        private int price3;

        public int Price3
        {
            get { return price3; }
            set { price3 = value; }
        }


        public ItemModel()
        {
            price1 = 10;
            price2 = 5;
            price3 = 7;
        }
        public int getCoins
        {
            get;
            set;
        }
        public void buyDice(){

            if ((getCoins - price1)>= 0)
            {
                getCoins = -price1;

                price1 = price1 * 4;

                AantalTeerlingen++;
            }
 

        }
        public void buyMin() {

            if ((getCoins - price2)>=0)
            {
                getCoins = -price2;

                price2 = price2 * 2;

                Min++; 
            }

        
        }
        public void buyMax() {

            if ((getCoins - price3)>= 0)
            {
                getCoins = -price3;

                price3 = price3 * 3;

                Max++;
            }

        
        }
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
        public int Min
        {
            get
            {
                return tModel.min;
            }
            set
            {
                tModel.min = value;
            }
        }
        public int Max
        {
            get
            {
                return tModel.max;
            }
            set
            {
                tModel.max = value;
            }
        }
    }
}
