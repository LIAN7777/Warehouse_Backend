using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Warehouse_Backend.Models;
using Warehouse_Backend.Service;
using Warehouse_Backend.Vo;

namespace Warehouse_Backend.Controllers
{
    [ApiController, Route("goods")]
    public class GoodsController : ControllerBase
    {
        private readonly IGoodsService goodsService;

        public GoodsController(IGoodsService goodsService1)
        {
            goodsService = goodsService1;
        }

        [HttpPost, Route("add")]
        public Message AddGoods(Goods goods)
        {
            return goodsService.AddGoods(goods);
        }
        [HttpGet, Route("get")]
        public List<Goods> GetAll()
        {
            return goodsService.GetAll();
        }
        [HttpPost, Route("update")]
        public Message UpdateGoods(Goods goods)
        {
            return goodsService.UpdateGoods(goods);
        }
        [HttpDelete, Route("dalete")]
        public Message DeleteGoods(int id)
        {
            return goodsService.DeleteGoods(id);
        }
    }
}
