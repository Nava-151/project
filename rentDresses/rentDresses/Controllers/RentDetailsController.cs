using Microsoft.AspNetCore.Mvc;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentDetailsController : ControllerBase
    {
        static RentDetailsService rList = new RentDetailsService();
        // GET: api/<RentDetailsController>
        [HttpGet]
        public ActionResult<List<RentDetails>> Get()
        {
            List<RentDetails> res = rList.GetList();
            if (res == null)
                return NotFound();
            return res;
        }

        // GET api/<RentDetailsController>/5
        [HttpGet("{id}")]
        public ActionResult<RentDetails> Get(int id)
        {
            RentDetails res = rList.GetRentDetailsById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<RentDetailsController>
        [HttpPost]
        public ActionResult Post([FromBody] RentDetails RentDetails)
        {
            if (rList.PostRentDetails(RentDetails) == false)
                return NotFound();
            return Ok();
        }

        // PUT api/<RentDetailsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RentDetails RentDetails)
        {
            if (rList.PutRentDetails(id, RentDetails))
                return Ok();
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
