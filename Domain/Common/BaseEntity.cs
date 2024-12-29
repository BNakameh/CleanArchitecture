namespace Domain.Common;
public abstract class BaseEntity : Entity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public DateTimeOffset LastUpdatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? LastUpdatedBy { get; set; }
}
