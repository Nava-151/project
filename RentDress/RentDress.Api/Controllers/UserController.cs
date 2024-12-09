using Microsoft.AspNetCore.Mvc;
using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentDress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IAvailabilityService _availabilityService;

        public UserController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<AvailabilityEntity>> Get()
        {
            return _availabilityService.GetAvailabilityList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<AvailabilityEntity> GetById(int id)
        {

            AvailabilityEntity res = _availabilityService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<UserController>
        [HttpPost]

        public ActionResult<bool> Post([FromBody] AvailabilityEntity availabilityEntity)
        {
            return _availabilityService.Add(availabilityEntity);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] AvailabilityEntity Availability)
        {
            if (_availabilityService.Update(Availability))
                return true;
            return NotFound();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!_availabilityService.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
