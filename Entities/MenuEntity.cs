using System.Collections.Generic;

namespace Entities
{
    public class MenuEntity : BaseEntity<int>
    {
        public string name { get; set; }
        public virtual List<DishEntity> dishes { get; set; }

        public MenuEntity()
        {
        }
        public MenuEntity(string name)
        {
            this.name = name;
            dishes = new List<DishEntity>();
        }
    }
}
