using System.ComponentModel.DataAnnotations;

namespace API.Models;

public partial class Customer
{
    [Key]
    public int PersonId { get; set; }

    public virtual Person Person { get; set; }
}