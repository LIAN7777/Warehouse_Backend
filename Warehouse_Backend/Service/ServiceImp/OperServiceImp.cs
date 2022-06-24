using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class OperServiceImp : IOperService
    {
        private readonly EntityDbContext context;

        public OperServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }

        public Message AddOper(AddOperVo addOperVo)
        {
            try
            {
                context.oper.Add(new Oper()
                {
                    C_id = addOperVo.c_id,
                    A_id = addOperVo.a_id,
                    W_id = addOperVo.w_id,
                    G_id = addOperVo.g_id,
                    Number = addOperVo.number,
                    Type = addOperVo.type,
                    Time = DateTime.Now.ToString()
                });
                Stock stock = context.stock.Where(o => o.W_id == addOperVo.w_id && o.G_id == addOperVo.g_id).FirstOrDefault();
                stock.Number += addOperVo.number;
                context.SaveChanges();
                return new Message() { message = "添加成功" };
            }
            catch
            {
                return new Message() { message = "添加失败" };
            }
        }

        public Message DeleteOper(int id)
        {
            try
            {
                Oper oper = context.oper.Find(id);
                context.oper.Remove(oper);
                Stock stock = context.stock.Where(o => o.G_id == oper.G_id && o.W_id == oper.W_id).FirstOrDefault();
                stock.Number -= oper.Number;
                context.SaveChanges();
                return new Message() { message = "删除成功" };
            }
            catch
            {
                return new Message() { message = "删除失败" };
            }
        }

        public List<OperVo> GetAll(string type)
        {
            try
            {
                List<OperVo> operVos = new List<OperVo>();
                List<Oper> opers = context.oper.Where(o => o.Type == type).ToList();
                foreach(Oper i in opers)
                {
                    Warehouse warehouse = context.warehouse.Find(i.W_id);
                    Goods goods = context.goods.Find(i.G_id);
                    Client client = context.client.Find(i.C_id);
                    OperVo operVo = new OperVo
                    {
                        a_id = i.A_id,
                        c_id = i.C_id,
                        w_id = i.W_id,
                        g_id = i.G_id,
                        c_name = client.Name,
                        g_name = goods.Name,
                        w_name = warehouse.Name,
                        o_id = i.Id,
                        number = i.Number,
                        time = i.Time
                    };
                }
                return operVos;
            }
            catch
            {
                return new List<OperVo>();
            }
        }
    }
}
