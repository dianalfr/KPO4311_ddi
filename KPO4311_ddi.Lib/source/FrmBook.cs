using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KPO4311.ddi.Lib.source
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
            _book = null;
        }
        private Book _book = null;

        public Book book
        {
            get { return _book; }
        }

        public void SetBook(Book book)
        {
            //инициализировать скрытое поля класса
            this._book = book;
            //присвоить значение данных сотрудника элементам редактирования
            this.txtboxNameBook.Text = _book.Name;
            this.txtBoxAuthorBook.Text = _book.Author;
            this.txtBoxDataVBook.Text = _book.Datev;
            this.txtBoxGroupBook.Text = _book.Group;
        }
 
        private void FrmBook_Load(object sender, EventArgs e)
        {

        }

        private void txtboxNameBook_TextChanged(object sender, EventArgs e)
        {

        }
    }
}