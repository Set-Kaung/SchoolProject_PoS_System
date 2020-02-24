using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_System.Model
{
    class Product
    {
        private long id;
        private string name;
        private string description;
        private Brand brand;
        private Category category;
        private long brandID;
        private long categoryID;
        private double price;
        private long stock;
        private long barcode;

        public Product() 
        {
        
        }

        public Product(long id, string name, Brand brand, Category category, double price, long stock)
        {
            this.Id = id;
            this.Name = name;
            this.Brand = brand;
            this.Category = category;
            this.Price = price;
            this.Stock = stock;
        }

        public Product(long id, string name,string description, long brandID, long categoryID , double price, long stock, long barcode) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.BrandID = brandID;
            this.CategoryID = categoryID;
            this.Price = price;
            this.Stock = stock;
            this.Barcode = barcode;
            
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public long Stock { get => stock; set => stock = value; }
        public string Description { get => description; set => description = value; }
        public long BrandID { get => brandID; set => brandID = value; }
        public long CategoryID { get => categoryID; set => categoryID = value; }
        public long Barcode { get => barcode; set => barcode = value; }
        internal Brand Brand { get => brand; set => brand = value; }
        internal Category Category { get => category; set => category = value; }
    }
}
