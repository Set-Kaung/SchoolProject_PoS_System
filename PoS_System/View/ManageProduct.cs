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

        private long barcode;
        private string name;
        private string description;
        private long brandID;
        private long categoryID;
        private double price;
        private long stock;
        

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
                    productTable.Rows.Add(product.Barcode, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock);
                }
            }
            else if (productTable.Rows.Count > 0)
            {
                productTable.Rows.Clear();
                List<Product> products = productService.getAllProducts();
                foreach (Product product in products)
                {
                    productTable.Rows.Add(product.Barcode, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock);
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
            this.barcode = long.Parse(selectedRow.Cells[0].Value.ToString());
            this.name = selectedRow.Cells[1].Value.ToString();
            this.description = selectedRow.Cells[2].Value.ToString();
            this.brandID = long.Parse(selectedRow.Cells[3].Value.ToString());
            this.categoryID = long.Parse(selectedRow.Cells[4].Value.ToString());
            this.price = double.Parse(selectedRow.Cells[5].Value.ToString());
            this.stock = long.Parse(selectedRow.Cells[6].Value.ToString());
            

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
                this.barcode = long.Parse(selectedRow.Cells[0].Value.ToString());
                this.name = selectedRow.Cells[1].Value.ToString();
                this.description = selectedRow.Cells[2].Value.ToString();
                this.brandID = long.Parse(selectedRow.Cells[3].Value.ToString());
                this.categoryID = long.Parse(selectedRow.Cells[4].Value.ToString());
                this.price = double.Parse(selectedRow.Cells[5].Value.ToString());
                this.stock = long.Parse(selectedRow.Cells[6].Value.ToString());
                

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
            barcode = long.Parse(barcodeBox.Text);
            name = nameBox.Text;
            description = desBox.Text;
            brandID = long.Parse(brandIDBox.Text);
            categoryID = long.Parse(categoryIDBox.Text);
            price = double.Parse(priceBox.Text);
            stock = long.Parse(stockBox.Text);
            
            Product product = new Product(barcode,name, description, brandID, categoryID, price, stock);

            productService.addProduct(product);
            loadProducts();
            clearTextBoxes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (barcode == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                int status = productService.deleteProduct(barcode);
                if (status == -214)
                {
                    MessageBox.Show("You can't delete a row that is refrenced elsewhere.");
                }
                else
                {
                    MessageBox.Show("Product deleted.");
                    clearTextBoxes();
                    loadProducts();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.barcode == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else 
            {
                barcode = long.Parse(barcodeBox.Text);
                name = nameBox.Text;
                description = desBox.Text;
                brandID = long.Parse(brandIDBox.Text);
                categoryID = long.Parse(categoryIDBox.Text);
                price = double.Parse(priceBox.Text);
                stock = long.Parse(stockBox.Text);
                
                Product product = new Product(barcode, name, description, brandID, categoryID, price, stock);

                productService.updateProduct(product);
                loadProducts();
                clearTextBoxes();
            }
        }
    }
}
