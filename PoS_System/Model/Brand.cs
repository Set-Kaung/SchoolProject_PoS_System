using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_System.Model
{
    class Brand
    {
        private long id;
        private string name;

        public Brand(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
