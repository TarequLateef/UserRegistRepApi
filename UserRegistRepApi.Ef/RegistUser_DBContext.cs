using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistRepApi.Core.Models;

namespace UserRegistRepApi.Ef
{
    public class RegistUser_DBContext:DbContext
    {
        public RegistUser_DBContext(DbContextOptions<RegistUser_DBContext> options):base(options) 
        {
            
        }

        public DbSet<UsersTBL> UsersTbl { get; set; }
        public DbSet<PosistionsTBL> PositionsTbl { get; set; }
        public DbSet<UserPositionTBL> userPositionTbl  { get; set; }
    }
}
