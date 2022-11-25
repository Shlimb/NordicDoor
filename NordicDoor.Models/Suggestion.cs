using System.ComponentModel.DataAnnotations;

namespace NordicDoor.Models;

public class Suggestion
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
    public int Deadline { get; set; }
}
