using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipeRight.Database.Models
{
    public class Recipe
    {
        public Guid Id;

        public List<IngredientWithAmount> IngredientsWithAmounts;

        public List<Step> Steps;
    }
}
