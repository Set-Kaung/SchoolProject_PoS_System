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
            if (brandTable.Rows.Count == 0)
            {
                List<Brand> brands = brandService.getAllBrands();
                foreach (Brand brand in brands)
                {
                    brandTable.Rows.Add(brand.Id, brand.Name);
                }
            }
            else if (brandTable.Rows.Count > 0)
            {
                brandTable.Rows.Clear();
                List<Brand> brands = brandService.getAllBrands();
                foreach (Brand brand in brands)
                {
                    brandTable.Rows.Add(brand.Id, brand.Name);
                }
            }
        }

        public void loadCategories()
        {
            if (categoryTable.Rows.Count == 0)
            {
                List<Category> categories = categoryService.getAllCategories();
                foreach (Category category in categories)
                {
                    categoryTable.Rows.Add(category.Id, category.Name);
                }
            }
            else if (categoryTable.Rows.Count > 0)
            {
                categoryTable.Rows.Clear();
                List<Category> categories = categoryService.getAllCategories();
                foreach (Category category in categories)
                {
                    categoryTable.Rows.Add(category.Id, category.Name);
                }
            }
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




        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout confirmation", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                this.Dispose();
            }
        }

       

       

        private void FirstPage_Load(object sender, EventArgs e)
        {
            loadBrands();
            loadCategories();
            loadProducts();
        }

        private void manageBrandBtn_Click(object sender, EventArgs e)
        {
            ManageBrand manageBrand = ManageBrand.createInstance();
            manageBrand.ShowDialog();
            if (manageBrand.Focused == false) 
            {
                this.Focus();
                loadBrands();
            }
            
            
        }

        private void brandTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = ManageCategory.createInstance();
            manageCategory.ShowDialog();
            if (manageCategory.Focused == false) 
            {
                this.Focus();
                loadCategories();
            }
        }

        private void manageProductBtn_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = ManageProduct.createInstance();
            manageProduct.ShowDialog();
            if (manageProduct.Focused == false) 
            {
                this.Focus();
                loadProducts();
            }
        }
    }
    
}
