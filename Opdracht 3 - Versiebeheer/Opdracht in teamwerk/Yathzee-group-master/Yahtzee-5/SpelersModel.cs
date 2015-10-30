using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class SpelersModel
    {
        public int spelersNummer;
        public bool isGeselecteerd = false;

        public SpelersModel(int s)
        {
            spelersNummer = s;
        }

        public int GetSpelersNummer()
        {
            return spelersNummer;

        }




        


    }
}
