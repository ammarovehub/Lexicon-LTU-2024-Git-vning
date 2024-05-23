using System.Collections;
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
                case MenuHelpers.Add:
                    {
                        Person aperson = AddStaffer();
                        persons.Add(aperson);
                        break;
                    }
                case MenuHelpers.PrintLedger:
                    {
                        PrintLedger(persons);
                        break;
                    }
                case MenuHelpers.PlayVarGame:
                    {
                        PlayVarGame();
                        break;
                    }
                case MenuHelpers.PractCustHelpFuncs:
                    {
                        PractCustHelpFuncs();
                        break;
                    }
                case MenuHelpers.Quit:
                    Environment.Exit(0);
                    break;

                default:
                    break;

            }

            return true;

            
        }

       

        private static Person AddStaffer()
        {
            string name = "";
            int salary = 0;
            Console.Clear();
            Console.WriteLine("Input the staffers name");
            name = Console.ReadLine();
            Console.WriteLine("Input the staffers salary");
            salary = int.Parse(Console.ReadLine());
            return new Person(name, salary); 
        }

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
            Console.WriteLine("of type: {0}",HelperUtils.SwitchStringLengthType(stringA));
            
            Console.ReadLine(); 


        }

        private static void PrintMenu()
        {
            
            Console.Clear();
            // Todo implement IEnumerable for indexcounter GetEnumerator()
            int i = 1; Console.Clear();
            foreach (string menuText in MenuHelpers.MenuCollection2Print())
            {
                Console.WriteLine("{0}: {1}", i, menuText);
                i++;
            }
            
        }
    }

    class Person
    {
        public string FullName { get; set; }

        public int Salary { get; set; }

        //public Person() { }
        public Person(string fullName, int salary)
        {
            FullName = fullName;
            Salary = salary;
        }

        public void PrintToConsole()
        {
            Console.WriteLine("Name: {0}", this.FullName);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine();
        }

    }
}
