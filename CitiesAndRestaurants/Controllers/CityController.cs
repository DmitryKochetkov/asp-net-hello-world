using System.Collections.Generic;
using System.Net;
using CitiesAndRestaurants.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CitiesAndRestaurants.Controllers
{
    [Route("[controller]")]
    public class CityController : Controller
    {
        private AppContext db = new AppContext();
        
        [HttpGet]
        public IEnumerable<City> Index()
        {
            return db.CityItems;
        }
        
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(long id)
        {
            City city = db.CityItems.Find(id);
            if (city == null)
                return NotFound();
            return Ok(city);
        }
    }
}