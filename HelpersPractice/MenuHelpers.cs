using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLedger.HelpersPractice
{
    public static class MenuHelpers
    {
        public const string Add = "1";
        public const string PrintLedger = "2";
        public const string PlayVarGame = "3";
        public const string PractCustHelpFuncs = "4";
        public const string Quit = "5";

        

        public static List<string> MenuCollection2Print()
        {
            //Todo byt till Enum
            List<string> menuTexts = new List<string>();
            menuTexts.Add("Add");
            menuTexts.Add("PrintLedger");
            menuTexts.Add("PlayVarGame");
            menuTexts.Add("PractCustHelpFuncs");
            menuTexts.Add("Quit");

            return menuTexts;
        }
    }

    
}
