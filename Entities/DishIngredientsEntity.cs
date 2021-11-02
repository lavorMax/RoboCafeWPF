namespace Entities
{
    public class DishIngredientsEntity : BaseEntity<int>
    {
        public int dishId { get; set; }
        public virtual DishEntity dish { get; set; }
        public int ingredientId { get; set; }
        public virtual IngredientEntity ingredient { get; set; }
        public int amount { get; set; }

        public DishIngredientsEntity()
        {
        }
        public DishIngredientsEntity(int dishId, int ingredientId, int amount)
        {
            this.dishId = dishId;
            this.ingredientId = ingredientId;
            this.amount = amount;
        }
    }
}
