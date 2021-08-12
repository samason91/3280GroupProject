using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace _3280GroupProject
{
    /// <summary>
    /// Class to utilize the database in filing lists of Items
    /// </summary>
    static class clsItemsLogic
    {
        private static DataSet ds;

        private static int iRet;

        private static clsDataAccess db = new clsDataAccess();

        //List of items to be available via drop down and selection
        public static List<clsItem> myItems {get; set;}

        //This is the global list that everyone of us can see
        public static List<clsItem> currItems;

        //No constructor due to static nature...

        /// <summary>
        /// This method will fill up the list object with Items from database
        /// </summary>
        /// <returns>List of objects that will be then passed to other classes </returns>
        public static List<clsItem> BuildList()
        {
            ds = db.ExecuteSQLStatement(clsItemsSQL.GetItems(), ref iRet);

            for(int i = 0; i < iRet; i++)
            {
                //Will be filled later with fully defined clsItem objects
                //myItems.Add(clsItem);
            }

            return myItems;
        }
    }
}