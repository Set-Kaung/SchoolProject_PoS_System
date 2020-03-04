using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoS_System.Services;
using PoS_System.Model;

namespace PoS_System.View
{
    public partial class ManageProduct : Form
    {
        private ProductService productService = new ProductServiceImpl();
        private static ManageProduct manageProduct;
        List<TextBox> textBoxes = new List<TextBox>();

        private long id;
        private string name;
        private string description;
        private long brandID;
        private long categoryID;
        private double price;
        private long stock;
        private long barcode;

        public static ManageProduct createInstance() 
        {
            if (manageProduct == null) 
            {
                manageProduct = new ManageProduct();
            }
            return manageProduct;
        }

        public void loadProducts()
        {
            if (productTable.Rows.Count == 0)
            {
                List<Product> products = productService.getAllProducts();
                foreach (Product product in products)
                {
                    productTable.Rows.Add(product.Id, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock, product.Barcode);
                }
            }
            else if (productTable.Rows.Count > 0)
            {
                productTable.Rows.Clear();
                List<Product> products = productService.getAllProducts();
                foreach (Product product in products)
                {
                    productTable.Rows.Add(product.Id, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock, product.Barcode);
                }
            }
        }

        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            loadProducts();
            textBoxes.Add(this.nameBox);
            textBoxes.Add(this.desBox);
            textBoxes.Add(this.brandIDBox);
            textBoxes.Add(this.categoryIDBox);
            textBoxes.Add(this.priceBox);
            textBoxes.Add(this.stockBox);
            textBoxes.Add(this.barcodeBox);
           

        }

        private void clearTextBoxes() 
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = productTable.SelectedRows[0];
            this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
            this.name = selectedRow.Cells[1].Value.ToString();
            this.description = selectedRow.Cells[2].Value.ToString();
            this.brandID = long.Parse(selectedRow.Cells[3].Value.ToString());
            this.categoryID = long.Parse(selectedRow.Cells[4].Value.ToString());
            this.price = double.Parse(selectedRow.Cells[5].Value.ToString());
            this.stock = long.Parse(selectedRow.Cells[6].Value.ToString());
            this.barcode = long.Parse(selectedRow.Cells[7].Value.ToString());

            nameBox.Text = this.name;
            desBox.Text = this.description;
            brandIDBox.Text = this.brandID.ToString();
            categoryIDBox.Text = this.categoryID.ToString();
            priceBox.Text = this.price.ToString();
            stockBox.Text = this.stock.ToString();
            barcodeBox.Text = this.barcode.ToString();

        }

        private void productTable_SelectionChanged(object sender, EventArgs e)
        {
            if (productTable.Focused) 
            {
                DataGridViewRow selectedRow = productTable.SelectedRows[0];
                this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
                this.name = selectedRow.Cells[1].Value.ToString();
                this.description = selectedRow.Cells[2].Value.ToString();
                this.brandID = long.Parse(selectedRow.Cells[3].Value.ToString());
                this.categoryID = long.Parse(selectedRow.Cells[4].Value.ToString());
                this.price = double.Parse(selectedRow.Cells[5].Value.ToString());
                this.stock = long.Parse(selectedRow.Cells[6].Value.ToString());
                this.barcode = long.Parse(selectedRow.Cells[7].Value.ToString());

                nameBox.Text = this.name;
                desBox.Text = this.description;
                brandIDBox.Text = this.brandID.ToString();
                categoryIDBox.Text = this.categoryID.ToString();
                priceBox.Text = this.price.ToString();
                stockBox.Text = this.stock.ToString();
                barcodeBox.Text = this.barcode.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            description = desBox.Text;
            brandID = long.Parse(brandIDBox.Text);
            categoryID = long.Parse(categoryIDBox.Text);
            price = double.Parse(priceBox.Text);
            stock = long.Parse(stockBox.Text);
            barcode = long.Parse(barcodeBox.Text);
            Product product = new Product(name, description, brandID, categoryID, price, stock, barcode);

            productService.addProduct(product);
            loadProducts();
            clearTextBoxes();
        }
    }
}
