using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Controllers
{
    [ApiController, Route("oper")]
    public class OperController : ControllerBase
    {
        private readonly IOperService operService;

        public OperController(IOperService operService1)
        {
            operService = operService1;
        }

        [HttpGet,Route("get")]
        public List<OperVo> GetAll(string type)
        {
            return operService.GetAll(type);
        }
        [HttpPost,Route("add")]
        public Message AddOper(AddOperVo addOperVo)
        {
            return operService.AddOper(addOperVo);
        }
        [HttpDelete,Route("delete")]
        public Message DeleteOper(int id)
        {
            return operService.DeleteOper(id);
        }
    }
}
