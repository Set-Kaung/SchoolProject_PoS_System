using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoS_System.View;
using PoS_System.Model;
using PoS_System.DAO;

namespace PoS_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstPage());

            /* BrandDAO brandDAO = new BrandDAO();
             List<Brand> brands = brandDAO.GetBrands();
             Console.WriteLine(brands.Count.ToString());*/

        }
    }
}
