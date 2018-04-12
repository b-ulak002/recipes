using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipes.Abstract;
using Recipes.Domain;

namespace Recipes.Concrete
{
    class Application : IRunnable
    {
        RecipeBook ourRecipes;

        public Application()
        {
            ourRecipes = new RecipeBook(); // TODO make this load from a file

            // Pretending now...
            ourRecipes.AddRecipe(
                new Recipe
                {
                    Name = "My Great Recipe",
                    Summary = "The best recipe you've never had",
                    Description = "Combine the ingredients in a large bathtub. Simmer until gelatinous. Eat with spork.",
                    Ingredients = new[] { new Ingredient { Quantity = 5
                                                         , Unit     = "cups"
                                                         , Name     = "Sugar" }
                                        , new Ingredient { Quantity = 5
                                                         , Unit     = "loaves"
                                                         , Name     = "Bread" }
                                        , new Ingredient { Quantity = 0.5
                                                         , Unit     = "tbsp"
                                                         , Name     = "Yeast" }}
                });

            ourRecipes.AddRecipe(
             new Recipe { Name = "Water"
                         , Summary = "Water"
                         , Description = "HYDRATE"
                         , Ingredients =
                               new[] { new Ingredient { Quantity = 1
                                                      , Unit = "atom"
                                                      , Name = "Oxygen" }
                                     , new Ingredient { Quantity = 2
                                                      , Unit = "atoms"
                                                      , Name = "Hydrogen" }}});
        }

        public void Run()
        {
            var recipes = ourRecipes.RetrieveRecipe("Water");

            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r);
            }
        }
    }
}
