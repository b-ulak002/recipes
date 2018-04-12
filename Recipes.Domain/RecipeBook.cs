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
        {
            for (int i = 0; i < numRecipes; ++i)
            {
                if (this.recipes[i].Name == name)
                {
                    RemoveElement(i);
                }
            }
        }

        public void RemoveRecipe(RecipeCategory category)
        {
            for (int i = 0; i < numRecipes; ++i)
            {
                if (this.recipes[i].Category == category)
                {
                    RemoveElement(i);
                }
            }
        }

        private void RemoveElement(int i)
        {
            if ((numRecipes != 0) && (i < numRecipes))
            {
                this.recipes[i] = this.recipes[--numRecipes];
                this.recipes[numRecipes] = null;
            }
        }

        public Recipe[] RetrieveRecipe(string name)
        {
            return this.recipes
                       .Take(numRecipes)
                       .Where(x => x.Name == name)
                       .ToArray();
        }

        public Recipe[] RetrieveRecipe(RecipeCategory category)
        {
            return this.recipes
                       .Take(numRecipes)
                       .Where(x => x.Category == category)
                       .ToArray();
        }
    }
}
