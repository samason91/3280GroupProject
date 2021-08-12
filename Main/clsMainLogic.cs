using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    static class clsMainLogic
    {
        private static clsDataAccess clsData = new clsDataAccess();
        public static string sInvoiceID { get; set; }
        public static string sInvoiceDate { get; set; }

        //Get list of items associated with invoice
        private static List<clsItem> lInvoiceItemList;
        private static string sTotalCost;

        // Data passed in from xaml
        //public void SaveInvoice(string )

        //Save invoice data
        public static void SaveInvoiceToDatabase(string InvoiceDate, string TotalCost) 
        {
            clsMainSQL.InsertInvoice(InvoiceDate, TotalCost);
        }
        
        public static void UpdateInvoiceInDatabase()
        {


        }

        //Delete invoice data
        public static void DeleteInvoiceFromDatabase() 
        {
            clsMainSQL.DeleteInvoice(sInvoiceID);
        }

        public static List<clsItem> GetItems(string invoiceID)
        {
            try
            {
                int iRows = 0;
                DataSet ds;
                List<clsItem> lstItems = new List<clsItem>();
                clsData = new clsDataAccess();
        
                ds = clsData.ExecuteSQLStatement(clsMainSQL.SelectItemInvoiceData(invoiceID), ref iRows);
        
                for (int i = 0; i < iRows; i++)
                {
                    lstItems.Add(new clsItem(ds.Tables[0].Rows[i])); //TODO: Items constructor
                }
        
                return lstItems;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
