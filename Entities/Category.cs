using BlackCoderBlogMaster.Entities.Common;

namespace BlackCoderBlogMaster.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Metadata { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public byte Spacing { get; set; }

    public Guid? ParentId { get; set; }

    public virtual Category? Parent { get; set; }
    public virtual ICollection<Article>? Articles { get; set; }
}