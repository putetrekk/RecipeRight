using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RecipeRightBlazor.Server.Data;
using RecipeRightBlazor.Shared;

namespace RecipeRightBlazor.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly RecipeContext db;

        private readonly ILogger<IngredientController> logger;

        public IngredientController(ILogger<IngredientController> logger, RecipeContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Ingredient>> Get()
        {
            return await db.Ingredients.ToListAsync();
        }

        [HttpPost]
        public async Task Post(Ingredient Ingredient)
        {
            Ingredient.Id = Guid.NewGuid();
            db.Ingredients.Add(Ingredient);

            await db.SaveChangesAsync();
        }
    }
}