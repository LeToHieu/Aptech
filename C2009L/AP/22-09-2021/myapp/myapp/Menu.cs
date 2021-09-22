using myapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;//Language Integated Query
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    public class Menu
    {
        private List<Person> persons = new List<Person>();//field = variable
        /*
        public List<Person> Persons { get => persons; 
            set { 
                persons = value;
            } 
        }
        */
        private void Analyze()
        {
            /*
             * result["usa"] = 2
             * result["vietnam"] = 3
             */
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (Person person in persons)
            {
                string nationality = person.Nationality ?? ""; //Elvis operator
                //string nationality = person.Nationality == null ? "" : person.Nationality;
                int x = 0;
                /*
                if(result.ContainsKey(nationality))
                {
                    x = result[nationality];
                } else
                {
                    x = 0;
                }
                result[nationality] = x + 1;
                */    
                result[nationality] = (result.ContainsKey(nationality) ? result[nationality] : 0) + 1;
            }

            Console.WriteLine("Statistics Result:");
            foreach (var nationality in result.Keys)
            {
                Console.WriteLine($"+There are {result[nationality]} person(s) from ‘{nationality}’.");
            }
                        
        }
        private void Find()
        {
            Console.WriteLine("Enter nationality: ");
            string nationality = (Console.ReadLine() ?? "").Trim().ToLower();

            Console.WriteLine("Enter min = ");
            float min = (float)Convert.ToDouble(Console.ReadLine() ?? "0");

            //iterate a list, found => save to new List => NO !
            
            List<Person> filteredPersons = this.persons
                .Where(person => (person.Nationality ?? "").Trim().ToLower().Equals(nationality) &&
                    person.NetWorth >= min
                ).ToList();
            foreach(Person person in filteredPersons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine($"{filteredPersons.Count} person(s) found");
        }
        public void ShowMenu() {
            string choice = "";
            GenerateData();
            while (true)
            {
                Console.WriteLine("+------------------------------------------------------------------+");
                Console.WriteLine("| BILLIONAIRES PROFILE MANAGEMENT PROGRAM |");
                Console.WriteLine("+ ------------------------------------------------------------------+");
                Console.WriteLine("| 1.Input | 2.Sort | 3.Analyze | 4.Find | 5.Save | 6.Open | 7.Exit |");
                Console.WriteLine("+ ------------------------------------------------------------------+");                
                Console.WriteLine("Enter your choice:");
                choice = (Console.ReadLine() ?? "").Trim().ToLower();
                if (choice.Equals("1")) 
                {
                    Console.WriteLine("Input");
                    InputSomePersons();
                } else if (choice.Equals("2"))
                {
                    Console.WriteLine("Sort");
                    SortAllPersons();
                }
                else if (choice.Equals("3"))
                {
                    Console.WriteLine("Analyze");
                    this.Analyze();
                }
                else if (choice.Equals("4"))
                {
                    this.Find();
                    Console.WriteLine("Find");
                }
                else if (choice.Equals("5"))
                {
                    Console.WriteLine("Save");
                }
                else if (choice.Equals("6"))
                {
                    Console.WriteLine("Open");
                }
                else if (choice.Equals("7"))
                {
                    Console.WriteLine("Exit");
                    break;
                }
                Console.WriteLine("Do you want to continue ?");
                Console.WriteLine("- Yes, I do. (press ‘y’, ‘Y’)");
                Console.WriteLine("- No, I don’t. (press ‘n’, ‘N’)");
                Console.WriteLine("- Please clear the screen!(press ‘c’, ‘C’)");
                Console.WriteLine("Your choice:");
                choice = (Console.ReadLine() ?? "").Trim().ToLower();
                if (choice.Equals("n")) 
                {
                    break;
                } else if(choice.Equals("c"))
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("Program exited");
        }
        public void InputSomePersons()
        {
            Console.WriteLine("Number of persons: ");
            int numerOfPersons = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= numerOfPersons; i++)
            {
                Console.WriteLine($"Please input Person[{i}]");
                Person person = new Person();
                person.Input();
                persons.Add(person);
            }
            this.ShowAllPersons();
        }
        private void GenerateData()
        {
            this.persons = new List<Person>()
            {
                new Person()
                {                    
                    Name = "a",
                    Nationality = "aa",
                    BirthYear = 1981,
                    NetWorth = 11,
                },
                new Person()
                {
                    Name = "b",
                    Nationality = "bb",
                    BirthYear = 1981,
                    NetWorth = 15,
                },
                new Person()
                {
                    Name = "c",
                    Nationality = "bb",
                    BirthYear = 1981,
                    NetWorth = 10,
                },
                new Person()
                {
                    Name = "d",
                    Nationality = "dd",
                    BirthYear = 1981,
                    NetWorth = 20,
                }
            };
        }
        public void ShowAllPersons()
        {
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("Person Name | Nationality | Birth Year | Net Worth(billion $) |");
            Console.WriteLine("+ ------------------------------------------------------------------+");
            foreach (Person person in this.persons)
            {                
                Console.WriteLine(person.ToString());
            }
        }
        public void SortAllPersons()
        {
            this.persons.Sort((p1, p2) => (int)(p2.NetWorth - p1.NetWorth));
            ShowAllPersons();
        }
        private void Save()
        {
            //save to csv file(Comma Separated Value)
        }
        private void Open()
        {

        }
    }
}
