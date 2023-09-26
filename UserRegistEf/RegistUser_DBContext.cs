using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistEf
{
    internal class RegistUser_DBContext:DbContext
    {
        public RegistUser_DBContext(DbContextOptions<RegistUser_DBContext> options):base (options)
        {
            
        }
    }
}
