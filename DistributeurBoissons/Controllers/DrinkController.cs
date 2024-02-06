using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DistributeurBoissons.Models;
using DistributeurBoissons.Services;

namespace DistributeurBoissons.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinkController([FromServices] IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetRecipes()
        {
            var recipes = _drinkService.GetRecipes();
            return Ok(recipes);
        }

        [HttpGet("{name}")]
        public ActionResult<decimal> GetPrice(string name)
        {
            try
            {
                decimal price = _drinkService.GetPrice(name);
                return price;
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
