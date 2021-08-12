using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    static class clsSearchLogic
    {
        private static DataSet ds;
        private static int iRet;
        private static clsDataAccess db = new clsDataAccess();
        private static List<Invoice> invList = new List<Invoice>();

        public static List<Invoice> ApplyFilters(string sSQL)
        {
            iRet = 0;

            ds = db.ExecuteSQLStatement(sSQL, ref iRet);

            for (int i = 0; i < iRet; i++)
            {
                invList.Add(new Invoice(ds.Tables[0].Rows[i]));
            }

            return invList;

        }
    }
}
