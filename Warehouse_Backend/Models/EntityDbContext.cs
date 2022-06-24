using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse_Backend.Models
{
    public class EntityDbContext:DbContext
    {
        public virtual DbSet<Admin> admin { get; set; }
        public virtual DbSet<Client> client { get; set; }
        public virtual DbSet<Goods> goods { get; set; }
        public virtual DbSet<Oper> oper { get; set; }
        public virtual DbSet<Stock> stock { get; set; }
        public virtual DbSet<Warehouse> warehouse { get; set; }
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options)
        {
            
        }
    }
}
