using System.Collections.Generic;
using CitiesAndRestaurants.Model;
using Microsoft.AspNetCore.Mvc;

namespace CitiesAndRestaurants.Controllers
{
    [Route("[controller]")]
    public class RestaurantController : Controller
    {
        private AppContext db = new AppContext();
        
        // GET /restaurant
        [HttpGet]
        public IEnumerable<Restaurant> Index()
        {
            return db.RestaurantItems;
        }
    }
}