using Spectre.Console;

namespace Exercise;

public static partial class Application
{
    private enum Options
    {
        AddRecipe,
        ListRecipes,
        ListCategories,
        Save,
        Edit,
        Delete,
        Exit
    }

    public static void Run()
    {
        var rule = new Rule("[yellow]Recipe Manager[/]");
        rule.Justification = Justify.Center;
        AnsiConsole.Write(rule);

        var menu = showMenu();
        while (menu != Options.Exit)
        {
            switch (menu)
            {
                case Options.AddRecipe:
                    // showAddRecipeOptions();
                    break;
                case Options.ListRecipes:
                    // showRecipe();
                    break;
                case Options.ListCategories:
                    // showCategory();
                    break;
            }
            menu = showMenu();
        }
    }

    private static Options showMenu()
    {
        var menu = AnsiConsole.Prompt(new SelectionPrompt<Choice>()
            .Title("Main Menu")
            .AddChoices(
                new Choice("Add Recipe", Options.AddRecipe),
                new Choice("List Recipes", Options.ListRecipes),
                new Choice("List Categories", Options.ListCategories),
                new Choice("Exit", Options.Exit))
            );
        return menu.getMenu();
    }
}

