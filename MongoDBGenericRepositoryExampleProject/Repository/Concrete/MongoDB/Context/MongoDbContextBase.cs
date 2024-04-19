using MongoDBGenericRepositoryExampleProject.Core.Repository.MongoDB.Concrete.Configurations;

namespace MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB.Context;

public abstract class MongoDbContextBase
{
    protected MongoDbContextBase(IConfiguration configuration)
    {
        Configuration = configuration;
        MongoConnectionSettings = configuration.GetSection("MongoDbSettings").Get<MongoConnectionSettings>();
    }

    public IConfiguration Configuration { get; }
    public MongoConnectionSettings MongoConnectionSettings { get; }
}