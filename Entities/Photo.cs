using BlackCoderBlogMaster.Entities.Common;

namespace BlackCoderBlogMaster.Entities;

public class Photo : BaseEntity
{
    public string Src { get; set; } = string.Empty;
    public string? Caption { get; set; }

    public Guid ArticleId { get; set; }

    public virtual Article Article { get; set; } = new();
}