using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticalRazorTaskAPI.Data;
using PracticalRazorTaskAPI.Model;

namespace PracticalRazorTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private ApplicationDbContext _db;

        public SearchController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetCategory")]
        public IActionResult GetCategory()
        {
            return Ok(_db.categories.ToList());
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProduct()
        {
            return Ok(_db.products.ToList());
        }

        [HttpGet("name")]
        public async Task<IEnumerable<Product>> GetByName(string name)
        {
            var result = from e in _db.products join d in _db.categories on e.CategoryId equals d.Id 
                         join ws in 
            var data = _db.products.Where(x => x.Name.Contains(x.Name)).Include(x => x.Category).ToList();
            //var data = from c in _db.products where c.Name == name select (new { c, c.Category });
            if (data != null)
            {
                return data;
            }

            return Enumerable.Empty<Product>();

        }

        [HttpGet("catname")]
        public async Task<IEnumerable<Category>> GeyCategoryByName(string catname)
        {
            //var prodData = _db.products.Select(x => x.Name);
            var catData = _db.categories.Where(x => x.Name == catname);

            if (catData != null)
            {
                return catData;
            }
            else
            {
                return Enumerable.Empty<Category>();
            }
        }

    }
}
