using Data.Abstract;
using Entities;

namespace Data.Implementation
{
    public class RestaurantRepository : GenericRepository<RestaurantEntity, int>, IRestaurantRepository
    {
        public RestaurantRepository(RoboCafeDBContext context) : base(context)
        {
        }
    }
}
