using DotNetGuideBlogDAL.Articles;
using DotNetGuideBlogModel.Entities;

namespace DotNetGuideBlogRepository.Articles;

public class ArticleRepository(IArticleDal articleDal) : IArticleRepository
{
    public Task<Article?> GetByIdAsync(int id)
    {
        return articleDal.GetByIdAsync(id);
    }

    public Task<List<Article>> GetListAsync()
    {
        return articleDal.GetListAsync();
    }

    public Task<Article> AddAsync(Article article)
    {
        return articleDal.AddAsync(article);
    }

    public Task<bool> UpdateAsync(Article article)
    {
        return articleDal.UpdateAsync(article);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return articleDal.DeleteAsync(id);
    }
}
