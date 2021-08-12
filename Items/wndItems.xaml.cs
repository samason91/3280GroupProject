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
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        /// <summary>
        /// Construction for hte wndItems window
        /// </summary>
        public wndItems()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to add items to the list of items within the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddItem_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Button to edit highlighted item within database with new values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Button to delete highlighted item from within the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelItem_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Button to cancel out of window and pass back to main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
