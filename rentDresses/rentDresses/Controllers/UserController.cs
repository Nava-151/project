

using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserService ulist = new UserService();
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
        public ActionResult<User> GetById(int id)
        {
            if (id < 0)
                return BadRequest();

            User res = ulist.GetUserById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<UserController>
        [HttpPost]
        //never return false in service
        public ActionResult<bool> Post([FromBody] User User)
        {
            if(!ulist.Add(User))
                return BadRequest();
            return ulist.Add(User);
              
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User User)
        {
            if (ulist.Update(id, User))
                return true;
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
