using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPO4311.ddi.Lib
{
   public class BookListTestSaver :IBookListSaver
    {
        public LoadStatus status => throw new NotImplementedException();
        private List<Book> _bookL = null;
        public BookListTestSaver()
        {
            this._bookL = new List<Book>();
        }

        public List<Book> books
        {
            get { return _bookL; }
            set { _bookL = value; }
        }
        public void Execute()
        {
            {
                Book book1 = new Book()
                {
                    Author = "Андерсон",
                    Name = "Не хочу взрослеть",
                    Datev = "17.06.2018",
                    Group = "комикс"
                };
               books.Add(book1); ;
            }
            {
                Book book1 = new Book()
                {
                    Author = "Кови",
                    Name = "Навыки",
                    Datev = "1.05.2016",
                    Group = "саморазвитие"
                };
                books.Add(book1); ;
            }
            {
                Book book1 = new Book()
                {
                    Author = "Дуглас",
                    Name = "Автостопом",
                    Datev = "13.11.1966",
                    Group = "фантастика"
                };
                books.Add(book1); 
            }
            string path = "Book.txt";
            string message;
            foreach (Book tr in books)
            {
                message = tr.Author + "|" + tr.Name  + "|" + tr.Datev + "|" + tr.Group + Environment.NewLine;
                File.AppendAllText(path, message);
            }
        }
    }
}
