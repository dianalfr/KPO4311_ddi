using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO4311.ddi.Lib
{
    internal class BookSplitFileFactory :IBookFactory
    {
        public IBookListLoader CreatedBookListLoader()
        {
            return new BookListSplitFileLoader(AppGlobalSettings.Data);
        }
        public IBookListSaver CreatedBookListSaver()
        {
            return new BookListSplitFileSaver(AppGlobalSettings.Data);
        }
    }
}
