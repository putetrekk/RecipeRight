using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeRightBlazor.Shared
{
    public class Step
    {
        [Key]
        public Guid Id { get; set; }

        public string Action { get; set; }

        public List<IngredientWithAmount> IngredientsWithAmounts { get; set; }
    }
}