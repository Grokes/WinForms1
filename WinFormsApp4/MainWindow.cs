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
            shops = _shopRepository.GetShops();
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
            if (selectedShop != null && selectedShop.Products[0] != null)
            {
                ProductsListBox.DataSource = selectedShop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "ProductId";
            }
            else
            {
                ProductsListBox.DataSource = new List<Product>();
            }

        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Something
        }

        private void CreateShopButton_Click(object sender, EventArgs e)
        {
            var shopName = NameShopTextBox.Text;
            _shopRepository.Create(new Shop { Name = shopName });
            NameShopTextBox.Text = "";
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            var ProductName = NameProductTextBox.Text;
            var selectedShop = shops.Where(x => x.ShopId == ((Shop)ShopsListBox.SelectedItem).ShopId).FirstOrDefault();
            if (selectedShop != null)
            {
                _shopRepository.CreateProduct(selectedShop, new Product { Name = ProductName });
                shops = _shopRepository.GetShops();
                ShopsListBox.DataSource = shops;
                NameProductTextBox.Text = "";
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            var selectedShop = shops.Where(x => x.ShopId == ((Shop)ShopsListBox.SelectedItem).ShopId).FirstOrDefault();
            var selectedProduct = selectedShop.Products.Where(x => x.ProductId == ((Product)ProductsListBox.SelectedItem).ProductId).FirstOrDefault();
            _shopRepository.RemoveProduct(selectedShop, selectedProduct);
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
        }
    }
}
