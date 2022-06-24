using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service
{
    public interface IOperService
    {
        public List<OperVo> GetAll(string type);
        public Message DeleteOper(int id);
        public Message AddOper(AddOperVo addOperVo);
    }
}
