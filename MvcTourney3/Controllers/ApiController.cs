using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcTourney3.Models;
using MvcTourney3.Data;

namespace MvcTourney3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MvcTourney3Context _context;

        public ValuesController(MvcTourney3Context context)
        {
            _context = context;
        }

        [Route("getteams")]
        public List<Team> GetTeams()
        {
            return _context.Team.ToList();
        }
    }
}
