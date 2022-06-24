using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service
{
    public interface IClientService
    {
        public Message AddClient(Client client);
        public Message DeleteClient(int id);
        public Message UpdateClient(Client client);
        public List<Client> GetAll(string type);
    }
}
