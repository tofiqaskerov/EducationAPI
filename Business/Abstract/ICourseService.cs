using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetById(string id);
        IDataResult<List<CourseContentDTO>> GetByCourseId();
    }
}
