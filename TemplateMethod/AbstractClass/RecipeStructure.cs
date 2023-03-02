namespace TemplateMethod.AbstractClass
{
    public abstract class RecipeStructure
    {
        //Template Method
        public void CreateRecipe()
        {
            Preparation();
            Cooking();
            Sides();
        }

        //Methods to be implemented
        protected abstract void Preparation();
        protected abstract void Cooking();
        protected abstract void Sides();
    }
}
