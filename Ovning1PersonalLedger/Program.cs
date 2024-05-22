using System.Collections;

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
            Console.Clear();
            Console.WriteLine("make a choice");
            Console.WriteLine("1) Add Employee");
            Console.WriteLine("2) Print ledger");
            Console.WriteLine("3) Play the VarGame");
            Console.WriteLine("4) exit");
            String result = Console.ReadLine();

            // byt till switch case
            if (result == "1")
            {
                Person aperson = AddStaffer();
                persons.Add(aperson);
                return true;
            }
            else if (result == "2")
            {
                PrintLedger(persons);
                return true;
            }
            else if (result == "3")
            {
                PlayVarGame();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
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
