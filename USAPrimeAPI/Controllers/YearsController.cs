using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalR.Hubs;
using SignalR.Interfaces;
using USAPrimeAPI.BusinessModels;
using USAPrimeAPI.Context;

namespace USAPrimeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YearsController : ControllerBase
    {
        private readonly ApplicationContext _db;
        private readonly IHubContext<FirstHub, ITypedHubClient> _firstHub;

        public YearsController(ApplicationContext context, IHubContext<FirstHub, ITypedHubClient> firstHub)
        {
            _db = context;
            _firstHub = firstHub;
        }


        [HttpPost]
        [Route("PostYear")]
        public async Task<IActionResult> PostYear(Years model)
        {
            try
            {
                _db.T_Years.Add(model);
                _db.SaveChanges();
                GetYears();
                //await _firstHub.Clients.All.SendAsync("LoadProducts");
                return Ok(new { result = "API Running" });
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        public void GetYears()
        {
            var lst = _db.T_Years.ToList();
            _firstHub.Clients.All.BroadcastMessage(lst);
        }
    }
}
