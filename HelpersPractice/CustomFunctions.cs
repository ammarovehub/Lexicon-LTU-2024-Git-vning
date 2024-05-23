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


        public static string SwitchStringLengthType(string inString)
        {
            string lengthType = "undefined";
            switch (inString.Length)
            {
                case < 5:
                case > 10:
                    lengthType = "outOfRange";
                    break;

                case 5:
                    lengthType = "longer";
                    break;
                // interesting
                case > 6:
                    lengthType = "perfect";
                    break;

                default:
                    break;


            }

            return lengthType;
        }
    }
}
