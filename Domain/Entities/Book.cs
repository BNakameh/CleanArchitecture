using Domain.Common;

namespace Domain.Entities;
public sealed class Book : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<Book> Books { get; private set; } = new List<Book>();
}
