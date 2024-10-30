using Microsoft.AspNetCore.Mvc;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        static AvailabilityService ulist = new AvailabilityService();
        // GET: api/<AvailabilityController>
        [HttpGet]
        public ActionResult<List<Availability>> Get()
        {
            List<Availability> res = ulist.GetList();
            if (res == null)
                return NotFound();
            return res;
        }

        // GET api/<AvailabilityController>/5
        [HttpGet("{id}")]
        public ActionResult<Availability> Get(int id)
        {
            Availability res = ulist.GetAvailabilityById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<AvailabilityController>
        [HttpPost]
        public ActionResult Post([FromBody] Availability Availability)
        {
            if (ulist.PostAvailability(Availability) == false)
                return NotFound();
            return Ok();
        }

        // PUT api/<AvailabilityController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Availability Availability)
        {
            if (ulist.PutAvailability(id, Availability))
                return Ok();
            return NotFound();
        }

        // DELETE api/<AvailabilityController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!ulist.DeleteAvailability(id))
                return NotFound();
            return Ok();
        }

    }
}

