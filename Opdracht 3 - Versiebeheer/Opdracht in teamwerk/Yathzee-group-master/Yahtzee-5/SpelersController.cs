using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
     public class SpelersController
    {
        private SpelersView spelersView;
        private SpelersModel spelersModel;
        static int spelersNummer = 1;

         public SpelersController()
        {
            spelersModel = new SpelersModel(spelersNummer++);
            spelersView = new SpelersView(this);
        }

         public SpelersView getView()
         {
             return spelersView;
         }

         public SpelersModel getModel() 
         {
             return spelersModel;
         }

         public void veranderSelectie()
         {
             spelersModel.isGeselecteerd = !spelersModel.isGeselecteerd;
             spelersView.UpdateView();
         }
         


    }
}
