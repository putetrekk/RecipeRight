using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeRight.Database;
using RecipeRight.Database.Models;

namespace RecipeRight
{
    public class IndexModel : PageModel
    {
        private readonly RecipeRight.Database.RecipeContext _context;

        public IndexModel(RecipeRight.Database.RecipeContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipes.ToListAsync();
        }
    }
}
