using BookLibraryAPI.Models;

namespace BookLibraryAPI.Mutations;

public record AddBookInput(string Title, string Genre, AuthorInput Author);

public record AuthorInput(int? Id, string Name, List<Book>? Books);

public class Mutation
{
  public Book AddBook(AddBookInput bookInput)
  {
    // Ensure author ID is always set
    var authorId = bookInput.Author.Id ?? new Random().Next(1, 1000);

    var author = new Author
    {
      Id = authorId,
      Name = bookInput.Author.Name,
      Books = bookInput.Author.Books ?? new List<Book>()
    };

    // Ensure book ID is always set
    var book = new Book
    {
      Id = new Random().Next(1, 1000), // Generate a random ID for the book
      Title = bookInput.Title,
      Genre = bookInput.Genre,
      Author = author
    };

    return book;
  }
}
