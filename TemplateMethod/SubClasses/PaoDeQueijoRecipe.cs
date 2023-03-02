using TemplateMethod.AbstractClass;

namespace TemplateMethod.SubClasses
{
    public class PaoDeQueijoRecipe : RecipeStructure
    {
        protected override void Preparation()
        {
            Console.WriteLine("PaoDeQueijo\nIngredients:\n4 cups of tapioca flour\n1 1/4 cups of milk\n1/2 cup of water\n" +
                "6 tablespoons oil\n1 1/2 cups of grated parmesan cheese\n1 cup of shredded Mozzarella cheese\n2 large eggs\n2 teaspoons of salt");
        }

        protected override void Cooking()
        {
            Console.WriteLine("Cooking:\nPreheat oven to 200ºC degrees with a rack in the middle\nCombine the milk, water, oil and salt in a " +
                "saucepan and bring to a boil over medium high heat\nAdd the tapioca flour to the bowl of a stand mixer and, once the milk mixture " +
                "boils, pour it over the flour. Turn the mixer on and mix it well. The texture will be fondant-like, really white and sticky.\n" +
                "With the mixer still on, add the eggs, one at a time. You will think they won't mix, since the tapioca flour mixture is so sticky, " +
                "but hang in there cause they will\n" +
                "Once the eggs are incorporated, add the cheese, a little at a time, until fully incorporated\n" +
                "The dough is supposed to be soft and sticky. However, if you're worried it's too liquidy, add some more tapioca flour. Just don't over" +
                " do it or your cheese bread will be tough and not too gooey\n" +
                "To shape the balls, wet your hands with cold water and, using a spoon, scoop some of the dough to shape balls that are a little smaller than golf-sized\n" +
                "Place the balls on a baking sheet covered with parchment paper and bring it to the preheat oven\n" +
                "Bake for 15-20 minutes or until they are golden and puffed\n" +
                "Serve them warm!");
        }

        protected override void Sides()
        {
            Console.WriteLine("Sides:\nGuaraná drink, ketchup, cream cheese, butter\n");
        }
    }
}
