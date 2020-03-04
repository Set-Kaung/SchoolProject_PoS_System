using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;
using PoS_System.DAO;

namespace PoS_System.Services
{
    class ProductServiceImpl : ProductService
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> getAllProducts() 
        {
            List<Product> products = productDAO.getAllProducts();
            return products;
        }
        public void addProduct(Product product) 
        {
            productDAO.addProduct(product);
        }

        public int deleteProduct(long id) 
        {
            return productDAO.deleteProduct(id);
        }

        public void updateProduct(Product product) 
        {
            productDAO.updateProduct(product);
        }
    }
}
