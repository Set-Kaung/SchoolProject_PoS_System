﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.DAO;
using PoS_System.Model;

namespace PoS_System.Services
{
    interface ProductService
    {
        List<Product> getAllProducts();   
    }
}
