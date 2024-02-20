using HotelRez.BusinessLayer.Abstract;
using HotelRez.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelRez.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _service.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _service.TInsert(service);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _service.TGetByID(id);
            _service.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _service.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceById(int id)
        {
            var values = _service.TGetByID(id);
            return Ok(values);
        }
    }
}
