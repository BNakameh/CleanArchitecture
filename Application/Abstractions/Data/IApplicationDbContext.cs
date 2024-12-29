using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;
public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<Author> Authors { get; }
    DbSet<Book> Books { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
