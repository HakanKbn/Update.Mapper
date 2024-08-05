using System.ComponentModel.DataAnnotations;

public abstract class BaseEntity
{
    public Guid Id { get; set; }

    [Timestamp]
    [Required]
    public byte[] RowVersion { get; set; }
}