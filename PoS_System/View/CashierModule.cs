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
    public partial class CashierModule : Form
    {
        ProductService productService = new ProductServiceImpl();
        List<Product> products = new List<Product>();
        private Product product;


        public CashierModule()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearTextBoxes() 
        {
            this.barcodeBox.Clear();
            this.nameBox.Clear();
            this.priceBox.Clear();
            this.amountBox.Clear();
           
        }

        private void CashierModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void addRow(Product product) 
        {
            long amount;

            if (long.TryParse(amountBox.Text, out amount))
            {
                    double total = amount * this.product.Price;
                    if (amount > product.Stock)
                    {
                        MessageBox.Show("Not enough stock in storage for this item.\nYour amount: " + amount + "\nIn storage: " + product.Stock);
                    }
                    else
                    {
                        productTable.Rows.Add(product.Barcode, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, amount, total);
                        clearTextBoxes();
                    }
                
            }
            else 
            {
                MessageBox.Show("Amount must be in numbers.");
            }
            
        }

        private void barcodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                long barcode;
                if (long.TryParse(barcodeBox.Text.ToString(), out barcode))
                {
                    Boolean found = searchProductByBarcode(barcode);
                    if (!found)
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter barcode in number only.");
                }
            }
        }

        private Boolean searchProductByBarcode(long barcode)
        {
            Boolean found = false;
            foreach (Product product in products)
            {
                if (barcode == product.Barcode)
                {
                    nameBox.Text = product.Name;
                    priceBox.Text = product.Price.ToString();
                    this.product = product;
                    found = true;
                    return found;
                    break;
                }

            }
            return found;
        }

        private Boolean searchProductByName(string name) 
        {
            Boolean found = false;
            foreach (Product product in products) 
            {
                if (product.Name.ToUpper().Contains(name.ToUpper())) 
                {
                    nameBox.Text = product.Name;
                    barcodeBox.Text = product.Barcode.ToString();
                    priceBox.Text = product.Price.ToString();
                    this.product = product;
                    found = true;
                    return found;
                    break;
                }
            }
            return found;
        }

        private void CashierModule_Load(object sender, EventArgs e)
        {
            products = productService.getAllProducts();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addRow(this.product);
        }

        private void barcodeLbl_Click(object sender, EventArgs e)
        {

        }

        private void serchBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals(""))
            {
                long barcode;
                if (long.TryParse(barcodeBox.Text.ToString(), out barcode))
                {
                    Boolean found = searchProductByBarcode(barcode);
                    if (!found)
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter barcode in number only.");
                }
            }
            else if (barcodeBox.Text.Equals(""))
            {
                Boolean found = searchProductByName(nameBox.Text);
                if (!found)
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else 
            {
                Boolean found = searchProductByName(nameBox.Text);
                if (!found)
                {
                    MessageBox.Show("Product not found.");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Boolean found = searchProductByName(nameBox.Text);
                if (!found)
                {
                    MessageBox.Show("Product not found.");
                }
            }
            
        }
    }
}
