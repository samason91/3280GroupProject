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
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        wndSearch wndSearch;
        wndItems wndItems;
        bool editing = false;
        bool newInvoice = false;
        int totalCost = 0;
        int currCost = 0;
        clsItem currItem = new clsItem();

        //Item.clsItemsLogic clsItems;

        public wndMain()
        {
            InitializeComponent();
            cmbbxItemDropdown.ItemsSource = clsItemsLogic.BuildList();
            getCurrentInvoiceItems();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Implement SAVE functionality: send info to clsMainLogic
            //Error check: Fields filled, etc.
            if (newInvoice)
            {
                clsMainLogic.SaveInvoiceToDatabase(txtbxInvoiceDate.Text, lblTotalCost.Content.ToString());
                newInvoice = false;
            }
            else
            {
                clsMainLogic.UpdateInvoiceInDatabase();
            }
            editing = false;
        }

        private void btnDeleteInvoice_Click(object sender, RoutedEventArgs e)
        {
            //Implement DELETE functionality: Send info to clsMainLogic for deletion
            clsMainLogic.DeleteInvoiceFromDatabase();
            editing = false;
        }

        private void btnNewInvoice_Click(object sender, RoutedEventArgs e)
        {
            //Implement NEW functionality: clear fields, TBD in Invoice num
            ClearInvoiceFields();
            txtbxInvoiceNum.Text = "TBD";
            editing = true;
            newInvoice = true;

        }

        private void ClearInvoiceFields()
        {
            txtbxInvoiceNum.Text = "";
            txtbxInvoiceDate.Text = "";
            txtbxItemCost.Text = "";
            cmbbxItemDropdown.SelectedItem = null;
            dgrdItemsList.ItemsSource = null;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Implement ADD functionality: Adds item to dgrdItemsList, update lblTotalCost
            if (editing && cmbbxItemDropdown.SelectedItem != null)
            {
                dgrdItemsList.Items.Add(cmbbxItemDropdown.SelectedItem);
                totalCost += currCost;
                lblTotalCost.Content = totalCost.ToString();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Implement DELETE functionality: Removes item from dgrdItemsList
            if (editing && cmbbxItemDropdown.SelectedItem != null)
            {
                dgrdItemsList.Items.Remove(cmbbxItemDropdown.SelectedItem);
                totalCost -= currCost;
                lblTotalCost.Content = totalCost.ToString();
            }
        }

        private void mbtnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Implement SEARCH functionality: Opens search window
            //Refresh on return from search
            if (!editing)
            {
                wndSearch = new wndSearch();
                wndSearch.ShowDialog();
                SetInvoiceFields();
            }
        }

        private void SetInvoiceFields()
        {
            txtbxInvoiceNum.Text = clsMainLogic.sInvoiceID;
            txtbxInvoiceDate.Text = clsMainLogic.sInvoiceDate;
            txtbxItemCost.Text = "";
            cmbbxItemDropdown.SelectedItem = null;
            getCurrentInvoiceItems();
            txtbxInvoiceDate.IsEnabled = false;
        }

        private void mbtnItems_Click(object sender, RoutedEventArgs e)
        {
            //Implement ITEMS functionality: Opens Items window

            wndItems = new wndItems();
            wndItems.ShowDialog();

            //On return, refresh combo boxes
            cmbbxItemDropdown.ItemsSource = clsItemsLogic.currItems;
        }

        private void cmbbxItemDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //set selection to object
            ////Set cost based on cost component of object
            //
            currItem = (clsItem)cmbbxItemDropdown.SelectedItem;
            Int32.TryParse(currItem.cost, out currCost);
            lblItemCost.Content = currCost.ToString();
        }

        private void getCurrentInvoiceItems()//Needed?
        {
            //clsItems = new Items
            //cmbbxItemDropdown.ItemsSource = Items.ItemsList
            cmbbxItemDropdown.ItemsSource = clsItemsLogic.currItems;

        }

        private void btnEditInvoice_Click(object sender, RoutedEventArgs e)
        {
            //Set fields to not read only
            editing = true;
            txtbxInvoiceDate.IsEnabled = true;
        }
    }
}
