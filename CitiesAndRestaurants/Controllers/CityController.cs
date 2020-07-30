using System.Collections.Generic;
using System.Net;
using CitiesAndRestaurants.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace CitiesAndRestaurants.Controllers
{
    [Route("[controller]")]
    public class CityController : Controller
    {
        private AppContext db = new AppContext();

        // GET /city
        [HttpGet]
        public IEnumerable<City> Index()
        {
            return db.CityItems;
        }
    }
}