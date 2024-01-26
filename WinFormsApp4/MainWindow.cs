using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.Models;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class MainWindow : Form
    {
        private readonly IShopRepository _shopRepository;
        private List<Shop> shops;
        public MainWindow(IShopRepository shopRepository)
        {
            InitializeComponent();
            _shopRepository = shopRepository;
            shops = shopRepository.GetShops();
            ShopsListBox.DataSource = shops;    
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "ShopId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedShop = shops.Where(x => x.ShopId == ((Shop)ShopsListBox.SelectedItem).ShopId).FirstOrDefault();
            if (selectedShop != null)
            {
                ProductsListBox.DataSource = selectedShop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "ProductId";
            }

        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Something
        }

        private void CreateShopButton_Click(object sender, EventArgs e)
        {
            var shopName = NameShopTextBox.Text;
            var shopId = shops.Count() + 1;
            shops.Add(new Shop() { Name = shopName, ShopId = shopId});
            NameShopTextBox.Text = "";
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            var ProductName = NameProductTextBox.Text;
            var ProductId = shops.Sum(x => x.Products.Count()) + 1;
            ((Shop)ShopsListBox.SelectedItem).Products.Add(new Product {Name = ProductName, ProductId = ProductId });
            NameProductTextBox.Text = "";
        }
    }
}
