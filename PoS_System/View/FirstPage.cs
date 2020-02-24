using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoS_System.Model;
using PoS_System.Services;

namespace PoS_System.View
{
    public partial class FirstPage : Form
    {
        BrandService brandService = new BrandServiceImpl();
        CategoryService categoryService = new CategoryServiceImpl();
        ProductService productService = new ProductServiceImpl();

        public FirstPage()
        {
            InitializeComponent();
        }

        public void loadBrands() 
        {
            List<Brand> brands = brandService.loadBrands();
            foreach (Brand brand in brands) 
            {
                brandTable.Rows.Add(brand.Id, brand.Name);
            }
        }

        public void loadCategories() 
        {
            List<Category> categories = categoryService.getAllCategories();
            foreach (Category category in categories) 
            {
                categoryTable.Rows.Add(category.Id, category.Name);
            }
        }

        public void loadProducts() 
        {
            List<Product> products = productService.getAllProducts();
            foreach (Product product in products) 
            {
                productTable.Rows.Add(product.Id, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock, product.Barcode);
            }
        }
        

        private void profileIcon_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout confirmation", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                this.Dispose();
            }
        }

        private void manageBrandBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
     
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            loadBrands();
            loadCategories();
            loadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
