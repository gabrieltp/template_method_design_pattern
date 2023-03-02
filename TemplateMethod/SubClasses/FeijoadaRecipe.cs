using TemplateMethod.AbstractClass;

namespace TemplateMethod.SubClasses
{
    internal class FeijoadaRecipe : RecipeStructure
    {
        protected override void Preparation()
        {
            Console.WriteLine("Feijoada\nIngredients:\nBeans\nOnion and Garlic\nBacon\nSalted Beef and Pork\nOrange\nOil\nBay Leaves\nSalt and Pepper");
        }

        protected override void Cooking()
        {
            Console.WriteLine("Cooking:\nSoak the meat and beans, boil the meat for 20 min, cook the beans and meat," +
                "sautè the bacon and aromatics, thicken the stew");
        }

        protected override void Sides()
        {
            Console.WriteLine("Sides:\nWhite rice, Farofa, Brazilian vinagrette salse, sautéed collard greens, fried bananas, orange slices " +
                "or hot sauce\n");
        }
    }
}
