namespace API.Controllers
{
    public class BuggController 
    {
        private readonly DataContext _dataContext;
        {
            _dataContext = new DataContext();
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult <string> Get()
        {
            return "secret text";
        }

        [Authorize]
        [HttpGet("not-found")]
        public ActionResult <AppUser> GetNotFound()
        {
            var thing = _dataContext.Users.Find(-1)
            if (thing == null) return NotFound();
            return (thing);
        }

        [Authorize]
        [HttpGet("server-error")]
        public ActionResult <string> GetServerError()
        {
            var thing = _dataContext.Users.Find(-1)
            var thingToReturn = thing.ToString();
            return thingToReturn;
        }

        [Authorize]
        [HttpGet("bad-request")]
        public ActionResult <string> GetBadRequest()
        {
            return BadRequest("This Was Not a Good Request");
        }

    }
}