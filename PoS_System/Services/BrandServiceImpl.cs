using PoS_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.DAO;


namespace PoS_System.Services
{
    class BrandServiceImpl : BrandService
    {
        private BrandDAO brandDAO = new BrandDAO();
        public List<Brand> getAllBrands()
        {
            List<Brand> brands = new List<Brand>();
            brands = brandDAO.getAllBrands();
            return brands;

        }

        public void addBrand(string name) 
        {
            brandDAO.addBrand(name);   
        }

        public void updateBrand(long id,string name) 
        {
            brandDAO.updateBrand(id,name);
        }

        public int deleteBrand(long id) 
        {
            return brandDAO.deleteBrand(id);
        }
    }
}
