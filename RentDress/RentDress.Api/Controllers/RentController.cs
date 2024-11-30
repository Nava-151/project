using Microsoft.AspNetCore.Mvc;
using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentDress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        readonly IRentService _RentService;

        public RentController(IRentService rentService)
        {
            _RentService = rentService;
        }

        // GET: api/<RentController>
        [HttpGet]
        public ActionResult<List<RentEntity>> Get()
        {
            return _RentService.GetRentList();
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public ActionResult<RentEntity> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            RentEntity res = _RentService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<RentController>
        [HttpPost]

        public ActionResult<bool> Post([FromBody] RentEntity RentEntity)
        {
            return _RentService.Add(RentEntity);
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] RentEntity Rent)
        {
            if (_RentService.Update(Rent))
                return true;
            return NotFound();
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!_RentService.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
