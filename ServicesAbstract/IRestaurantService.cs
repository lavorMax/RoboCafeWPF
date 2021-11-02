using Data.Abstract;
using Domain;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IRestaurantService
    {
        IUnitOfWork uw { get; set; }
        List<Restaurant> GetAll();
    }
}
