using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Controllers
{
    [ApiController, Route("warehouse")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService warehouseService;

        public WarehouseController(IWarehouseService warehouseService1)
        {
            warehouseService = warehouseService1;
        }

        [HttpPost, Route("add")]
        public Message AddWarehouse(Warehouse warehouse)
        {
            return warehouseService.AddWarehouse(warehouse);
        }
        [HttpGet, Route("get")]
        public List<Warehouse> GetAll()
        {
            return warehouseService.GetAll();
        }
        [HttpPost, Route("update")]
        public Message UpdateWarehouse(Warehouse warehouse)
        {
            return warehouseService.UpdateWarehouse(warehouse);
        }
        [HttpDelete, Route("dalete")]
        public Message DeleteWarehouse(int id)
        {
            return warehouseService.DeleteWarehouse(id);
        }
    }
}
