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


namespace KPO4311_ddi.Main
{
    public partial class FrmMain : Form
    {
        private List<Book> bk = null;
        private BindingSource bsBooks = new BindingSource();
        string dataParam = AppGlobalSettings.Data;
        IBookFactory factory = null;

        public FrmMain()
        {
            InitializeComponent();
            factory = AppGlobalSettings.BookFactory;
            System.Diagnostics.Debug.Assert(factory != null, "Factory Null");
            if (factory == null)
            {
                Environment.Exit(0);
            }
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                throw new MyException("Тест 1 не пройден!");
               /* IBookListLoader loader = factory.CreatedBookListLoader();
                loader.Execute();

                bk = loader.books;
                bsBooks.DataSource = bk;
                dgvMyBook.DataSource = bsBooks;
                mnOpenBook.Visible = true;*/
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
                SaveClassException.ErrorLog(ex);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex);
            }
        }

        private void mnOpenBook_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBook frmBook = new FrmBook();
                Book book = (bsBooks.Current as Book);
                frmBook.SetBook(book);
                frmBook.ShowDialog();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
                SaveClassException.ErrorLog(ex);
            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog(ex);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
                LogUtility.ErrorLog(ex);
            }
        }

        private void nmSave_Click_Click(object sender, EventArgs e)
        {
            try
            {
                IBookListSaver listSaver = factory.CreatedBookListSaver();
                listSaver.books = bk;
                listSaver.Execute();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex);
            }
        }
        private void mmFile_Click(object sender, EventArgs e)
        {

        }

        private void dgvMockEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mnOpenBook.Visible = false;
        }
    }
}
