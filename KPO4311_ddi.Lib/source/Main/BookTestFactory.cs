using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO4311.ddi.Lib
{
    internal class BookTestFactory : IBookFactory
    {
        public IBookListLoader CreatedBookListLoader()
        {
            return new BookListTestLoader();
        }
        public IBookListSaver CreatedBookListSaver()
        {
            return new BookListTestSaver();
        }
    }
}
