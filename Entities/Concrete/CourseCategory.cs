using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.MongoDb.MongoSettings;
using Core.Entities;

namespace Entities.Concrete
{
    [BsonCollection("courses_category")]
    public class CourseCategory : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id;
        public string CategoryName { get; set; }
    }
}
