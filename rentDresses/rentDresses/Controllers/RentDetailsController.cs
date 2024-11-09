using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentDetailsController : ControllerBase
    {
        readonly RentDetailsService rList = new RentDetailsService();
        // GET: api/<RentDetailsController>
        [HttpGet]
        public ActionResult<List<RentDetails>> Get()
        {
            List<RentDetails> res = rList.GetList();
            //if (res == null)
            //    return NotFound();
            return res;
        }

        // GET api/<RentDetailsController>/5
        [HttpGet("{id}")]
        public ActionResult<RentDetails> GetById(int id)
        {
            if (id < 0)
                return BadRequest();

            RentDetails res = rList.GetRentDetailsById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        //never return false in service
        // POST api/<RentDetailsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] RentDetails RentDetails)
        {
            return rList.Add(RentDetails);
              
        }

        // PUT api/<RentDetailsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] RentDetails RentDetails)
        {
            if (rList.Update(id, RentDetails))
                return true;
            return NotFound();
        }

        // DELETE api/<RentDetailsController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!rList.DeleteRentDetails(id))
                return NotFound();
            return Ok();
        }
    }
}
