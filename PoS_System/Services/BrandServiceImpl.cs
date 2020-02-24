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
        private BrandDAO dao = new BrandDAO();
        public List<Brand> loadBrands()
        {
            List<Brand> brands = new List<Brand>();
            brands = dao.getAllBrands();
            return brands;

        }
    }
}
