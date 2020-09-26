using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeRightBlazor.Shared
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }

        public String Name { get; set; }
    }
}