using TemplateMethod.AbstractClass;

namespace TemplateMethod.SubClasses
{
    internal class Vinagrete : RecipeStructure
    {
        protected override void Preparation()
        {
            Console.WriteLine("Vinagrete\nIngredients:\n1 large onion diced\n4 tomatoes diced\n1 green or red bell pepper, diced\n" +
                "1/3 cup of chopped parsley\n1/4 cup of white wine vinegar\n1/2 cup of olive oil\nSalt and pepper");
        }

        protected override void Cooking()
        {
            Console.WriteLine("Cooking:\nCombine all the ingredients in a large bowl and mix well, Season with salt and pepper and serve");
        }

        protected override void Sides()
        {
            Console.WriteLine("Sides:\nBarbecue, filet mignon, white rice, grilled cheese\n");
        }
    }
}
