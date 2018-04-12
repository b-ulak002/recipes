using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Domain
{
    public class RecipeBook
    {
        Recipe[] recipes;

        int numRecipes = 0;

        public RecipeBook()
        {
            recipes = new Recipe[1024];
        }

        public void AddRecipe(Recipe recipe) =>
            recipes[numRecipes++] = recipe;

        public void RemoveRecipe(string name)
        { throw new NotImplementedException(); }

        public Recipe[] RetrieveRecipe(string name)
        {
            return this.recipes
                       .Take(numRecipes)
                       .Where(x => x.Name == name)
                       .ToArray();
        }
    }
}
