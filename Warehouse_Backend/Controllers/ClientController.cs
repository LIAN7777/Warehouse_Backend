using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Controllers
{
    [ApiController,Route("client")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientController(IClientService clientService1)
        {
            clientService = clientService1;
        }

        [HttpPost,Route("add")]
        public Message AddClient(Client client)
        {
            return clientService.AddClient(client);
        }
        [HttpGet,Route("get")]
        public List<Client> GetAll(string type)
        {
            return clientService.GetAll(type);
        }
        [HttpPost,Route("update")]
        public Message UpdateClient(Client client)
        {
            return clientService.UpdateClient(client);
        }
        [HttpDelete,Route("dalete")]
        public Message DeleteClient(int id)
        {
            return clientService.DeleteClient(id);
        }
    }
}
