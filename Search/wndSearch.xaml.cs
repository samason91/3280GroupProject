using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _3280GroupProject
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        /// <summary>
        /// Stores the Invoice ID of the currently selected Invoice object
        /// </summary>
        private int currInvoice;

        public wndSearch()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // Will close the current search window
        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // Will pass the currInvoice local variable back to the main menu
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            // Clears the current filters, returning them all to default
        }

        private void DropBoxChange()
        {
            // When any dropbox filter is changed, this method will detect which filters are being used and send the
            //      appropriate SQL statement to the clsSearchLogic ApplyFilters method. The List that is returned
            //      from ApplyFilters will be used to populate the invoices DataGrid.
        }

    }
}
