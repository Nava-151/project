using Microsoft.AspNetCore.Mvc;
using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Data.Repository;
using RentDress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentDress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DressController : ControllerBase
    { 


        //{1,18,"red",0,18,"cotton",new DateTime(2020,10,05));
        readonly IDressService _dressService;

        public DressController(IDressService dressService)
        {
            _dressService = dressService;
        }



        // GET: api/<DressController>
        [HttpGet]
        public ActionResult<List<DressEntity>> Get()
        {
            var res= _dressService.GetDressList();
            if(res == null) 
                return NotFound();
            return res;
        }

        // GET api/<DressController>/5
        [HttpGet("{id}")]
        public ActionResult<DressEntity> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            DressEntity res = _dressService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<DressController>
        [HttpPost]

        public ActionResult<bool> Post([FromBody] DressEntity DressEntity)
        {
            bool b= _dressService.Add(DressEntity);
            if(!b) return BadRequest();
            return b;
        }

        // PUT api/<DressController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] DressEntity Dress)
        {
            if (_dressService.Update(Dress))
                return true;
            return NotFound();
        }

        // DELETE api/<DressController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!_dressService.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
