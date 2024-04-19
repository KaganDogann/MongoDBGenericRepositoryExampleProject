namespace MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB.Context;

public class MongoDBContext : MongoDbContextBase
{
    public MongoDBContext(IConfiguration configuration)
        : base(configuration)
    {
    }
}