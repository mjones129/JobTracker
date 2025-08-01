using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Job
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    [Required]
    public string Location { get; set; } = string.Empty;
}