using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWebMVC.Models
{
    public class ProjetoWebMVCContext : DbContext
    {
        public ProjetoWebMVCContext (DbContextOptions<ProjetoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWebMVC.Models.Department> Department { get; set; }
    }
}
