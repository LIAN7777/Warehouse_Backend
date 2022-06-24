using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;

namespace Warehouse_Backend.Service
{
    public interface IAdminService
    {
        public Admin Login(Admin admin);
    }
}
