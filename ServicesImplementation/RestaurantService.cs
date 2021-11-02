using Data.Abstract;
using Domain;
using Services.Abstract;
using System.Collections.Generic;
using Mappers;

namespace Services.Implementation
{
    public class RestaurantService : IRestaurantService
    {
        public IUnitOfWork uw { get; set; }
        public RestaurantService(IUnitOfWork uw)
        {
            this.uw = uw;
        }

        public List<Restaurant> GetAll()
        {
            List<Restaurant> rests = new List<Restaurant>();
            uw.restaurantRepository.GetAll().ForEach(i => rests.Add(i.EntityToModel())) ;
            return rests;
        }
    }
}
