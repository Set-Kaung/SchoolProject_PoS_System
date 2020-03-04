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
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
