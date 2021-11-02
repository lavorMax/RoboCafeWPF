
using System.Collections.Generic;

namespace Entities
{
    public class RestaurantEntity : BaseEntity<int>
    {
        public string name { get; set; }
        public virtual List<MenuEntity> menus { get; set; }
        public virtual List<SheduleEntity> shedules { get; set; }

        public RestaurantEntity(string name)
        {
            this.name = name;
            menus = new List<MenuEntity>();
            shedules = new List<SheduleEntity>();
        }
        public RestaurantEntity()
        {
        }
    }
}
