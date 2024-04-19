using MongoDBGenericRepositoryExampleProject.Core.Repository;
using MongoDBGenericRepositoryExampleProject.Entities;

namespace MongoDBGenericRepositoryExampleProject.Repository.Abstract;

public interface IBlogRepository : IDocumentDbRepository<Blog>
{
}
