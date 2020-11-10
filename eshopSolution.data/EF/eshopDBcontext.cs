using eshopSolution.data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshopSolution.data.EF
{
    class eshopDBcontext : DbContext
    {
        public eshopDBcontext(DbContextOptions options) : base(options)
        { 
        }
       public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
