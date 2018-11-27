using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPO4311.ddi.Lib
{
    internal class BookListSplitFileSaver :IBookListSaver
    {
        private List<Book> _books = null;
        public BookListSplitFileSaver(string DataFileName)
        {
            dataFileName = DataFileName;
        }
        private readonly string dataFileName = "";
        private LoadStatus _status = LoadStatus.None;
        public List<Book> books
        {
            get { return _books; }
            set
            {
                _books = value;
            }
        }
        public LoadStatus status
        {
            get
            {
                return _status;
            }
        }
        public void Execute()
        {
            LoadStatus current = LoadStatus.None;
            if (!File.Exists(dataFileName))
            {
                current = LoadStatus.FileNotExists;
                throw new FileNotFoundException(@"Book.txt not in the directory");
            }
            if (dataFileName == null)
            {
                current = LoadStatus.FileNotExists;
                throw new FileNotFoundException(@"Name is empty");
            }
            if (books == null)
            {
                current = LoadStatus.GeneralError;
                throw new FileNotFoundException(@"list Book is empty");
            }
            else
            {
                string message;
                foreach (Book tr in books)
                {
                    message = tr.Author + "|" + tr.Name + "|" + tr.Datev + "|" + tr.Group +  Environment.NewLine;
                    File.AppendAllText(dataFileName, message);
                }
                current = LoadStatus.Success;
            }
        }
    }
}
