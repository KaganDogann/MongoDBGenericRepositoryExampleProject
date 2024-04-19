using MongoDBGenericRepositoryExampleProject.Repository.Abstract;
using MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB;
using MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB.Collections;
using MongoDBGenericRepositoryExampleProject.Repository.Concrete.MongoDB.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<MongoDbContextBase, MongoDBContext>();

builder.Services.AddScoped<IBlogRepository>(x => new BlogRepository(x.GetRequiredService<MongoDbContextBase>(), Collections.Blog));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
