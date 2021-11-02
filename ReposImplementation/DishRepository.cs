using Data.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Data.Implementation
{
    public class DishRepository : GenericRepository<DishEntity, int>, IDishRepository
    {
        public DishRepository(RoboCafeDBContext context) : base(context)
        {
        }
    }
}
