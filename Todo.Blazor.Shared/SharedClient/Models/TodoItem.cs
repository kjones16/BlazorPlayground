namespace Todo.Blazor.Shared.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class TodoItem
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public long ListId { get; set; }

        public bool IsComplete { get; set; }

        [Required]
        [MaxLength(125)]
        public string Title { get; set; }
    }
}
