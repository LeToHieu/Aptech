using System;

namespace MyApp
{
    class Program   
    {
        public static void inputSomething()
        {
            //nhap ten va tuoi tu ban phim
            Console.WriteLine("Nhap ten cua ban : "); //output
            string name = Console.ReadLine();//input
            Console.WriteLine("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name = {0}, age = {1}", name, age);
            Console.Write("Press any key to exit");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Khai bao bien(variable)
            /*
            int x = 100;//day goi la cac value type
            var y = 200;
            long z = 300L;
            double t = 123.45;
            float x1 = 1133.33f;
            //string literals hoac string concatenation
            Console.WriteLine("Gia tri x = {0}, gia tri y = {1}, z = {2}", x, y, z);
            string aString = "\u20A9";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Dong won la : {0}", aString);
            */
            //inputSomething();
            Console.WriteLine("Toi co {0:C} tien", 122);            
            long myVisaCard = 3225_1112_2254_8888L;
            Console.WriteLine("my visaCard = {0}", myVisaCard);
            //imlicit casting = ep kieu tu nho => to => luc nao cung ok
            int x2 = 120;
            long x3 = x2;//always successful
            //explicit casting = ep kieu tu to ve nho => kieu gi cung tran(overflow)
            /*
            int a = 257;
            char b = (char)a;
            Console.WriteLine("b = {0}", b);
            */
            Console.WriteLine("Min int = {0}", int.MinValue);
            Console.WriteLine("Max int = {0}", int.MaxValue);
            long a = int.MaxValue + 1L;
            int b = (int)a;
            Console.WriteLine("b = {0}", b);
            

        }
    }
}
