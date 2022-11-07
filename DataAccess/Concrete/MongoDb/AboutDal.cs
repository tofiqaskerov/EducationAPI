using Core.DataAccess.MongoDb;
using DataAccess.Abstract;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDb
{
    public class AboutDal : MongoEntityRepositoryBase<About>, IAboutDal
    {
        public About GetFirstAbout()
        {
            var context = new MongoClient("mongodb://localhost:27017").GetDatabase("education");
            var about = context.GetCollection<About>("about");
            var res = about.Find(x => true).FirstOrDefault();
            return res;
        }
    }
}
