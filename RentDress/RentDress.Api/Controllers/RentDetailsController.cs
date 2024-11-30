using Microsoft.AspNetCore.Mvc;
using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentDress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentDetailsController : ControllerBase
    {
        readonly IRentDetailsService _rentDetailsService;

        public RentDetailsController(IRentDetailsService rentDetailsService)
        {
            _rentDetailsService = rentDetailsService;
        }

        // GET: api/<RentDetailsController>
        [HttpGet]
        public ActionResult<List<RentDetailsEntity>> Get()
        {
            return _rentDetailsService.GetRentDetailsList();
        }

        // GET api/<RentDetailsController>/5
        [HttpGet("{id}")]
        public ActionResult<RentDetailsEntity> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            RentDetailsEntity res = _rentDetailsService.GetById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<RentDetailsController>
        [HttpPost]

        public ActionResult<bool> Post([FromBody] RentDetailsEntity RentDetailsEntity)
        {
            return _rentDetailsService.Add(RentDetailsEntity);
        }

        // PUT api/<RentDetailsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] RentDetailsEntity RentDetails)
        {
            if (_rentDetailsService.Update(RentDetails))
                return true;
            return NotFound();
        }

        // DELETE api/<RentDetailsController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            if (!_rentDetailsService.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
