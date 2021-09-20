using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillionairesManagementProgram
{
    public class Menu:IMenu
    {
        public void Analyze()
        {
            
        }

        public void Find()
        {
            
        }

        public void Input()
        {
            
        }

        public void Open()
        {
            
        }

        public void Save()
        {
            
        }
        
        public void Sort()
        {
            
        }
        public void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("+------------------------------------------------------------------+");
            Console.WriteLine("| BILLIONAIRES PROFILE MANAGEMENT PROGRAM |");
            Console.WriteLine("+ ------------------------------------------------------------------+");
            Console.WriteLine("| 1.Input | 2.Sort | 3.Analyze | 4.Find | 5.Save | 6.Open | 7.Exit |");
            Console.WriteLine("+ ------------------------------------------------------------------+");
            string choice = "";
            while (choice != "7")
            {
                Console.WriteLine("Enter your choice : ");
                choice = (Console.ReadLine() ?? "").Trim();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine(choice);
                        break;
                    case "2":
                        Console.WriteLine(choice);
                        break;
                    case "3":
                        Console.WriteLine(choice);
                        break;
                    case "4":
                        Console.WriteLine(choice);
                        break;
                    case "5":
                        Console.WriteLine(choice);
                        break;
                    case "6":
                        Console.WriteLine(choice);
                        break;
                    default:
                        Console.WriteLine("Do you want to continue ?");
                        Console.WriteLine("- Yes, I do. (press ‘y’, ‘Y’)");
                        Console.WriteLine("- No, I don’t. (press ‘n’, ‘N’)");
                        Console.WriteLine("- Please clear the screen!(press ‘c’, ‘C’)");
                        Console.WriteLine("Your choice:");
                        choice = (Console.ReadLine() ?? "").Trim();
                        /*
                        if (choice.ToLower().Equals("n"))
                        {
                            choice = "7"; 
                        }
                        */
                        choice = choice.ToLower().Equals("n") ? "7" : choice;
                        if (choice.ToLower().Equals("c")) {
                            Console.Clear();
                        }
                        break;

                }
            }
        }
    }
}
