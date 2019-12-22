
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BestHost.Infra
{
    public class HostAdminDB
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string VirtualName { get; set; }
        public sbyte Age { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FacebookPage { get; set; }
    }
}
