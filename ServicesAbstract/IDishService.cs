using Data.Abstract;
using Domain;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IDishService
    {
        IUnitOfWork uw { get; set; }
        bool CheckByTime(Dish dish);
        bool CheckByProducts(Dish dish);
    }
}
