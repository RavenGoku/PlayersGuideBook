/*Challenge --------------------- Simula’s Soup------------------------------------------------------------ 100 XP

Simula is impressed with how you reconstructed the box with an enumeration. When the box opened,
you saw a glowing emerald gem inside. You don’t know what it is, but it seems important. Also in the box
were three vials of powder labeled HOT, SALTY, and SWEET.

“Finally! I can make soup again!” Simula says. She casually tosses the small glowing gem to you but is
wholly focused on the powders. “You stick around and help me make soup with your programming skills,
and I’ll tell you what that gem does.”
She pulls out a cookpot, knocks the clutter off the table with a quick sweep of her arm, and begins
cooking. She says, “I’m the best soup maker in town, and you’re in for a treat. I’ve got recipes for soup,
stew, and gumbo. I’ve got mushrooms, chicken, carrots, and potatoes for ingredients. And thanks to you
getting that box open, I’ve got seasonings again! Spicy, salty, and sweet seasoning. Pick a recipe, an
ingredient, and a seasoning, and I’ll make it. Use your programming skills to help us track what we make.”


Objectives:
• Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient
(mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).
• Make a tuple variable to represent a soup composed of the three above enumeration types.
• Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple
with the results. Hint: You could give the user a menu to pick from or simply compare the user’s
text input against specific strings to determine which enumeration value represents their choice.
• When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
Hint: You don’t need to convert the enumeration value back to a string. Simply displaying an
enumeration value with Write or WriteLine will display the name of the enumeration value.) */

using System.ComponentModel.Design;
using System.Drawing;

Console.Title = "Simula's Soup";
DisplayMenu();
Recipe chosen_recipe = GetRecipe();
Ingredients chosen_ingredient = GetIngredient();
Seasoning chosen_seasoning = GetSeasoning();

var dish = (Recipe: chosen_recipe, Ingredient: chosen_ingredient, Seasoning: chosen_seasoning);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"You have chosen: {dish.Seasoning} {dish.Ingredient} {dish.Recipe}");
Console.ResetColor();




//==========================================================================================
void DisplayMenu()
{
    Console.Write(
        "===============  Menu ==================\n" +
        "  ============= Recipe: ==============\n" +
        "   1.Soup\n" +
        "   2.Gumbo\n" +
        "   3.Stew\n" +
        "  ============ Ingredient: ===========\n" +
        "   1.Mushrooms\n" +
        "   2.Chicken\n" +
        "   3.Carrots\n" +
        "   4.Potatoes\n" +
        "  ============ Seasoning: ============\n" +
        "   1.Spicy\n" +
        "   2.Sweet\n" +
        "   3.Salty\n" +
        "=======================================\n\n");
    Console.WriteLine("User, what dish would you like to get?");
}
//------------------------------------------------------------------------------------------
Recipe GetRecipe()
{
    Recipe recipe;
    int choice;
    while (true)
    {
        Console.Write("Recipe: ");
        choice = Convert.ToInt32(Console.ReadLine());
        recipe = choice switch
        {
            1 => Recipe.Soup,
            2 => Recipe.Gumbo,
            3 => Recipe.Stew,
            _ => Recipe.Unknown
        };
        if (recipe != Recipe.Unknown)
        {
            Console.Clear();
            DisplayMenu();
            
            break;
        }
        else
        {
            Console.WriteLine("Wrong choice, try again!\r");
            
        }
    }

    return recipe;
}
//------------------------------------------------------------------------------------------
Ingredients GetIngredient()
{
    Ingredients ingredients;
    int choice;
    while (true)
    {
        Console.Write("Ingredient: ");
        choice = Convert.ToInt32(Console.ReadLine());
        ingredients = choice switch
        {
            1 => Ingredients.Mushrooms,
            2 => Ingredients.Chicken,
            3 => Ingredients.Carrots,
            4 => Ingredients.Potatoes,
            _ => Ingredients.Unknown
        };
        if (ingredients != Ingredients.Unknown)
        {
            Console.Clear();
            DisplayMenu();
            break;
        }
        else
        {
            Console.WriteLine("Wrong choice, try again!\r");
        }
    }

    return ingredients;
}
//------------------------------------------------------------------------------------------
Seasoning GetSeasoning()
{
    Seasoning seasoning;
    int choice;
    while (true)
    {
        Console.Write("Seasoning: ");
        choice = Convert.ToInt32(Console.ReadLine());
        seasoning = choice switch
        {
            1 => Seasoning.Spicy,
            2 => Seasoning.Salty,
            3 => Seasoning.Sweet,
            _ => Seasoning.Unknown
        };
        if (seasoning != Seasoning.Unknown)
        {
            Console.Clear();
            DisplayMenu();
            break;
        }
        else
        {
            Console.WriteLine("Wrong choice, try again!\r");
          
        }
    }

    return seasoning;
}
//------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------

enum Recipe
{
    Unknown = 0,
    Soup = 1,
    Gumbo,
    Stew
};

enum Ingredients
{
    Unknown = 0,
    Mushrooms = 1,
    Chicken,
    Carrots,
    Potatoes
};

enum Seasoning
{
    Unknown = 0,
    Spicy = 1,
    Salty,
    Sweet
};