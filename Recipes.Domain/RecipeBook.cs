using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Domain
{
    public class RecipeBook
    {
        Recipe[] recipes = new[]
            { new Recipe { Name = "My Great Recipe"
                         , Summary = "The best recipe you've never had"
                         , Description = "Combine the ingredients in a large bathtub. Simmer until gelatinous. Eat with spork."
                         , Ingredients =
                               new[] { new Ingredient { Quantity = 5
                                                      , Unit     = "cups"
                                                      , Name     = "Sugar" }
                                     , new Ingredient { Quantity = 5
                                                      , Unit     = "loaves"
                                                      , Name     = "Bread" }
                                     , new Ingredient { Quantity = 0.5
                                                      , Unit     = "tbsp"
                                                      , Name     = "Yeast" }}}};

        public void AddRecipe()
        { throw new NotImplementedException(); }

        public void RemoveRecipe()
        { throw new NotImplementedException(); }

        public Recipe[] RetrieveRecipe(string name)
        {
            return this.recipes; // TODO FIXME
        }
    }
}
