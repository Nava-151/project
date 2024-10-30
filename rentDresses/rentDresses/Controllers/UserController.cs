

using Microsoft.AspNetCore.Mvc;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        static UserService ulist = new UserService();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            List<User> res = ulist.GetList();
            if (res == null)
                return NotFound();
            return res;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User res = ulist.GetUserById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User User)
        {
            if (ulist.PostUser(User) == false)
                return NotFound();
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User User)
        {
            if (ulist.PutUser(id, User))
                return Ok();
            return NotFound();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!ulist.DeleteUser(id))
                return NotFound();
            return Ok();
        }
    
}
}
