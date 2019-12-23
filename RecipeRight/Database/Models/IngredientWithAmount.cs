namespace RecipeRight.Database.Models
{
    public class IngredientWithAmount
    {
        public Ingredient Ingredient { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }
    }
}