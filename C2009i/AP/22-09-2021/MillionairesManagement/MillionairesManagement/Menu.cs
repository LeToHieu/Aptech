using System;
using System.Collections.Generic;
using MillionairesManagement.Models;

namespace MillionairesManagement
{
    public class Menu : IMenu
    {
        private List<Person> persons = new List<Person>();//variable = field
        public void Analyze()
        {

        }

        public void Find()
        {

        }

        public void Input()
        {
            Console.WriteLine("Enter number of Persons:");
            int numberOfPersons = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numberOfPersons; i++)
            {
                Person person = new Person();
                person.Input();
                persons.Add(person);
            }            
        }

        public void Open()
        {

        }

        public void Save()
        {

        }

        public void Sort()
        {
            //2 vong for + bubble => not neccessary !
            this.persons.Sort((person1, person2) => (int)(person1.NetWorth - person2.NetWorth));            
        }
        private void Display()
        {            
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| Person Name | Nationality | Birth Year | Net Worth(billion $) |");
            Console.WriteLine("+ ------------------------------------------------------------------+");
            foreach (Person person in this.persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        public void ShowMenu()
        {
            string choice = "";
            while (choice != "7")
            {
                Console.WriteLine("+------------------------------------------------------------------+");
                Console.WriteLine("| BILLIONAIRES PROFILE MANAGEMENT PROGRAM |");
                Console.WriteLine("+ ------------------------------------------------------------------+");
                Console.WriteLine("| 1.Input | 2.Sort | 3.Analyze | 4.Find | 5.Save | 6.Open | 7.Exit |");
                Console.WriteLine("+ ------------------------------------------------------------------+");
                Console.WriteLine("Enter your choice : ");
                choice = (Console.ReadLine() ?? "").Trim();
                Console.WriteLine($"Your choice: {choice}");
                if (choice.Equals("1"))
                {
                    this.Input();
                    this.Display();
                }
                
                else if (choice.Equals("2"))
                {
                    this.Sort();
                }
                else if (choice.Equals("3"))
                {

                }
                else if (choice.Equals("4"))
                {

                }
                else if (choice.Equals("5"))
                {

                }
                else if (choice.Equals("6"))
                {

                }
                else if (choice.Equals("7"))
                {
                    break;
                }
                Console.WriteLine("Do you want to continue ?");
                Console.WriteLine("- Yes, I do. (press ‘y’, ‘Y’)");
                Console.WriteLine("- No, I don’t. (press ‘n’, ‘N’)");
                Console.WriteLine("- Please clear the screen!(press ‘c’, ‘C’)");
                Console.WriteLine("Enter your choice : ");
                //?? = elvis(C#, js, Kotlin, Dart)
                //Console.ReadLine()?.Trim(); //(C#, js, Kotlin, Dart, Swift)
                choice = (Console.ReadLine() ?? "").Trim();
                /*
                if (choice.ToLower().Equals("n"))
                {
                    choice = "7"; 
                }
                */
                choice = choice.ToLower().Equals("n") ? "7" : choice;
                if (choice.ToLower().Equals("c"))
                {
                    Console.Clear();
                }

            }
            Console.WriteLine("End program");
            
        }
    }
}
