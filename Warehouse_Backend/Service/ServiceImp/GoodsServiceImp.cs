using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class GoodsServiceImp : IGoodsService
    {
        private readonly EntityDbContext context;

        public GoodsServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }

        public Message AddGoods(Goods goods)
        {
            try
            {
                context.goods.Add(goods);
                context.SaveChanges();
                return new Message() { message = "货物添加成功" };
            }
            catch
            {
                return new Message() { message = "货物添加失败" };
            }
        }

        public Message DeleteGoods(int id)
        {
            try
            {
                context.goods.Remove(context.goods.Find(id));
                context.SaveChanges();
                return new Message() { message = "货物删除成功" };
            }
            catch
            {
                return new Message() { message = "货物删除失败" };
            }
        }

        public List<Goods> GetAll()
        {
            try
            {
                return context.goods.ToList();
            }
            catch
            {
                return new List<Goods>();
            }
        }

        public Message UpdateGoods(Goods goods)
        {
            try
            {
                Goods goods1 = context.goods.Find(goods.Id);
                if (goods1 != null)
                {
                    goods1.Name = goods.Name;
                    context.SaveChanges();
                    return new Message() { message = "货物更新成功" };
                }
                else return new Message() { message = "货物不存在" };
            }
            catch
            {
                return new Message() { message = "货物更新失败" };
            }
        }
    }
}
