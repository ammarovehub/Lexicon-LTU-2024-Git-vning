using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLedger
{
    internal class Utilz
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonths)
        {
            return monthlyWage * numberOfMonths;
        }

        //operator overloading
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonths, int bonus)
        {
            return monthlyWage * numberOfMonths + bonus;
        }

        public static int UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageEmployee = CalculateYearlyWageWithOptional(bonus: bonus, numberOfMonths: months, monthlyWage: amount);

            return yearlyWageEmployee;
        }
        public static int UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1); // uses default bonus=0
            return yearlyWageForEmployee1;
        }

        // Optional parameters set an default value makes it optional parameter ( C )
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonths, int bonus=0)
        {
            return monthlyWage * numberOfMonths + bonus;
            // ny kommentar
        }

        // Named arguments not required to follow order of parameters, one or more parameters can have a name defined 
        // when invoking the method.

        // Test för att bryta...

        // Expression-bodied syntax
        public static int UsingExpressionBodiedSyntax()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageEmployee = CalculateYearlyWageExpressionBodied(amount, months, bonus);

            return yearlyWageEmployee;
        }

        // more compact way of writing
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonths, int bonus) =>
            monthlyWage * numberOfMonths + bonus;



    }
}
