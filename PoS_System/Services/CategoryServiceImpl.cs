using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;
using PoS_System.DAO;


namespace PoS_System.Services
{
    class CategoryServiceImpl : CategoryService
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public List<Category> getAllCategories() 
        {
            List<Category> categories = categoryDAO.getAllCategories();
            return categories;
        }

        public void addCategory(string name) 
        {
            categoryDAO.addCategory(name);
        }

        public void updateCategory(long id, string name) 
        {
            categoryDAO.updateCategory(id, name);
        }

        public int deleteCategory(long id) 
        {
            return categoryDAO.deleteCategory(id);
        }
    }
}
