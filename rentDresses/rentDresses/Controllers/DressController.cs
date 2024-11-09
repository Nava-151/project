using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressController : ControllerBase
    {
        readonly DressService dList=new DressService();

        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<Dress>> Get()
        {
            return dList.GetList();
         //  List<Dress> res=dList.GetList();
           //if(res==null)
           //     return NotFound();
            //return res;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<Dress> GetById(int id)
        {
            if(id<0)
                return BadRequest();

            Dress res = dList.GetDressById(id);
            if (res == null)
                return BadRequest();
            return res;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Dress dress)
        {
            return dList.Add(dress) == false;
            
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Dress dress)
        {
            if(dList.Update(id,dress))
                return true;
            return NotFound();
        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
           if( !dList.DeleteDress(id))
                return NotFound();
            return Ok();
        }
    }
}
