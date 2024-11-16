using System.Collections.Generic;

namespace BookLibraryAPI.Models;

public class Author
{
  public int? Id { get; set; } // Nullable ID
  public string Name { get; set; } = null!; // Required Name
  public List<Book>? Books { get; set; } = new(); // Default to empty list
}
