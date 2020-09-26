using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeRightBlazor.Shared
{
    public class IngredientWithAmount
    {
        [Key]
        public Guid Id { get; set; }
        public Ingredient Ingredient { get; set; }

        public float Quantity { get; set; }

        public string Unit { get; set; }
    }
}