namespace BookLibraryAPI.Models;

public class Book
{
  public int Id { get; set; }
  public string Title { get; set; } = null!;
  public string Genre { get; set; } = null!;
  public Author? Author { get; set; } // Nullable Author
}
