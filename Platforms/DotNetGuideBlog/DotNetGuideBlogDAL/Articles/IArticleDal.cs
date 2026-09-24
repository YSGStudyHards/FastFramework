using DotNetGuideBlogModel.Entities;

namespace DotNetGuideBlogDAL.Articles;

public interface IArticleDal
{
    Task<List<Article>> GetListAsync();

    Task<Article?> GetByIdAsync(int id);

    Task<Article> AddAsync(Article article);

    Task<bool> UpdateAsync(Article article);

    Task<bool> DeleteAsync(int id);
}
