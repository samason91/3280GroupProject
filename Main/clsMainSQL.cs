using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    static class clsMainSQL
    {
        public static string UpdateInvoiceData(string sInvoiceID, string sInvoiceTotal)
        {
            string sSQL = "UPDATE Invoices SET TotalCost = " + sInvoiceTotal + "WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        public static string DeleteLineItem(string sInvoiceID) //Needs LineItemID too?
        {
            string sSQL = "DELETE From LineItems WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        public static string DeleteInvoice(string sInvoiceID)
        {
            string sSQL = "DELETE From Invoices WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        public static string InsertLineItem(string sInvoiceID, string sLineItemID, string sItemCode)
        {
            string sSQL = "INSERT INTO LineItems (InvoiceNum, LineItemNum, ItemCode) Values (" + sInvoiceID + ", " + sLineItemID + ", '" + sItemCode + "')";
            return sSQL;
        }

        public static string InsertInvoice(string sInvoiceDate, string sTotalCost)
        {
            string sSQL = "INSERT INTO Invoices (InvoiceDate, TotalCost) Values ('#" + sInvoiceDate + "#', " + sTotalCost + ")";
            return sSQL;
        }

        public static string SelectInvoiceData(string sInvoiceID)
        {
            string sSQL = "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices WHERE InvoiceNum = " + sInvoiceID;
            return sSQL;
        }

        public static string SelectItemData() // This supposed to be based on ItemCode?
        {
            string sSQL = "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc"; //Where ItemCode = var?
            return sSQL;
        }

        public static string SelectItemInvoiceData(string sInvoiceID) // This supposed to be based on ItemCode?
        {
            string sSQL = "SELECT LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc Where LineItems.ItemCode = ItemDesc.ItemCode And LineItems.InvoiceNum = " + sInvoiceID;
            return sSQL;
        }
    }
}
