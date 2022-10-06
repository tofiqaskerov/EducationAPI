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
    [BsonCollection("content_lessons")]
    public class ContentLessons : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId _id;
        public string LessonName { get; set; }
        public string VideoUrl { get; set; }
    }
}
