using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_MVC_Movies.Data;
using MvcMovie.Models;

namespace ASP_MVC_Movies.Views.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASP_MVC_Movies.Data.ASP_MVC_MoviesContext _context;

        public IndexModel(ASP_MVC_Movies.Data.ASP_MVC_MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
