using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeRightVue.Models
{
    public class IngredientWithAmount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public float Quantity { get; set; }

        public string Unit { get; set; }
    }
}