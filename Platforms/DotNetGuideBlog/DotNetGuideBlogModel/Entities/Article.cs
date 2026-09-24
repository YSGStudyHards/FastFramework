namespace DotNetGuideBlogModel.Entities;

public class Article
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool IsDeleted { get; set; }
}
