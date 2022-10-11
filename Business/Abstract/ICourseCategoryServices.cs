using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseCategoryServices
    {
        IResult AddCourseCategory(CourseCategory courseCategory);
        IDataResult<List<CourseCategoryDTO>> GetCourseCategories();
    }
}
