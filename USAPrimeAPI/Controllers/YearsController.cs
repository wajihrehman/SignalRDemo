using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using USAPrimeAPI.BusinessModels;
using USAPrimeAPI.Context;

namespace USAPrimeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearsController : ControllerBase
    {
        private readonly ApplicationContext _db;

        public YearsController(ApplicationContext context)
        {
            _db = context;
        }


        [HttpPost]
        [Route("PostYear")]
        public async Task<IActionResult> PostYear(Years model)
        {
            try
            {
                _db.T_Years.Add(model);
                _db.SaveChanges();
                return Ok("API Running");
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpGet]
        [Route("GetYears")]
        public async Task<IActionResult> GetYears()
        {
            try
            {
                var lst = await _db.T_Years.ToListAsync();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}
