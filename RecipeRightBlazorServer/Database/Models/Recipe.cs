using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipeRightBlazorServer.Database.Models
{
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Step> Steps { get; set; }
    }
}
