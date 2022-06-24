using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service
{
    public interface IStockService
    {
        public List<WarehouseVo> GetWarehouseByGoods(int g_id);
        public List<GoodsVo> GetGoodsByWarehouse(int w_id);
    }
}
