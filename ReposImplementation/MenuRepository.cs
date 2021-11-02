using Data.Abstract;
using Entities;

namespace Data.Implementation
{
    public class MenuRepository : GenericRepository<MenuEntity, int>, IMenuRepository
    {
        public MenuRepository(RoboCafeDBContext contextFactory) : base(contextFactory)
        {
        }
    }
}
