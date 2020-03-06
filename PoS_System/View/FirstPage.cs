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

        private List<Product> products;
        
        
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
                this.products = productService.getAllProducts();
                foreach (Product product in products)
                {
                    productTable.Rows.Add(product.Barcode, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock);
                }
            }
            else if (productTable.Rows.Count > 0)
            {
                productTable.Rows.Clear();
                this.products = productService.getAllProducts();
                foreach (Product product in products)
                {
                    productTable.Rows.Add(product.Barcode, product.Name, product.Description, product.BrandID, product.CategoryID, product.Price, product.Stock, product.Barcode);
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

        

        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            DataGridViewRow foundRow = new DataGridViewRow();
            long element;
            if (long.TryParse(searchBox.Text, out element))
            {
                
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                for (int i = 0; i < productTable.Rows.Count; i++)
                {
                    rows.Add(productTable.Rows.SharedRow(i));
                }

                foreach (DataGridViewRow row in rows)
                {
                    long barcode = long.Parse(row.Cells[7].Value.ToString());
                    if (element == barcode)
                    {
                        found = true;
                        foundRow = row;
                    }
                    
                }
                if (found)
                {
                    productTable.Rows.Clear();
                    productTable.Rows.Add(foundRow);
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else 
            {
                MessageBox.Show("Please enter a number.");
                
            }
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
    
}
