using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.IO.FileStream;

namespace KPO4311.ddi.Lib
{
    public static class SaveClassException
    {
        static FileStream fstream;
        public static void ErrorLog(string message)
        {
            try
            {
                fstream = new FileStream(@"C:\Users\makbookair\source\repos\KPO4311_ddi\KPO4311_ddi.Main\bin\Debug\errorlog.txt", FileMode.OpenOrCreate);
                byte[] sendData = Encoding.UTF8.GetBytes("[" + Convert.ToString(DateTime.Now) + "]" + message + Environment.NewLine);
                fstream.Write(sendData, 0, sendData.Length);
                fstream.Close();
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
            }
        }
        public static void ErrorLog(Exception ex)
        {
            try
            {
                fstream = new FileStream(@"C:\Users\makbookair\source\repos\KPO4311_ddi\KPO4311_ddi.Main\bin\Debug\errorlog.txt", FileMode.OpenOrCreate);
                byte[] sendData = Encoding.UTF8.GetBytes("[" + Convert.ToString(DateTime.Now) + "]" + ex.Message + Environment.NewLine);
                fstream.Write(sendData, 0, sendData.Length);
                fstream.Close();
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
            }
        }
    }
}
