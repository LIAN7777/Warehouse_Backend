using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Backend.Vo
{
    public class OperVo
    {
        public int o_id { get; set; }
        public int w_id { get; set; }
        public int g_id { get; set; }
        public int c_id { get; set; }
        public int a_id { get; set; }
        public string w_name { get; set; }
        public string g_name { get; set; }
        public string c_name { get; set; }
        public string time { get; set; }
        public int number { get; set; }
    }
}
