using HotelRez.BusinessLayer.Abstract;
using HotelRez.DataAccessLayer.Abstract;
using HotelRez.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelRez.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonial;

        public TestimonialController(ITestimonialService testimonial)
        {
            _testimonial = testimonial;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonial.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonial.TInsert(testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonial.TGetByID(id);
            _testimonial.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonial.TUpdate(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var values = _testimonial.TGetByID(id);
            return Ok(values);
        }
    }
}
