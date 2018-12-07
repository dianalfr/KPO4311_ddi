using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace KPO4311.ddi.Lib
{
    internal class BookListTestLoader : IBookListLoader
    {

        private readonly string dataFileName = "";
        private List<Book> _BookL = null;
        public BookListTestLoader()
        {
            this._BookL = new List<Book>(); ;
        }

        public List<Book> books
        {
            get { return _BookL; }
        }
        LoadStatus IBookListLoader.status => throw new NotImplementedException();

        public void Execute()
        {
            try
            {         
                {
                    Book book11 = new Book()
                    {
                        Author = "gg",
                        Name = "Не хочу взрослеть",
                        Datev = "17.06.2018",
                        Group = "комикс"
                    };
                    books.Add(book11);
                }
                {
                    Book book12 = new Book()
                    {
                        Author = "Кови",
                        Name = "Навыки",
                        Datev = "1.05.2016",
                        Group = "саморазвитие"
                    };
                    books.Add(book12);
                }
            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }
    }
}
