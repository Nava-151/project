using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        readonly RentServ rList=new RentServ();
        // GET: api/<RentController>
        [HttpGet]
        public ActionResult<List<Rent>> Get()
        {
           List<Rent> res=rList.GetList();
           //if(res==null)
           //     return NotFound();
            return res;
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public ActionResult<Rent> GetById(int id)
        {
            if (id < 0)
                return BadRequest();

            Rent res = rList.GetRentById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<RentController>
        [HttpPost]
        //never return false in service
        public ActionResult<bool> Post([FromBody] Rent Rent)
        {
            return rList.Add(Rent);
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Rent Rent)
        {
            if (rList.Update(id, Rent))
                return true;
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
