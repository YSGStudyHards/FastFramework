namespace DotNetGuideBlogModel.Dtos;

public class UpdateArticleRequest
{
    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;
}
