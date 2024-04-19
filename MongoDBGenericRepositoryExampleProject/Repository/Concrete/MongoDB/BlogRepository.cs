using MongoDBGenericRepositoryExampleProject.Core.Repository.MongoDB.Concrete;
using MongoDBGenericRepositoryExampleProject.Entities;
using MongoDBGenericRepositoryExampleProject.Repository.Abstract;
using MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB.Context;
using System.Linq.Expressions;

namespace MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB;

public class BlogRepository : MongoDBRepositoryBase<Blog>, IBlogRepository
{
    public BlogRepository(MongoDbContextBase mongoDbContext, string collectionName) : base(mongoDbContext.MongoConnectionSettings, collectionName)
    {
    }

    public override IQueryable<Blog> GetList(Expression<Func<Blog, bool>> predicate = null)
    {
        return base.GetList(predicate);
    }
}
