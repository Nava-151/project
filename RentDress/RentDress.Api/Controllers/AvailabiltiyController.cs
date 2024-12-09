using Microsoft.AspNetCore.Mvc;
using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentDress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilitiyController : ControllerBase
    {
        readonly IAvailabilityService _availabilityService;

        public AvailabilitiyController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }


        // GET: api/<AvailabiltyController>
        [HttpGet]
        public ActionResult<List<AvailabilityEntity>> Get()
        {
            var res= _availabilityService.GetAvailabilityList();
            if (res == null)
                return NotFound();
            return res;
        }

        // GET api/<AvailabiltyController>/5
        [HttpGet("{id}")]
        public ActionResult<AvailabilityEntity> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            AvailabilityEntity res = _availabilityService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<AvailabiltyController>
        [HttpPost]

        public ActionResult<bool> Post([FromBody] AvailabilityEntity availabilityEntity)
        {
            bool b= _availabilityService.Add(availabilityEntity);
            if(!b)
                return BadRequest();
            return b;
        }

        // PUT api/<AvailabiltyController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AvailabilityEntity Availability)
        {
            if (_availabilityService.Update(Availability))
                return true;
            return NotFound();
        }

        // DELETE api/<AvailabiltyController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!_availabilityService.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
