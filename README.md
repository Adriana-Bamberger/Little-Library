# Little Library API
The Little Library API is a basic GraphQL server that lets you manage books. You can add, query, and update book details through GraphQL queries and mutations. This project is built using C# and .NET Core, with GraphQL to interact with the book data.

## Features:
- GraphQL for querying and adding books,
- Simple CRUD: Create, Read, Update books,
- ID Handling: Each book has a unique ID.
## Technologies:
- C# and .NET Core for the backend,
- GraphQL for API queries and mutations,
- Good old google, and ChatGPT for answering all my questions.
## What I Learned:
- How to build a simple GraphQL API,
- Using C# and .NET Core for very basic backend dev,
- New terminology,
- The slight diffrances between C# and TypeScript.

## Setup:
Clone the repo and move into the project folder:
Build and run:
```
dotnet build
dotnet run
```
The API will run locally at http://localhost:5000/graphql.

### Example:
Add a book:
```
mutation {
  addBook(book: {
    id: 1,
    title: "GraphQL With ID", 
    genre: "Technology", 
    author: { 
      id: 123, 
      name: "Jane Smith" 
    } 
  }) {
    id
    title
    author {
      id
      name
    }
  }
}

```
Thanks For Reading! :)
