using ef_add_delete;
using ef_add_delete.Entities;
using Microsoft.EntityFrameworkCore;

using (var context = new LibraryContext())
{
    // Toplu ekleme
    var newAuthors = new List<Author>
    {
        new Author { Name = "John Doe" },
        new Author { Name = "Jane Doe" }
    };
    context.Authors.AddRange(newAuthors);

    // Tekli ekleme
    var newBook = new Book { Title = "Sample Book", Id = Guid.NewGuid() };
    context.Books.Add(newBook);

    context.SaveChanges();
}


using (var context = new LibraryContext())
{
    var bookToUpdate = context.Books.Find(1);
    if (bookToUpdate != null)
    {
        bookToUpdate.Title = "Updated Book Title";
        context.SaveChanges();
    }
}


