using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RecipeRightBlazor.Server.Models;
using RecipeRightBlazor.Shared;

namespace RecipeRightBlazor.Server.Data
{
    public class RecipeContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public RecipeContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}