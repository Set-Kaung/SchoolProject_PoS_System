using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;

namespace PoS_System.Services
{
    interface StaffService
    {
        List<Staff> getAllStaffs();
        void addStaff(string username, string password,long role);
        Boolean isValid(string username,string password);
        long getRole();
    }
}
