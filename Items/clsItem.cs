using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3280GroupProject
{
    /// <summary>
    /// We decided to make things more efficient to add a stand alone Item class to house database-passed info.
    /// We don't necessarily need this in it's own class, we can keep it strict in the clsItemsLogic if needed.
    /// </summary>
    class clsItem
    {
        /// <summary>
        /// Value passed in from database to be set as itemCode
        /// </summary>
        private string itemCode { get; set; }

        /// <summary>
        /// Value passed in from database that will house description of an Item
        /// </summary>
        private string itemDesc { get; set; }

        /// <summary>
        /// Cost for a particular item to be populated from database
        /// </summary>
        public string cost; //{ public get; private set; }
    }
}
