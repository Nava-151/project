using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        readonly AvailabilityService ulist = new AvailabilityService();
        // GET: api/<AvailabilityController>
        [HttpGet]
        public ActionResult<List<Availability>> Get()
        {
            List<Availability> res = ulist.GetList();
            //if (res == null)
            //    return NotFound();
            return res;
        }

        // GET api/<AvailabilityController>/5
        [HttpGet("{id}")]
        public ActionResult<Availability> GetById(int id)
        {
            if (id < 0)
                return BadRequest();

            Availability res = ulist.GetAvailabilityById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<AvailabilityController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Availability Availability)
        {
            return ulist.Add(Availability);
        }

        // PUT api/<AvailabilityController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Availability Availability)
        {
            if (ulist.Update(id, Availability))
                return true;
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

