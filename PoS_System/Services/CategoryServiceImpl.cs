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
    }
}
