using MongoDB.Bson;

namespace MongoDBGenericRepositoryExampleProject.Core.Entities;

public class DocumentDbEntity
{
    public ObjectId Id { get; set; }
    public string ObjectId => Id.ToString();
}
