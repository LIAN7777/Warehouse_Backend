using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class WarehouseServiceImp : IWarehouseService
    {
        private readonly EntityDbContext context;

        public WarehouseServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }

        public Message AddWarehouse(Warehouse warehouse)
        {
            try
            {
                context.warehouse.Add(warehouse);
                context.SaveChanges();
                return new Message() { message = "仓库添加成功" };
            }
            catch
            {
                return new Message() { message = "仓库添加失败" };
            }
        }

        public Message DeleteWarehouse(int id)
        {
            try
            {
                context.warehouse.Remove(context.warehouse.Find(id));
                context.SaveChanges();
                return new Message() { message = "仓库删除成功" };
            }
            catch
            {
                return new Message() { message = "仓库删除失败" };
            }
        }

        public List<Warehouse> GetAll()
        {
            try
            {
                return context.warehouse.ToList();
            }
            catch
            {
                return new List<Warehouse>();
            }
        }

        public Message UpdateWarehouse(Warehouse warehouse)
        {
            try
            {
                Warehouse warehouse1 = context.warehouse.Find(warehouse.Id);
                if (warehouse1 != null)
                {
                    warehouse1.Name = warehouse.Name;
                    warehouse1.Address = warehouse.Address;
                    context.SaveChanges();
                    return new Message() { message = "仓库更改成功" };
                }
                else return new Message() { message = "仓库不存在" };
            }
            catch
            {
                return new Message() { message = "仓库更新失败" };
            }
        }
    }
}
