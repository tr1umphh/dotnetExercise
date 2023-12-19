namespace Exercise;

public class Recipe
{
    private Guid id { get; set; }
    private string recipeTitle { get; set; }
    private string recipeIngredients { get; set; }
    private string recipeInstructions { get; set; }
    private List<Category> categories { get; set; }

    public Recipe(
        string recipeTitle,
        string recipeIngredients,
        string recipeInstructions,
        List<Category> categories)
    {
        id = Guid.NewGuid();
        this.recipeTitle = recipeTitle;
        this.recipeIngredients = recipeIngredients;
        this.recipeInstructions = recipeInstructions;
        this.categories = categories;
    }

}