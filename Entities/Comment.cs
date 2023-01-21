using BlackCoderBlogMaster.Entities.Common;

namespace BlackCoderBlogMaster.Entities;

public class Comment : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }

    public Guid? AuthorId { get; set; }
    public Guid ArticleId { get; set; }

    public virtual Author? Author { get; set; }
    public virtual Article Article { get; set; } = new();
}