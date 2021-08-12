using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    static class clsSearchSQL
    {
        public static string GetInvoices()
        {
            string sSQL = "SELECT * FROM Invoices";
            return sSQL;
        }

        public static string GetInvoicesByNum(string invNum)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = '" + invNum + "'";
            return sSQL;
        }

        public static string GetInvoicesByNumDate(string invNum, string invDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = '" + invNum + "' AND InvoiceDate = #" + invDate + "#";
            return sSQL;
        }

        public static string GetInvoicesByNumDateCost(string invNum, string invDate, string totCost)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = '" + invNum + "' AND InvoiceDate = #" + invDate + "# AND TotalCost = " + totCost;
            return sSQL;
        }

        public static string GetInvoicesByCost(string totCost)
        {
            string sSQL = "SELECT * FROM Invoices WHERE TotalCost = '" + totCost + "'";
            return sSQL;
        }

        public static string GetInvoicesByCostDate(string totCost, string invDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE TotalCost = '" + totCost + "' and InvoiceDate = #" +invDate + "#";
            return sSQL;
        }

        public static string GetInvoicesByDate(string invDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + invDate + "#";
            return sSQL;
        }

        
        
        
        
        

    }
}
