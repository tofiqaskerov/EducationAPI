using Core.DataAccess.MongoDb.MongoSettings;
using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonCollection("about")]
    public class About : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id;
        public string Description { get; set; }
    }
}
