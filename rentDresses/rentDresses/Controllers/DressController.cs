using Microsoft.AspNetCore.Mvc;
using rentDresses.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentDresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DressController : ControllerBase
    {
        static DressService dList=new DressService();
        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<Dress>> Get()
        {
           List<Dress> res=dList.GetList();
           if(res==null)
                return NotFound();
            return res;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<Dress> Get(int id)
        {
            Dress res = dList.GetDressById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<DressController>
        [HttpPost]
        public ActionResult Post([FromBody] Dress dress)
        {
            if(dList.PostDress(dress)==false)
                return NotFound();
            return Ok();
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Dress dress)
        {
            if(dList.PutDress(id,dress))
                return Ok();
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
