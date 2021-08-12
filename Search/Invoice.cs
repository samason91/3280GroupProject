using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    class Invoice
    {
        private string invNum;
        private string invDate;
        private string totCost;


        public Invoice(DataRow dr)
        {
            // Set the invoice attributes according to the datarow given
            invNum = dr[0].ToString();
            invDate = dr[1].ToString();
            totCost = dr[2].ToString();
        }

    }
}
