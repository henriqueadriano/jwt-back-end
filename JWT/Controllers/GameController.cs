using JWT.model;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly ISession _session;

        public GameController(ISession session)
        {
            _session = session;
        }

        [HttpGet("games")]
        public ActionResult GetGames()
        {
            var games = _session.QueryOver<Game>().List();
            return Ok(new
            {
                value = games
            });
        }
    }
}
