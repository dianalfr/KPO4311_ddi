using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPO4311.ddi.Lib
{

        public enum LoadStatus
        {
            None = 0,
            Success = 1,
            FileNameIsEmpty = -1,
            FileNotExists = -2,
            GeneralError = -100
        }
    public class BookListSplitFileLoader : IBookListLoader
    {
        private List<Book> _books = null;

        public BookListSplitFileLoader(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        private string dataFileName = "";
        private LoadStatus _status = LoadStatus.None;
        public List<Book> books
        {
            get { return _books; }
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
                throw new FileNotFoundException(@"[Book.txt not in the directory]");
            }
            if (dataFileName == null)
            {
                current = LoadStatus.FileNotExists;
                throw new FileNotFoundException(@"[name is empty]");
            }
            var fi = new FileInfo(dataFileName);
            /* if (fi.Length == 0)
             {
                 current = LoadStatus.GeneralError;
                 throw new FileNotFoundException(@"File is empty");
             }*/
            if (fi.Length == 0)
            {
                current = LoadStatus.GeneralError;
                throw new MyException(@"Тест №1 не пройден");
            }
            else
            {
                _books = new List<Book>();
                StreamReader sr = null;
                using (sr = new StreamReader(dataFileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        string[] arr = str.Split('|');
                        Book book1 = new Book()
                        {
                            Author = arr[0],
                            Name = arr[1],
                            Datev = arr[2],
                            Group = arr[3]
                        };
                        _books.Add(book1);
                    }
                }
                current = LoadStatus.Success;
            }
            }
        }
    }
