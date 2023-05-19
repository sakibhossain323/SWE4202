using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly List <Shop> _shops = new List <Shop> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateComboBoxes()
        {
            int id = _shops.Last().Id;
            comboBoxShopId.Items.Add(id);
            comboBoxShopId.Sorted = true;

            comboBoxShopIdShow.Items.Add(id);
            comboBoxShopIdShow.Sorted = true;
        }

        private Shop FindShop(int shopId)
        {
            Shop curShop = null;
            foreach (Shop shop in _shops)
            {
                if (shop.Id == shopId)
                {
                    curShop = shop;
                    break;
                }
            }

            return curShop;
        }

        private bool AddNewShop(int id, string name, string address)
        {
            Shop curShop = FindShop(id);

            if (curShop != null) return false;

            Shop newshop = new Shop(id, name, address);
            _shops.Add(newshop);
            UpdateComboBoxes();
            return true;
        }

        private bool AddProduct(int productId, string name, double price, int quantity, int shopId)
        {
            Shop curShop = FindShop(shopId);

            if (curShop == null) return false;

            if (curShop.IsNewProduct(productId))
            {
                Product temp = new Product(productId, name, price, quantity);
                curShop.AddProduct(temp);

            }
            else
            {
                foreach (Product product in curShop.ProductList)
                {
                    if (product.Id == productId)
                    {
                        product.IncreaseQuantity(quantity);
                    }
                }
            }

            return true;
        }

        private void ShowProduct(List<Product> products)
        {
            listBoxProducts.Items.Clear();
            string heading = "ID\tProduct\tPrice\tQuantity";
            listBoxProducts.Items.Add(heading);

            foreach (Product product in products)
            {
                int id = product.Id;
                string name = product.Name;
                double price = product.Price;
                int quantity = product.Quantity;

                string detail = $"{id}\t{name}\t{price}\t{quantity}";
                listBoxProducts.Items.Add(detail);
            }
        }


        private void ButtonAddShop_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxShopId.Text);
            string name = textBoxShopName.Text;
            string address = textBoxShopAddress.Text;
            
            bool added = AddNewShop(id, name, address);
            if (!added) 
            {
                MessageBox.Show("Shop Already Exists! Provide unique shop id");
            }

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(textBoxProductId.Text);
            string productName = textBoxProductName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            int shopId = Convert.ToInt32(comboBoxShopId.Text);

            bool added = AddProduct(productId, productName, price, quantity, shopId);
            if (!added)
            {
                MessageBox.Show("Shop Doesn't Exist!");
            }
        }

        private void ButtonShowProducts_Click(object sender, EventArgs e)
        {
            int shopId = Convert.ToInt32(comboBoxShopIdShow.Text);
            Shop curshop = FindShop(shopId);

            if (curshop == null) MessageBox.Show("Shop Doesn't Exist!");
            else ShowProduct(curshop.ProductList);
        }
    }
}
