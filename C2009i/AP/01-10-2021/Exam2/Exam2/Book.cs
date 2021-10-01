using System;
namespace Exam2
{
    public class Book : IBook
    {
        //field = variables
        private string title;
        private string author;
        private string publisher;
        private int year;
        private string isbn;
        private List<string> chapters;
        public Book()
        {
            chapters = new List<string>();
        }



        public string this[int i] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title {
            get => title;
            set {
                if (value.Length < 6 || value.Length > 40)
                {
                    throw new Exception("Title must be 6 and 40 in length");
                }
                title = value;
            }
        }
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ISBN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}

