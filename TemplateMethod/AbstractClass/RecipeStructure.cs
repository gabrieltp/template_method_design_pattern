namespace TemplateMethod.AbstractClass
{
    public abstract class RecipeStructure
    {
        public void CreateRecipe()
        {
            Preparation();
            Cooking();
            Sides();
        }

        protected abstract void Preparation();
        protected abstract void Cooking();
        protected abstract void Sides();
    }
}
