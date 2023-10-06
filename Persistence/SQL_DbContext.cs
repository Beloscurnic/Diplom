using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Entity_Type_Configurations;


namespace Persistence
{
    public class SQL_DbContext : DbContext, IDbContext
    {

        public SQL_DbContext(DbContextOptions<SQL_DbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
