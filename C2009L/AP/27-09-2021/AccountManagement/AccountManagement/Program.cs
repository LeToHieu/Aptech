using BookManagement;

namespace AccountManagement
{
    public class Program
    {
        public static void Main(string [] args)
        {
            List<Book> books = new List<Book>();
            Console.WriteLine("Enter number of books");
            int numberOfBooks = Convert.ToInt32 (Console.ReadLine());
            for(int i = 0; i < numberOfBooks;i++)
            {
                Console.WriteLine($"Enter book [{i + 1}]");
                Book book = new Book();
                book.Input();
                books.Add(book);
            }
            Console.WriteLine("haha");
        }
    }
}