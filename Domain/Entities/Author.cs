using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;
public sealed class Author : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public AuthorStatus Status { get; set; }
}
