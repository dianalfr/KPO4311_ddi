using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO4311.ddi.Lib
{
    public interface ILoadBookListCommand
    {
        LoadStatus status { get; }
        List<Book> bookL { get; }
        void Execute();
    }
}