using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeRightVue.Models
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}