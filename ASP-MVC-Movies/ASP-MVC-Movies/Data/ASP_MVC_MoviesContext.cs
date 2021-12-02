using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace ASP_MVC_Movies.Data
{
    public class ASP_MVC_MoviesContext : DbContext
    {
        public ASP_MVC_MoviesContext (DbContextOptions<ASP_MVC_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
