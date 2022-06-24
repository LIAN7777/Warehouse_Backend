using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Backend.Models;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Service
{
    public interface IGoodsService
    {
        public Message AddGoods(Goods goods);
        public Message DeleteGoods(int id);
        public Message UpdateGoods(Goods goods);
        public List<Goods> GetAll();
    }
}
