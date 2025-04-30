using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mythicalbeasts_data.Actions;
using mythicalbeasts_data.DataModels;

namespace mythicalbeasts_data.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MythicalBeastsController : Controller
    {
        // GET: MythicalBeasts
        [HttpGet("/MythicalBeasts", Name = "GetMythicalBeasts")]
        public List<MythicalBeast> Index()
        {
            Actions.MythicalBeasts mythicalBeasts = new Actions.MythicalBeasts();
            var beasts = mythicalBeasts.GetAll();
            
            return beasts;
        }

        // GET: MythicalBeasts/Details/5
        [HttpGet("/MythicalBeasts/{id}", Name = "GetMythicalBeast")]
        public MythicalBeast Details(int id)
        {
            Actions.MythicalBeasts mythicalBeasts = new Actions.MythicalBeasts();
            var beast = mythicalBeasts.Get(id);

            return beast;
        }

    }
}
