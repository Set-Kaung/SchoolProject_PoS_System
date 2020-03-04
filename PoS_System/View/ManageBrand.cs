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
    public partial class ManageBrand : Form
    {
        BrandService brandService = new BrandServiceImpl();
        private static ManageBrand manageBrand;
        private long id;
        private string name;


        public ManageBrand()
        {
            InitializeComponent();

        }
        public static ManageBrand createInstance() 
        {
            if (manageBrand == null) 
            {
                manageBrand = new ManageBrand();
            }
            return manageBrand;
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
            else if(brandTable.Rows.Count > 0)
            {
                brandTable.Rows.Clear();
                List<Brand> brands = brandService.getAllBrands();
                foreach (Brand brand in brands)
                {
                    brandTable.Rows.Add(brand.Id, brand.Name);
                }
            }
        }
            


        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            brandService.addBrand(name);
            nameBox.Clear();
            loadBrands();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ManageBrand_Load(object sender, EventArgs e)
        {
            loadBrands();
        }

        

        private void brandTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = brandTable.SelectedRows[0];
            this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
            this.name = selectedRow.Cells[1].Value.ToString();
            nameBox.Text = this.name;

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id == null) 
            {
                MessageBox.Show("Please select a row.");
            }
            else 
            {
                int status = brandService.deleteBrand(id);
                if (status == -214)
                {
                    MessageBox.Show("You can't delete a row that is refrenced elsewhere.");
                }
                else 
                {
                    MessageBox.Show("Brand deleted.");
                    nameBox.Clear();
                    loadBrands();
                }
            }
        }

        private void brandTable_Click(object sender, EventArgs e)
        {

        }

        private void brandTable_SelectionChanged(object sender, EventArgs e)
        {
            if (brandTable.Focused)
            {
                DataGridViewRow selectedRow = brandTable.SelectedRows[0];
                this.id = long.Parse(selectedRow.Cells[0].Value.ToString());
                this.name = selectedRow.Cells[1].Value.ToString();
                nameBox.Text = this.name;
            }

        }
    }   
}

