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
    public class AboutManager : IAboutService
    {
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public IResult Add(About about)
		{
			try
			{
				_aboutDal.Add(about);
				return new SuccessResult(Messages.AboutSuccessAdd);
			}
			catch (Exception e)
			{
				return new ErrorResult(e.Message);
			}
		}

		public IDataResult<About> GetFirstAbout()
        {
			try
			{
				var about = _aboutDal.GetFirstAbout();
				return new SuccessDataResult<About>(about);
			}
			catch (Exception e)
			{
				return new ErrorDataResult<About>(e.Message);
			}
        }
    }
}
