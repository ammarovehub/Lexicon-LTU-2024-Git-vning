namespace PersonalLedger.HelpersPractice
{
    public static class HelperUtils
    {

        public static bool CompareDaStrings(string inStringA, string inStringB)
        {
            bool result = false;

            result = inStringA == inStringB;
            return result;
        }

        public static string AgeGroup(int inAge)
        {
            string ageGroup = "";
            if (inAge >= 0 && inAge <= 12)
            {
                ageGroup = "Chile";
            }
            else if (inAge >= 13 && inAge < 18)
            {
                ageGroup = "Teenager";
            }
            else if (inAge > 17)
            {
                ageGroup = "Adult";
            }
            else { ageGroup = "Undefined"; }

            return ageGroup;
        }

        public static int SwitchAgeCategory(int inAge)
        {
            int calcPrice = 120;
            switch (inAge)
            {
                case < 21:
                    calcPrice = 80;
                    break;
                                    
                case > 64:
                    calcPrice = 90;
                    break;

                default:
                    break;

            }

            return calcPrice;
        }
    }
}
