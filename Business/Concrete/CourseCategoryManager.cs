using Business.Abstract;
using Business.Constants;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResults;
using Core.Helpers.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseCategoryManager : ICourseCategoryServices
    {
        private readonly ICourseCategoryDal _courseCategoryDal;

        public CourseCategoryManager(ICourseCategoryDal courseCategoryDal)
        {
            _courseCategoryDal = courseCategoryDal;
        }

        public IResult AddCourseCategory(CourseCategory courseCategory)
        {
            try
            {
                _courseCategoryDal.Add(courseCategory);
                return new SuccessResult(Messages.CourseCategorySuccessAdd);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<CourseCategoryDTO>> GetCourseCategories()
        {
            try
            {
                var data = _courseCategoryDal.GetContentCategories();
                return new SuccessDataResult<List<CourseCategoryDTO>>(data);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<CourseCategoryDTO>>(e.Message);
            }
        }
    }
}
