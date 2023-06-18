![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
##  C# Assignment: Library Management System

The goal of this assignment was to implement a basic Library Management System as a C# console application. The purpose was to practice key principles of Object-Oriented Programming: Encapsulation, Abstraction, Inheritance, and Polymorphism.

### Things to improve on:

- Library class should be abstract 
- Books list should not be public
- There should be proper exception handling

## File Structure

```
.
├── LibraryManagement.csproj
├── README.md
├── bin
├── obj
└── src
    ├── Books
    │   ├── Book.cs
    │   ├── Comic.cs
    │   ├── Novel.cs
    │   ├── ResearchPaper.cs
    │   └── TextBook.cs
    ├── Interfaces
    │   ├── ICanBorrow.cs
    │   └── IPrintable.cs
    ├── ManageLibrary
    │   └── Library.cs
    ├── Program.cs
    └── Users
        ├── Customer.cs
        ├── Librarian.cs
        └── Person.cs
