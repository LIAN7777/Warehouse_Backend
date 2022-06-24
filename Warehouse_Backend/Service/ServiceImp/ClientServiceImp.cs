using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service.ServiceImp
{
    public class ClientServiceImp : IClientService
    {
        private readonly EntityDbContext context;

        public ClientServiceImp(EntityDbContext entityDbContext)
        {
            context = entityDbContext;
        }

        public Message AddClient(Client client)
        {
            try
            {
                context.client.Add(client);
                context.SaveChanges();
                return new Message() { message = "客户添加成功" };
            }
            catch
            {
                return new Message() { message = "客户添加失败" };
            }
        }

        public Message DeleteClient(int id)
        {
            try
            {
                context.client.Remove(context.client.Find(id));
                return new Message() { message = "客户删除成功" };
            }
            catch
            {
                return new Message() { message = "客户删除失败" };
            }
        }

        public List<Client> GetAll(string type)
        {
            try
            {
                return context.client.Where(o => o.Type == type).ToList();
            }
            catch
            {
                return new List<Client>();
            }
        }

        public Message UpdateClient(Client client)
        {
            try
            {
                Client client1 = context.client.Find(client.Id);
                if (client1 != null)
                {
                    client1.Name = client.Name;
                    client1.Phone = client.Phone;
                    client1.Address = client.Address;
                    client1.Type = client.Type;
                    context.SaveChanges();
                    return new Message() { message = "客户更新成功" };
                }
                else return new Message() { message = "客户不存在" };
            }
            catch
            {
                return new Message() { message = "客户更新失败" };
            }
        }
    }
}
