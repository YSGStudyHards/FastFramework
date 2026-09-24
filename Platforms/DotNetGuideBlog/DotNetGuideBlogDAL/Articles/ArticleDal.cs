using System.Collections.Concurrent;
using System.Threading;
using DotNetGuideBlogModel.Entities;

namespace DotNetGuideBlogDAL.Articles;

/// <summary>
/// 使用线程安全内存集合模拟数据库访问。
/// </summary>
public class ArticleDal : IArticleDal
{
    private readonly ConcurrentDictionary<int, Article> _articles = new();
    private int _idSeed;

    public Task<List<Article>> GetListAsync()
    {
        var result = _articles.Values
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreateTime)
            .Select(Clone)
            .ToList();

        return Task.FromResult(result);
    }

    public Task<Article?> GetByIdAsync(int id)
    {
        if (_articles.TryGetValue(id, out var article) && !article.IsDeleted)
        {
            return Task.FromResult<Article?>(Clone(article));
        }

        return Task.FromResult<Article?>(null);
    }

    public Task<Article> AddAsync(Article article)
    {
        var now = DateTime.UtcNow;
        var entity = Clone(article);
        entity.Id = Interlocked.Increment(ref _idSeed);
        entity.CreateTime = now;
        entity.UpdateTime = null;
        entity.IsDeleted = false;

        _articles[entity.Id] = entity;
        return Task.FromResult(Clone(entity));
    }

    public Task<bool> UpdateAsync(Article article)
    {
        if (!_articles.TryGetValue(article.Id, out var existing) || existing.IsDeleted)
        {
            return Task.FromResult(false);
        }

        var updated = Clone(existing);
        updated.Title = article.Title;
        updated.Content = article.Content;
        updated.Author = article.Author;
        updated.UpdateTime = DateTime.UtcNow;

        _articles[article.Id] = updated;
        return Task.FromResult(true);
    }

    public Task<bool> DeleteAsync(int id)
    {
        if (!_articles.TryGetValue(id, out var existing) || existing.IsDeleted)
        {
            return Task.FromResult(false);
        }

        var deleted = Clone(existing);
        deleted.IsDeleted = true;
        deleted.UpdateTime = DateTime.UtcNow;

        _articles[id] = deleted;
        return Task.FromResult(true);
    }

    private static Article Clone(Article source)
    {
        return new Article
        {
            Id = source.Id,
            Title = source.Title,
            Content = source.Content,
            Author = source.Author,
            CreateTime = source.CreateTime,
            UpdateTime = source.UpdateTime,
            IsDeleted = source.IsDeleted
        };
    }
}
