using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;

namespace Warehouse_Backend.Controllers
{
    [ApiController,Route("admin")]
    public class AdminController : ControllerBase
    {

        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService1)
        {
            adminService = adminService1;
        }

        [HttpGet,Route("login")]
        public Admin Login(Admin admin)
        {
            return adminService.Login(admin);
        }
    }
}
