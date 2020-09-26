using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeRightBlazorServer.Database;
using RecipeRightBlazorServer.Database.Models;

namespace RecipeRightBlazorServer.Data
{
    public class RecipeService
    {
        private readonly RecipeContext context;

        public async Task<List<Recipe>> GetRecipes()
        {
            return await context.Recipes.ToListAsync();
        }
    }
}
