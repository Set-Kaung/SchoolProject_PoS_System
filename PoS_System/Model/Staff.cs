using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_System.Model
{
    class Staff
    {
        private long id;
        private string name;
        private string password;
        private long role;

        public Staff(long id, string name, string password, long role)
        {
            this.ID = id;
            this.Name = name;
            this.Password = password;
            this.Role = role;
        }

        public long ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public long Role { get => role; set => role = value; }
    }
}
