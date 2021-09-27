using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    class Book
    {
        public string Code {  get; set; }
        public DateTime InputDate {  get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        //1 = new, 2 = old => NO !
        public BookType BookType { get; set; }
        public void Input()
        {
            Console.WriteLine("Enter code: ");
            Code = Console.ReadLine()?? "".ToLower();

            //input date ?
            Console.WriteLine("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter amount:");
            Amount = Convert.ToInt32(Console.ReadLine());


            /*
            string stringBookType = "";
            while(!stringBookType.Equals("old") && !stringBookType.Equals("new"))
            {
                Console.WriteLine("Enter bootype(please enter old or new):");
                stringBookType = Console.ReadLine() ?? "".ToLower();
                BookType = stringBookType.Equals("old") ? BookType.Old : BookType.New;
            }
            */
            int integerBookType = -1;
            while (integerBookType != 1 && integerBookType != 2)
            {
                Console.WriteLine("Enter bootype(please enter 1(old) or 2(new)):");
                integerBookType = Convert.ToInt32(Console.ReadLine());
                BookType = integerBookType == 1 ? BookType.Old : BookType.New;
            }
        }
    }
}
