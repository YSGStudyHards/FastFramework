using DotNetGuideBlogModel.Dtos;

namespace DotNetGuideBlogBLL.Articles;

public interface IArticleService
{
    Task<List<ArticleDto>> GetListAsync();

    Task<ArticleDto?> GetByIdAsync(int id);

    Task<ArticleDto?> AddAsync(CreateArticleRequest request);

    Task<bool> UpdateAsync(int id, UpdateArticleRequest request);

    Task<bool> DeleteAsync(int id);
}
