using System.Collections;
using PersonalLedger;
using PersonalLedger.HelpersPractice;

namespace Ovning1PersonalLedger
{
    internal class Program
    {
        private static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {

            bool displayMenu = true;
            do
            {
                displayMenu = MainMenu();

            } while (displayMenu); 
        }

        public static bool MainMenu()
        {

            PrintMenu();
            String result = Console.ReadLine();

            // byt till switch case
            switch (result)
            {
                case MenuHelpers.AddVisitor:
                    {
                        Person aperson = AddVisitor();
                        aperson.PrintToConsole();
                        break;
                    }
                case MenuHelpers.AddGroup:
                    {
                        AddGroup();
                        PrintGroup(persons);
                        persons.Clear();
                        break;
                    }
                case MenuHelpers.WordRepeater:
                    {
                        RepeatSentence();
                        break;
                    }
                case MenuHelpers.ThirdWorder:
                    {
                        SentenceParser();
                        break;
                    }
                case MenuHelpers.WhileExample:
                    {
                        WhileExample();
                        break;
                    }
                case MenuHelpers.LoopBreak:
                    {
                        LoopBreakExample();
                        break;
                    }
                case MenuHelpers.YearlyWage:
                    {
                        int amount = 1234;
                        int months = 12;
                        int bonus = 1000;
                        Console.WriteLine(Utilz.CalculateYearlyWage(amount, months, bonus));
                        break;
                    } 
                case MenuHelpers.Quit:
                    Environment.Exit(0);
                    break;


                default:
                    Console.WriteLine("Unvalid choice");
                    break;

            }
            Console.ReadLine();
            return true;

            
        }

        private static void PrintMenu()
        {

            Console.Clear();
            // Todo implement IEnumerable for indexcounter GetEnumerator()
            int i = 0;
            Console.Clear();
            foreach (string menuText in MenuHelpers.MenuCollection2Print())
            {
                Console.WriteLine("{0}: {1}", i, menuText);
                i++;
            }

        }

        /*
        static void CalculateYearlyWage(int monthlyWage, int numberOfMonths)
        {
            Console.WriteLine($"Yearly wage is: {monthlyWage * numberOfMonths}");
        }*/
        private static void LoopBreakExample()
        {
            Console.Clear();
            Console.WriteLine("Enter a value");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < max; i++)
            {

                if (i== 5)
                {
                    Console.WriteLine("Bingo {0} is da shit", i);
                    continue; // skips rest and iterates on next i value.
                    // break; the loop stops iterating.
                }
                Console.WriteLine(i);
            }

        }

        private static void WhileExample()
        {
            Console.Clear();
            Console.WriteLine("Enter a value");
            int max = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < max)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void SentenceParser()
        {
            string inSentence = "";
            Console.Clear();
            Console.WriteLine("Write a sentence minimum three words:");
            inSentence = Console.ReadLine();
            string[] words = inSentence.Split(' ');
            Console.WriteLine("the third word is {0}",words[2]);
        }

        private static void RepeatSentence()
        {
            string inSentence = "";
            Console.Clear();
            Console.WriteLine("Write a sentence");
            inSentence = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(inSentence);
            }
        }

        private static Person AddVisitor()
        {
            //string name = "";
            int age = 0;

            Console.Clear();
            Console.WriteLine("Input the visitors age");
            age = int.Parse(Console.ReadLine());

            return new Person(age); 
        }


        private static List<Person> AddGroup()
        {
            int grpSize = 0;
            Console.Clear();
            Console.WriteLine("Input group size");
            grpSize = int.Parse(Console.ReadLine());
            for (int i = 0; i < grpSize; i++)
            {
                persons.Add(AddVisitor());
            }

            return persons; 
        }

        


        private static void PrintGroup(List<Person> inPersonList)
        {
            int sum = 0;
            foreach(Person aperson in inPersonList)
            {
                sum += aperson.CalcPrice();
            }
            Console.Clear();
            Console.WriteLine("Nr People: {0}", inPersonList.Count);
            Console.WriteLine("Total cost: {0}kr", sum);
        }


        /*
        private static void PrintLedger(List<Person> persons)
        {
            Console.Clear();
            Console.WriteLine("Stafflist:");
            
            foreach (Person person in persons)
            {
                person.PrintToConsole();
            }
            
            Console.ReadLine();
        }

        
        private static void PlayVarGame()
        {
            Console.Clear();
            Console.WriteLine("Type anything");
            var anyThing = Console.ReadLine();
            Console.WriteLine("Your input is of type: {0}", anyThing.GetType().FullName);
            Console.ReadLine();

        }

        private static void PractCustHelpFuncs()
        {
            Console.Clear();
            Console.WriteLine("Type a string");
            var stringA = Console.ReadLine();
            Console.WriteLine("Type a new string to compare");
            var stringB = Console.ReadLine();
            Console.WriteLine(HelperUtils.CompareDaStrings(stringA, stringB) ? "They match" : "They don't match");
            //Console.WriteLine("of type: {0}",HelperUtils.SwitchStringLengthType(stringA));
            
            Console.ReadLine(); 


        }
        */


    }

    class Person
    {
        public int Age { get; set; }

        //public Person() { }
        public Person(int inAge)
        {
            Age = inAge;
        }

        public int CalcPrice()
        {
            int calcPrice = 120;
            switch (Age)
            {
                case < 21:
                    {
                        calcPrice = 80;
                        break;
                    }

                case > 64:
                    calcPrice = 90;
                    break;

                default:
                    break;

            }

            return calcPrice;
        }
        public void PrintToConsole()
        {
            string toPrint = "Standardpris";
            switch (Age)
            {
                case < 21:
                    {
                        toPrint = "Ungdomspris";
                        break;
                    }

                case > 64:
                    toPrint = "Pensionärspris";
                    break;

                default:
                    break;

            }
            Console.WriteLine("{0}: {1}kr", toPrint, this.CalcPrice());
            Console.WriteLine();
        }

    }
}
