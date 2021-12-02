using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Mapping;

namespace WebApplication5.DbOperations
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }


        
        public DbSet<Il> Ils { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            // define the database to use
            optionsBuilder.UseNpgsql("Server=127.0.0.1; port=5432; user id = postgres; password =19951994Fev; database=public; pooling = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //we gonna add here mapping classes...
            modelBuilder.ApplyConfiguration(new IlMap());
            
            modelBuilder.ApplyConfiguration(new UserMap());
            







            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("public");
        }
    
    }

    }

