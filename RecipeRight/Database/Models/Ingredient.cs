using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeRight.Database.Models
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }

        public String Name { get; set; }
    }
}