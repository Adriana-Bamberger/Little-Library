using BookLibraryAPI.Models;
using BookLibraryAPI.Mutations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL();

app.Run();

public class Query
{
  public List<Book> GetBooks() => new List<Book>
    {
        new Book { Id = 1, Title = "C# in Depth", Genre = "Programming", Author = new Author { Id = 1, Name = "Jon Skeet" }},
        new Book { Id = 2, Title = "GraphQL Basics", Genre = "Programming", Author = new Author { Id = 2, Name = "Eve Porcello" }}
    };
}

public class Mutation
{
  public Book AddBook(Book book)
  {
    // Simulating adding the book to a database
    book.Id = new Random().Next(1, 1000); // Generate a random ID
    return book;
  }
}
