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
    public class BookListSplitFileLoader :ILoadBookListCommand
    {
        private List<Book> _bookL = null;

        public BookListSplitFileLoader(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        private readonly string dataFileName = "";
        private LoadStatus _status = LoadStatus.None;
        public List<Book> bookL
        {
            get { return _bookL; }
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
                if (!File.Exists("C:\\Users\\makbookair\\source\\repos\\KPO4311_ddi\\KPO4311_ddi.Main\\bin\\Debug\\Book.txt"))
                {
                    current = LoadStatus.FileNotExists;
                    throw new FileNotFoundException(@"[Book.txt not in the directory]");
                }
                if (dataFileName == null)
                {
                    current = LoadStatus.FileNotExists;
                    throw new FileNotFoundException(@"[name is empty]");
                }
                _bookL = new List<Book>();
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
                        _bookL.Add(book1);
                    }
                }
                current = LoadStatus.Success;
            }
        }
    }
