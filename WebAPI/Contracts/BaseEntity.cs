namespace WebAPI.Contracts;

public abstract class BaseEntity<T>
{
    public T? Id { get; set; }
    public DateTime CreatedAt { get; set; }
}

