using DotNetGuideBlogModel.Dtos;
using DotNetGuideBlogModel.Entities;
using DotNetGuideBlogRepository.Articles;

namespace DotNetGuideBlogBLL.Articles;

public class ArticleService(IArticleRepository articleRepository) : IArticleService
{
    public async Task<List<ArticleDto>> GetListAsync()
    {
        var articles = await articleRepository.GetListAsync();
        return articles.Select(MapToDto).ToList();
    }

    public async Task<ArticleDto?> GetByIdAsync(int id)
    {
        if (id <= 0)
        {
            return null;
        }

        var article = await articleRepository.GetByIdAsync(id);
        return article is null ? null : MapToDto(article);
    }

    public async Task<ArticleDto?> AddAsync(CreateArticleRequest request)
    {
        if (!IsValidTitle(request.Title))
        {
            return null;
        }

        var entity = new Article
        {
            Title = request.Title.Trim(),
            Content = request.Content?.Trim() ?? string.Empty,
            Author = request.Author?.Trim() ?? string.Empty
        };

        var created = await articleRepository.AddAsync(entity);
        return MapToDto(created);
    }

    public async Task<bool> UpdateAsync(int id, UpdateArticleRequest request)
    {
        if (id <= 0 || !IsValidTitle(request.Title))
        {
            return false;
        }

        var existing = await articleRepository.GetByIdAsync(id);
        if (existing is null)
        {
            return false;
        }

        existing.Title = request.Title.Trim();
        existing.Content = request.Content?.Trim() ?? string.Empty;
        existing.Author = request.Author?.Trim() ?? string.Empty;

        return await articleRepository.UpdateAsync(existing);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        if (id <= 0)
        {
            return false;
        }

        var existing = await articleRepository.GetByIdAsync(id);
        if (existing is null)
        {
            return false;
        }

        return await articleRepository.DeleteAsync(id);
    }

    private static bool IsValidTitle(string? title)
    {
        return !string.IsNullOrWhiteSpace(title);
    }

    private static ArticleDto MapToDto(Article article)
    {
        return new ArticleDto
        {
            Id = article.Id,
            Title = article.Title,
            Content = article.Content,
            Author = article.Author,
            CreateTime = article.CreateTime,
            UpdateTime = article.UpdateTime
        };
    }
}
