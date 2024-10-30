using Microsoft.AspNetCore.Mvc;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        static RentServ rList=new RentServ();
        // GET: api/<RentController>
        [HttpGet]
        public ActionResult<List<Rent>> Get()
        {
           List<Rent> res=rList.GetList();
           if(res==null)
                return NotFound();
            return res;
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public ActionResult<Rent> Get(int id)
        {
            Rent res = rList.GetRentById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<RentController>
        [HttpPost]
        public ActionResult Post([FromBody] Rent Rent)
        {
            if(rList.PostRent(Rent)==false)
                return NotFound();
            return Ok();
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Rent Rent)
        {
            if(rList.PutRent(id,Rent))
                return Ok();
            return NotFound();
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
           if( !rList.DeleteRent(id))
                return NotFound();
            return Ok();
        }
    }
}
