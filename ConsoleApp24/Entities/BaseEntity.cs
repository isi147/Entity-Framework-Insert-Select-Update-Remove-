namespace ConsoleApp24.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime InsertionDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsDeleted { get; set; }
}
