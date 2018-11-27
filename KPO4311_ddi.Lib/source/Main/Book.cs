using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPO4311.ddi.Lib
{
    public class Book
    {
        public Book()
        {
            Author = "";
            Name = "";
            Datev = "";
            Group = "";
        }

        public string Author { get; set; }
        public string Name { get; set; }
        public string Datev { get; set; }
        public string Group { get; set; }
    }
}
