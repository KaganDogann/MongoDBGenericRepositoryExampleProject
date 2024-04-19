using MongoDBGenericRepositoryExampleProject.Core.Entities;

namespace MongoDBGenericRepositoryExampleProject.Entities;

public class Blog : DocumentDbEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
}