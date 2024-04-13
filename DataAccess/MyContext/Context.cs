using DataAccess.Entity;
using DTO.EntityDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MyContext
{
    public class Context : DbContext
    {
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
