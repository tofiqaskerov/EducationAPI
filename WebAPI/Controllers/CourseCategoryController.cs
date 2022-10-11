using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {
        private readonly ICourseCategoryServices _courseCategoryServices;

        public CourseCategoryController(ICourseCategoryServices courseCategoryServices)
        {
            _courseCategoryServices = courseCategoryServices;
        }


        [HttpPost("add")]
        public IActionResult AddCourseCategory(CourseCategory courseCategory)
        {
            var result = _courseCategoryServices.AddCourseCategory(courseCategory);

            if (result.Success)
                return Ok(new {status = 200, message = result.Message});

            return BadRequest(new { status = 400, message = result.Message });
        }


        [HttpGet("getall")]
        public IActionResult GetCourseCategories()
        {
            var result = _courseCategoryServices.GetCourseCategories();

            if(result.Success)
                return Ok(new { status = 200, data = result.Data });

            return BadRequest(new { status = 400, data = result.Message });
        }
    }
}
