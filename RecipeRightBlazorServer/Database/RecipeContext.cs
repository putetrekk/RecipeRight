using Microsoft.EntityFrameworkCore;
using RecipeRightBlazorServer.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeRightBlazorServer.Database
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        { }
    }
}
