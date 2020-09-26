using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeRightBlazor.Shared
{
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Step> Steps { get; set; }
    }
}