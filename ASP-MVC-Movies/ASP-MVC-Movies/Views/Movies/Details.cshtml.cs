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
    public class DetailsModel : PageModel
    {
        private readonly ASP_MVC_Movies.Data.ASP_MVC_MoviesContext _context;

        public DetailsModel(ASP_MVC_Movies.Data.ASP_MVC_MoviesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
