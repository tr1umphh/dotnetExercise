using Spectre.Console;

namespace Exercise;

public class DataContainer
{
    private List<Recipe> recipes = new();
    private List<Category> categories = new();

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }

    public void AddCategory(Category category)
    {
        if (categories.Contains(category))
        {
            AnsiConsole.Markup("[red]Category already exists![/]");
            return;
        }
        categories.Add(category);
    }

    public void DeleteRecipe(Guid id)
    {
        recipes.RemoveAll(recipe => recipe.id == id);
    }

    public void DeleteCategory(string name)
    {
        categories.RemoveAll(category => category.catergoryName == name);
    }

    public void EditRecipe(Guid id, Recipe recipe)
    {
        var index = recipes.FindIndex(recipeT => recipeT.id == id);
        recipes[index] = recipe;
    }

    public void EditCategory(string name, Category category)
    {
        var index = categories.FindIndex(categoryT => categoryT.catergoryName == name);
        categories[index] = category;
    }

    public List<Recipe> GetRecipes()
    {
        return recipes;
    }

    public List<Category> GetCategories()
    {
        return categories;
    }
}