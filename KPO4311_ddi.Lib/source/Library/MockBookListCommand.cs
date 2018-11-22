﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace KPO4311.ddi.Lib
{
    public class MockBookListCommand 
    {
        public MockBookListCommand()
        {
            this._BookList = null;
        }
        private readonly string _dataFileName = "";
        private List<Book>_BookList = null;

        public List<Book> books
        {
            get { return _BookList; }
        }
        //LoadStatus ILoadBookListCommand.status => throw new NotImplementedException();

        public void Execute()
        {
            try
            {
                //Фигурная скобка для ограничения области видимости переменной employee            
                {
                    Book book = new Book()
                    {
                        Author = "",
                        Name = "Не хочу взрослеть",
                        Datev = "17.06.2018",
                        Group = "комикс"
                    };
                    books.Add(book);
                }
                {
                    Book book = new Book()
                    {
                        Author = "Кови",
                        Name = "Навыки",
                        Datev = "1.05.2016",
                        Group = "саморазвитие"
                    };
                    books.Add(book);
                }
            }
            catch (NotImplementedException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }
    }
}
