using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class AdminServiceImp : IAdminService
    {
        private readonly EntityDbContext context;

        public AdminServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }
        public Admin Login(Admin admin)
        {
            try
            {
                Admin admin1 = context.admin.Find(admin.Id);
                if (admin1 != null)
                {
                    if (admin1.Password == admin.Password) return admin1;
                    else return new Admin() { Id = 0 };
                }
                else return new Admin() { Id = 0 };
            }
            catch
            {
                return new Admin() { Id = 0 };
            }
        }
    }
}
