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
    public partial class ManageCategory : Form
    {
        private CategoryService categoryService = new CategoryServiceImpl();

        private long id;
        private string name;

        private static ManageCategory manageCaetgory;

        public static ManageCategory createInstance() 
        {
            if (manageCaetgory == null) 
            {
                manageCaetgory = new ManageCategory();
            }
            return manageCaetgory;
        }
       
        public ManageCategory()
        {
            InitializeComponent();
        }
        public void loadCategories()
        {
            if (categoryTable.Rows.Count == 0)
            {
                List<Category> categories = categoryService.getAllCategories();
                foreach(Category category in categories)
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


        private void ManageCaetgory_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void categoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = categoryTable.SelectedRows[0];
            this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
            this.name = selectedRow.Cells[1].Value.ToString();
            nameBox.Text = this.name;
        }

        private void categoryTable_SelectionChanged(object sender, EventArgs e)
        {
            if (categoryTable.Focused) 
            {
                DataGridViewRow selectedRow = categoryTable.SelectedRows[0];
                this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
                this.name = selectedRow.Cells[1].Value.ToString();
                nameBox.Text = this.name;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                int status = categoryService.deleteCategory(id);
                if (status == -214)
                {
                    MessageBox.Show("You can't delete a row that is refrenced elsewhere.");
                }
                else
                {
                    MessageBox.Show("Categroy deleted.");
                    nameBox.Clear();
                    loadCategories();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            categoryService.addCategory(name);
            nameBox.Clear();
            loadCategories();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                this.name = nameBox.Text;
                categoryService.updateCategory(this.id, name);
                nameBox.Clear();
                loadCategories();
            }
        }
    }
}
