using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviesX.Models;

namespace RazorPagesMoviesX.Data
{
    public class RazorPagesMoviesXContext : DbContext
    {
        public RazorPagesMoviesXContext (DbContextOptions<RazorPagesMoviesXContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMoviesX.Models.Movie> Movie { get; set; }
    }
}
