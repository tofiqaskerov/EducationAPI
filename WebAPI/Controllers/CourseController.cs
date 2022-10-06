﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(string id)
        {
            var result = _courseService.GetById(id);
            if(result.Success)
                return Ok(new { data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();
            if(result.Success)
                return Ok(new { data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPost("addcourse")]
        public IActionResult Add(Course course)
        {
            var result = _courseService.Add(course);
            if (result.Success)
                return Ok(new { status = 200, message = result.Message });
            return BadRequest(new {message = result.Message});
        }
    }
}
