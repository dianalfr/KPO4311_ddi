﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO4311.ddi.Lib
{
    public interface IBookListLoader
    {
        LoadStatus status { get; }
        List<Book> books { get; }
        void Execute();
    }
}