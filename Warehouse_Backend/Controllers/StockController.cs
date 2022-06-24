using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Controllers
{
    [ApiController, Route("stock")]
    public class StockController : ControllerBase
    {
        private readonly IStockService stockService;

        public StockController(IStockService stockService1)
        {
            stockService = stockService1;
        }

        [HttpGet,Route("get/warehouse")]
        public List<WarehouseVo> GetByGoods(int id)
        {
            return stockService.GetWarehouseByGoods(id);
        }
        [HttpGet,Route("get/goods")]
        public List<GoodsVo> GetByWarehouse(int id)
        {
            return stockService.GetGoodsByWarehouse(id);
        }
    }
}
