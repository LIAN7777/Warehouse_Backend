using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class StockServiceImp : IStockService
    {
        private readonly EntityDbContext context;

        public StockServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }

        public List<GoodsVo> GetGoodsByWarehouse(int w_id)
        {
            try
            {
                List<GoodsVo> goodsVos = new List<GoodsVo>();
                List<Stock> stocks = context.stock.Where(o => o.W_id == w_id).ToList();
                foreach(Stock i in stocks)
                {
                    Goods goods = context.goods.Find(i.G_id);
                    goodsVos.Add(new GoodsVo() { id = goods.Id, name = goods.Name, number = i.Number, description = goods.Description });
                }
                return goodsVos;
            }
            catch
            {
                return new List<GoodsVo>();
            }
        }

        public List<WarehouseVo> GetWarehouseByGoods(int g_id)
        {
            try
            {
                List<WarehouseVo> warehouseVos = new List<WarehouseVo>();
                List<Stock> stocks = context.stock.Where(o => o.G_id == g_id).ToList();
                foreach(Stock i in stocks)
                {
                    Warehouse warehouse = context.warehouse.Find(i.W_id);
                    warehouseVos.Add(new WarehouseVo() { id = warehouse.Id, name = warehouse.Name, address = warehouse.Address, number = i.Number });
                }
                return warehouseVos;
            }
            catch
            {
                return new List<WarehouseVo>();
            }
        }
    }
}
