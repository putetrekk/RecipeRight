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
    }
}