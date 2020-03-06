using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoS_System.Model;
using PoS_System.DAO;

namespace PoS_System.Services
{
    class StaffServiceImpl : StaffService
    {
        private static long roleID;
        StaffDAO staffDAO = new StaffDAO();
        
        public List<Staff> getAllStaffs() 
        {
            return staffDAO.getAllStaffs();
        }

        public void addStaff(string username, string password,long role) 
        {
            string hashedPassword = PasswrodHash.HashPassword(password);
            staffDAO.addStaff(username, hashedPassword,role);
        }

        public Boolean isValid(string username,string password) 
        {
            
            List<Staff> staffs = staffDAO.getAllStaffs();
            foreach (Staff staff in staffs)
            {
                if (staff.Name.Equals(username) && PasswrodHash.ValidatePassword(password, staff.Password))
                {
                    roleID = staff.Role;
                    return true;
                }
               

            }
            return false;
            
        }

        public long getRole() 
        {
            return roleID;
        }
    }
}
