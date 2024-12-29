namespace API.Entities;

public class Employee
{
    public int PersonId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Active { get; set; }
}
