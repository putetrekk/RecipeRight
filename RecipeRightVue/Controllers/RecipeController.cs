using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipeRightVue.Data;
using RecipeRightVue.Models;

namespace RecipeRightBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeContext db;

        private readonly ILogger<RecipeController> logger;

        public RecipeController(ILogger<RecipeController> logger, RecipeContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Recipe>> Get()
        {
            return await db.Recipes.ToListAsync();
        }

        [HttpPost]
        public async Task Post(Recipe recipe)
        {
            recipe.Id = Guid.NewGuid();
            db.Recipes.Add(recipe);

            await db.SaveChangesAsync();
        }
    }
}