namespace Exercise;

public class Recipe
{
    public Guid id { get; set; }
    public string recipeTitle { get; set; }
    public string recipeIngredients { get; set; }
    public string recipeInstructions { get; set; }
    public List<Category> categories { get; set; }

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