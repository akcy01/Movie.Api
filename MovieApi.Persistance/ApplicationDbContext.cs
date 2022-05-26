using Microsoft.EntityFrameworkCore;
using MovieApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieApi.Persistance
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet <MovieModel> Movies { get; set; }

    }
}
