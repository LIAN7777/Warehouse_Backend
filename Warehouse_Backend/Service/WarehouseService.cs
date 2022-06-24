using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service
{
    public interface IWarehouseService
    {
        public Message AddWarehouse(Warehouse warehouse);
        public Message DeleteWarehouse(int id);
        public Message UpdateWarehouse(Warehouse warehouse);
        public List<Warehouse> GetAll();
    }
}
