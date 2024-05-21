using System.Collections;

namespace Ovning1PersonalLedger
{
    internal class Program
    {
        //deklarera tom arrayClassCollection
        //Person[] personList;
        //public ArrayList personArrayList = new ArrayList();

        
        //Person newPerson = new Person("alsdjf", 17167);
        static void Main(string[] args)
        {
            /*
            List<Person> persons = new List<Person>();
            Person newPerson = new Person("Else Beskow", 20000);
            persons.Add(newPerson);
            */
            //Console.WriteLine("Hello, World!");
            //Person thePerson = new Person();
            bool displayMenu = true;
            while (displayMenu == true)
            {
                
                displayMenu = MainMenu();
            }

        }

        public static bool MainMenu()
        {
            List<Person> persons = new List<Person>();
            Person newPerson = new Person("Else Beskow", 20000);
            persons.Add(newPerson);
            Console.Clear();
            Console.WriteLine("make a choice");
            Console.WriteLine("1) Add Employee");
            Console.WriteLine("2) Print ledger");
            Console.WriteLine("3) exit");
            String result = Console.ReadLine();

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
