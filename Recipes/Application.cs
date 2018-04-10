using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipes.Domain;

namespace Recipes
{
    class Application
    {
        RecipeBook ourRecipes;

        public Application()
        {
            ourRecipes = new RecipeBook(); // TODO make this load from a file
        }

        public void Run()
        {
            var recipes = ourRecipes.RetrieveRecipe("this string doesn't matter");

            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r);
            }
        }
    }
}
