using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class MainWindow : Form
    {
        static BindingList<Product> products1 = new BindingList<Product>()
        {
            new Product() {Id = 1, Name = "Apple"},
            new Product() {Id = 2, Name = "Tomato"},
            new Product() {Id = 3, Name = "Juice"}
        };

        static BindingList<Product> products2 = new BindingList<Product>()
        {
            new Product() {Id = 4, Name = "Potato"},
            new Product() {Id = 5, Name = "Orange"},
            new Product() {Id = 6, Name = "Meat"}
        };

        BindingList<Shop> shops = new BindingList<Shop>()
        {
            new Shop()
            {
                Id = 1,
                Name="Diksi",
                Products= products1,
            },
            new Shop()
            {
                Id = 2,
                Name="Paterka",
                Products= products2,
            }
        };



        public MainWindow()
        {
            InitializeComponent();
            ShopsListBox.DataSource = shops;
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedShop = shops.Where(x => x.Id == ((Shop)ShopsListBox.SelectedItem).Id).FirstOrDefault();
            if (selectedShop != null)
            {
                ProductsListBox.DataSource = selectedShop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "Id";
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
            shops.Add(new Shop() { Name = shopName, Id = shopId, Products = new BindingList<Product>() });
            NameShopTextBox.Text = "";
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            var ProductName = NameProductTextBox.Text;
            var ProductId = shops.Sum(x => x.Products.Count()) + 1;
            ((Shop)ShopsListBox.SelectedItem).Products.Add(new Product {Name = ProductName, Id = ProductId });
            NameProductTextBox.Text = "";
        }
    }

    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BindingList<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
