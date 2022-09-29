using Business.Abstract;
using Business.Constants;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResults;
using Core.Helpers.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            try
            {
                _courseDal.Add(course);
                return new SuccessResult(Messages.CourseSuccessAdd);
            }
            catch (Exception error)
            {
                return new ErrorResult(error.Message);
            }

        }
    }
}
