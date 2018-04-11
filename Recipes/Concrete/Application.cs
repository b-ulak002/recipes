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
