using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FormInventory : Form
    {
        readonly InventorySystem invSys = new InventorySystem();

        public FormInventory()
        {
            InitializeComponent();
        }

        private void UpdateComboBoxes()
        {
            ComboBoxShopIdAdd.Items.Clear();
            ComboBoxShopIdView.Items.Clear();
            foreach(Shop shop in invSys.Shops)
            {
                ComboBoxShopIdAdd.Items.Add(shop.Id);
                ComboBoxShopIdView.Items.Add(shop.Id);
            }
            ComboBoxShopIdAdd.Sorted = true;
            ComboBoxShopIdView.Sorted = true;
        }

        private void ButtonAddShop_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(TextBoxShopId.Text);
                string name = TextBoxShopName.Text;
                string address = TextBoxShopAddress.Text;
                invSys.AddShop(id, name, address);
                UpdateComboBoxes();
            }
            catch (Exception excp) { MessageBox.Show(excp.Message); }

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int shopId = Int32.Parse(ComboBoxShopIdAdd.Text);
                int productId = Int32.Parse(TextBoxProductId.Text);
                string name = TextBoxProductName.Text;
                double price = Double.Parse(TextBoxPrice.Text);
                int qty = Int32.Parse(TextBoxQuantity.Text);
                invSys.AddProduct(shopId, productId, name, price, qty);
            }
            catch (Exception excp) { MessageBox.Show(excp.Message); }
        }

        private void ButtonShowProducts_Click(object sender, EventArgs e)
        {
            ListBoxInventory.Items.Clear();
            ListBoxInventory.Items.Add($"ID\tName\tPrice\tStock");
            try
            {
                int id = Int32.Parse(ComboBoxShopIdView.Text);
                Shop shop = invSys.FindShop(id);
                foreach (InventoryItem item in shop.Inventory)
                {
                    Product p = item.Product;
                    string row = $"{p.Id}\t{p.Name}\t{p.Price}\t{item.Stock}";
                    ListBoxInventory.Items.Add(row);
                }
            }
            catch (Exception excp) { MessageBox.Show(excp.Message); }
        }
    }
}
