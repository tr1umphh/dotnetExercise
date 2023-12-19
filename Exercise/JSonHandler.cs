using System.Text.Json;

namespace Exercise;

public class JSonHandler
{
    private string path = "../../../data/db.json";
    private DataContainer dataContainer = new();

    public void AddRecipe(Recipe recipe)
    {
        dataContainer.AddRecipe(recipe);
    }

    public void AddCategory(Category category)
    {
        dataContainer.AddCategory(category);
    }

    public void DeleteRecipe(Guid id)
    {
        dataContainer.DeleteRecipe(id);
    }

    public void DeleteCategory(string name)
    {
        dataContainer.DeleteCategory(name);
    }

    public void EditRecipe(Guid id, Recipe recipe)
    {
        dataContainer.EditRecipe(id, recipe);
    }

    public void EditCategory(string name, Category category)
    {
        dataContainer.EditCategory(name, category);
    }

    public List<Recipe> GetRecipes()
    {
        return dataContainer.GetRecipes();
    }

    public List<Category> GetCategories()
    {
        return dataContainer.GetCategories();
    }

    public Task Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        var jsonString = JsonSerializer.Serialize(dataContainer, options);
        return File.WriteAllTextAsync(path, jsonString);
    }

    public async Task Load()
    {
        if (!File.Exists(path))
        {
            File.Create(path);
            return;
        }
        var jsonString = await File.ReadAllTextAsync(path);
        dataContainer = JsonSerializer.Deserialize<DataContainer>(jsonString) ?? throw new InvalidOperationException();
    }
}