using BlackCoderBlogMaster.Entities.Common;

namespace BlackCoderBlogMaster.Entities;

public class Article : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Detail { get; set; } = string.Empty;
    public string Metadata { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public bool IsPublished { get; set; } = false;

    public Guid AuthorId { get; set; }
    public Guid CategoryId { get; set; }

    public virtual Author Author { get; set; } = new();
    public virtual Category Category { get; set; } = new();
    public virtual ICollection<Photo> Photos { get; set; } = new HashSet<Photo>();
    public virtual ICollection<Comment>? Comments { get; set; }
}