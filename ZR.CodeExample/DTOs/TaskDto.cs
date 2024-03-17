using System.ComponentModel.DataAnnotations;

namespace ZR.CodeExample.DTOs;

public class TaskDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }=string.Empty;

    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }
}
