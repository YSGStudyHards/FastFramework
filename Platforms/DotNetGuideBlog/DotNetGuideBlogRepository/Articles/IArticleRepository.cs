using DotNetGuideBlogModel.Entities;

namespace DotNetGuideBlogRepository.Articles;

public interface IArticleRepository
{
    Task<Article?> GetByIdAsync(int id);

    Task<List<Article>> GetListAsync();

    Task<Article> AddAsync(Article article);

    Task<bool> UpdateAsync(Article article);

    Task<bool> DeleteAsync(int id);
}
