using BlackCoderBlogMaster.Entities.Common;

namespace BlackCoderBlogMaster.Entities;

public class Author : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string City { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public virtual ICollection<Article>? Articles { get; set; }
    public virtual ICollection<Comment>? Comments { get; set; }
}