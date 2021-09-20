using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    public class Menu
    {
        public void ShowMenu() {
            string choice = "";
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
                } else if (choice.Equals("2"))
                {
                    Console.WriteLine("Sort");
                }
                else if (choice.Equals("3"))
                {
                    Console.WriteLine("Analyze");
                }
                else if (choice.Equals("4"))
                {
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
    }
}
