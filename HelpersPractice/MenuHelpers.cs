using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLedger.HelpersPractice
{
    public static class MenuHelpers
    {
        public const string Quit = "0";
        public const string AddVisitor = "1";
        public const string AddGroup = "2";
        public const string WordRepeater = "3";
        public const string ThirdWorder = "4";
        public const string WhileExample = "5";
        public const string LoopBreak = "6";
        public const string YearlyWage = "7";
        //public const string PrintLedger = "2";
        //public const string PlayVarGame = "3";
        //public const string PractCustHelpFuncs = "4";




        public static List<string> MenuCollection2Print()
        {
            //Todo byt till Enum
            List<string> menuTexts = new List<string>();
            menuTexts.Add("Quit");
            menuTexts.Add("AddVisitor");
            menuTexts.Add("AddGroup");
            menuTexts.Add("WordRepeater");
            menuTexts.Add("ThirdWorder");
            menuTexts.Add("WhileExample");
            menuTexts.Add("LoopBreak");
            menuTexts.Add("YearlyWage");
            //menuTexts.Add("PrintLedger");
            //menuTexts.Add("PlayVarGame");
            //menuTexts.Add("PractCustHelpFuncs");


            return menuTexts;
        }
    }

    
}
