using System;
using Microsoft.EntityFrameworkCore;
namespace  C_Sharp.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :
            base(options)
        { }
        public DbSet<Products> Products { get; set; }
    }
}
