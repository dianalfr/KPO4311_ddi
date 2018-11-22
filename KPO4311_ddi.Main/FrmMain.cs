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
using KPO4311.ddi.Lib;
using KPO4311.ddi.Lib.source;


namespace KPO4311_ddi.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private List<Book> BookList = null;
        private BindingSource bsBooks = new BindingSource();
        string dataParam = AppGlobalSettings.Data;

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ILoadBookListCommand loader = new BookListSplitFileLoader(dataParam);
                loader.Execute();
                bsBooks.DataSource = loader.bookL;
                dgvMyBook.DataSource = loader.bookL;
                dgvMyBook.DataSource = bsBooks;
                /*//Вызов исключения "Метод не реализован"
                throw new NotImplementedException();
                //Вызов базового исключения
                throw new Exception("Неправильные входные параметры");*/

            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }

        private void mnOpenBook_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBook frmBook = new FrmBook();
                //Задать сылка на текущий объект в таблицы
                Book book = (bsBooks.Current as Book);
                frmBook.SetBook(book);
                //открыть форму в модальном режиме
                frmBook.ShowDialog();

                //Вызов исключения "Метод не реализован"
               // throw new NotImplementedException();
                 //Вызов базового исключения
                 //throw new Exception("Неправильные входные параметры");

            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }

        private void mmFile_Click(object sender, EventArgs e)
        {

        }

        private void dgvMockEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
