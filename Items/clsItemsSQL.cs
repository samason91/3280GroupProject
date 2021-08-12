using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    static class clsItemsSQL
    {
        public static string GetItems()
        {
            string sSQL = "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
            return sSQL;
        }

        public static string GetInvoiceNum(string itemCode)
        {
            string sSQL = "SELECT DISTINCT(InvoiceNum) FROM LineItems WHERE ItemCode = '" + itemCode + "'";
            return sSQL;
        }

        public static string UpdateItemDescription(string itemDesc, string cost, string itemCode)
        {
            string sSQL = "UPDATE ItemDesc SET ItemDesc = '" + itemDesc + "', COST = " + cost + " WHERE ItemCode = '" + itemCode + "'";
            return sSQL;
        }

        public static string AddItems(string itemCode, string ItemDesc, string cost)
        {
            string sSQL = "INSERT INTO ItemDesc (ItemCode, ItemDesc, Cost) VALUES ('"+itemCode+"','"+ItemDesc+"','"+cost+"')";
            return sSQL;
        }

        public static string DeleteItems(string itemCode)
        {
            string sSQL = "DELETE FROM ItemDesc WHERE ItemCode = '"+itemCode+"'";
            return sSQL;
        }
    }
}
